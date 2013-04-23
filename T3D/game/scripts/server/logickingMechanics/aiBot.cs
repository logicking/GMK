//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------
// General AI Bot - a base class for all AI entities
//-----------------------------------------------------------------------------
function AiBotData::create(%data)
{  	
	%bot = new AiBot() {
		dataBlock = %data;
	};
	return %bot;
}

function AiBotData::onAdd(%this,%obj)
{
	if(%this.weapon !$= "")
		%obj.mountImage(%this.weapon, 0);
	if(%this.ammo !$= "")
		%obj.setInventory(%this.ammo, %this.ammoCount);
	
	%obj.setHealth(%obj.health);
	%obj.signal("onSpawn");
	
	%obj.init();
}

function AiBot::init(%this)
{
	//reactivate guard
	%this.setGuard(%this.getGuardObject());        
}



// bot  saw a new enemy
function AiBotData::onNewEnemy(%this, %obj)
{
	if(!%obj.hasRealEnemy()) return;
	
	//echo("onNewEnemy ", %obj.getName());

	%obj.allowMovement(true);
	%obj.enableChase(true, %this.chaseCloseDist,  %this.chaseFarDist); 
	%obj.enableFlee(true, %this.chaseCloseDist - 1.5,  %this.chaseFarDist - 1.5); 
	%obj.enableStrafe(true, %this.strafeMinDist, %this.strafeMaxDist, %this.strafeChangeDirTime);
	%obj.attackParams(%this.attackDist, %this.attackFov); 
	%obj.setAimObject(%obj.getEnemy(), "0 0 1.9");
	
	%obj.attackingWithWeapon = true;
	
	%obj.signal("onAlert", %obj.getEnemy());
}

function AiBotData::onNoEnemy(%this, %obj)
{
	//echo("onNoEnemy ", %obj.getName());
	%obj.allowMovement(false);
	%obj.attackingWithWeapon = false;
	%obj.stopShooting();
	%obj.stop();
	
	//reactivate guard
	%obj.setGuard(%obj.getGuardObject());
	%obj.signal("onNoEnemy");
}


function AiBotData::onTargetEnterLOS(%this, %obj)
{
	if(%obj.attackingWithWeapon)
		%obj.startShooting();
}

function AiBotData::onTargetExitLOS(%this, %obj)
{
	if(%obj.attackingWithWeapon)
		%obj.stopShooting();
}

// enemy is within reach of current attack: attackDist and attackFov
function AiBotData::onReadyToAttack(%this, %obj)
{
	//echo(" onReadyToAttack ");
	if(!%obj.hasRealEnemy())
	{
		%obj.readyToAttack = false;
		return;
	}
	%obj.readyToAttack = true;
}

// can't attack now
function AiBotData::onNotReadyToAttack(%this, %obj)
{
	//echo(" onNotReadyToAttack ");
	%obj.readyToAttack = false;
}


function AiBotData::animationDone(%this, %obj)
{
	if(%obj.animCallback !$= "")
	{
		Helpers::evalWithThisObj(%obj.animCallback, %this, %obj);
		%obj.animCallback = "";
	}
}


//-----------------------------------------------------------------------------
// Handle damage and death events
//-----------------------------------------------------------------------------

function AiBotData::playDeath(%this, %obj)
{
   %obj.setActionThread("Death1");
   %obj.playAudio(0, %this.deathSnd);
}


function AiBotData::playPain(%this, %obj)
{
	if(%this.painSndCount $= "")
		%obj.playAudio(0, %this.painSnd);
	else
	{
		%obj.playAudio(0, %this.painSnd[getRandom(%this.painSndCount - 1)]);
	}
}



function AiBotData::damage(%this, %obj, %sourceObject, %position, %damage, %damageType)
{
   if (%obj.getState() $= "Dead")
      return;
   %obj.damagePos = %position;
   %obj.applyDamage(%damage);
}

function AiBot::setHealth(%this, %health)
{
	if(%health !$= "")
	{
		%curDamage = mClamp(%this.getDataBlock().maxDamage - %health, 0, %this.getDataBlock().maxDamage);
		%this.applyDamage(%curDamage);
	}	
}


function AiBotData::onDamage(%this, %obj, %delta)
{
   // This method is invoked by the ShapeBase code whenever the
   // object's damage level changes.
    if (%delta > 0 && %obj.getState() !$= "Dead") 
    {
        %obj.signal("onDamage");  
	  
        if (%delta > 5)
            %this.playPain(%obj);
    }
}

function AiBotData::onDisabled(%this, %obj, %state)
{
	// Release the main weapon trigger
	%obj.setImageTrigger(0, false);
	
	if(isObject(%this.ragdoll) && physicsPluginPresent())
	{
	   //%obj.disableCollision();
		createRagDoll(%this.ragdoll, %obj);
		%obj.startFade(0, 0, true);
		%obj.schedule(0, "delete");
	}
	else
	{
		%this.playDeath(%obj);
		%obj.schedule($CorpseTimeoutValue - 1000, "startFade", 1000, 0, true);
		%obj.schedule($CorpseTimeoutValue, "delete");
	}
	%obj.signal("onDeath");

	// spawn an item on death
	if(isObject(%obj.item))
	{
		%item = new Item() {
			dataBlock = %obj.item;
			rotate = true;
		};
		if(isObject(%item))
		{
			%transform = %obj.getTransform();
	        %transform = setWord(%transform, 2, getWord(%transform, 2) + 4);
			%item.setTransform(%transform);
		}
	}
}

//Shooting
function AiBot::singleShot(%this)
{
	if(%this.isDead()) 
	{
		%this.shootingStarted = false;
		return;
	}
	
	if(%this.shootingStarted == true)
	{
		// The shooting delay is used to pulse the trigger
		if(%this.readyToAttack)
		{
			%this.setImageTrigger(0,true);
			%this.setImageTrigger(0,false);
		}
		//else
			//echo(" DONT SHOOT!!! ", %this.getName());
		
		%delayVariant = %this.getDataBlock().shootingDelayVariant;
		if(%delayVariant $= "") %delayVariant = 0;
		%this.schedule(%this.getDataBlock().shootingDelay + %delayVariant * getRandom(), singleShot);
	}
}

function AiBot::startShooting(%this)
{
	if(%this.shootingStarted != true)
	{
		%this.shootingStarted = true;
		%this.singleShot();
	}
}

function AiBot::stopShooting(%this)
{
	%this.shootingStarted = false;
}

//------------------------------------------------------------------------------------------
// Following waypoint's path
$Path::TO_TARGET = 1; // Moving to target node and stopping there
$Path::CYCLE = 2; //Cycling though nodes
$Path::PATROL = 3; //Going to the first and finish nodes, changing direction on both ends
$Path::RANDOM = 4; //Wandering to random nodes

function AiBotData::onReachDestination(%this,%obj)
{
	%obj.onReachDestination();
}

function AiBot::onReachDestination(%this)
{
	if (%this.pathMovementType !$= "") 
	{
		if (%this.currentNode == %this.targetNode && 
				%this.pathMovementType == $Path::TO_TARGET)
		{
			%this.signal("onPathNodeReached", %this.currentNode);
			%this.onEndOfPath();
		}
		else
			%this.moveToNextNode();
	}
}

function AiBot::onEndOfPath(%this)
{
	%this.pathMovementType = "";
	%this.signal("onPathEnd");
}

function AiBot::resetPath(%this)
{
	%this.pathMovementType = "";
	%this.path = "";
	%this.pathMovementType = "";
	%this.pathMoveForward = "";
	%this.targetNode = "";
}

// %path - path object
// %movementType can be one of $Path::TO_TARGET, $Path::CYCLE,  $Path::PATROL, $Path::RANDOM
function AiBot::followPath(%this, %path, %movementType, %moveForward, %startNode, %targetNode)
{
	// Start the player following a path
	if (!isObject(%path)) {
		%this.onEndOfPath();
		return;
	}
	   
	//moving forward path by default
	if(%moveForward $= "" || %moveForward < 0 ||  %moveForward > 1) %moveForward = 1;
   
	if (%this.path $= %path && %this.currentNode !$="" && 
				%this.currentNode >= 0 && %this.currentNode < %path.getCount())
		%startNode = %this.currentNode;
		
	if(%startNode $="" || %startNode < 0 || %startNode >= %path.getCount())
		%startNode = 0;
	if(%targetNode $="" || %targetNode < 0 || %targetNode >= %path.getCount())
		%targetNode = %path.getCount() - 1;
		
	//echo("sn ", %startNode, " tn ", %targetNode);
	
	%this.path = %path;
	%this.pathMovementType = %movementType;
	%this.pathMoveForward = %moveForward;
	%this.targetNode = %targetNode;
	%this.moveToNode(%startNode);
}

function AiBot::moveToNextNode(%this)
{
	%this.signal("onPathNodeReached", %this.currentNode);
	%nextNode = -1;
	
	if(%this.pathMovementType == $Path::RANDOM)
	{
		%nextNode = %this.currentNode;
		while(%nextNode == %this.currentNode)
			%nextNode = getRandom(%this.path.getCount() - 1);
	}
	else
	{
		%nextNode = %this.currentNode + 1 * (%this.pathMoveForward == 1) + (-1) * (%this.pathMoveForward == 0);
		
		if(%nextNode == %this.path.getCount())
		{
			if(%this.pathMovementType == $Path::CYCLE || %this.pathMovementType == $Path::TO_TARGET)
				%nextNode = 0;
			else if(%this.pathMovementType == $Path::PATROL)
			{
				%this.pathMoveForward = 0;
				%nextNode = %this.path.getCount() - 1;
			}
		}
		if(%nextNode == -1)
		{
			if(%this.pathMovementType == $Path::CYCLE  || %this.pathMovementType == $Path::TO_TARGET)
				%nextNode = %this.path.getCount() - 1;
			else if(%this.pathMovementType == $Path::PATROL)
			{
				%this.pathMoveForward = 1;
				%nextNode = 1;
			}
		}
	}
	%this.moveToNode(%nextNode);
}

function AiBot::moveToNode(%this, %index)
{
	// Move to the given path node index
	%this.currentNode = %index;
	%node = %this.path.getObject(%index);

	// something went wrong
	if(!isObject(%node))
	{
		error("Wrong node num ", %index, " for bot ", %this.getName(), " in path ", %this.path.getName());
		%this.onEndOfPath();
		return;
	}

	%slowDown = false;
	if(%this.pathMovementType == $Path::TO_TARGET)
		%slowDown = (%index == %this.targetNode);
	
	%this.setMoveDestination(%node.getTransform(), %slowDown);
}

function AiBot::getGuardObject(%this)
{
	return %this.guardObject;
}


function AiBot::hasRealEnemy(%this)
{
	if(!%this.getEnemy()) return false;
	
	//special case, when the "enemy" is the object we are guarding
	if(isObject(%this.getGuardObject()) &&
		%this.getGuardObject().getId() == %this.getEnemy().getId()) return false;

	return true;
}


function AiBot::setGuard(%this, %guardObject)
{
	//Can't be guard to ourselves.
	if(isObject(%guardObject) && %guardObject.getId() == %this.getId()) return;
	
	%this.guardObject = %guardObject;
	
	if(!isObject(%this.getEnemy()) && isObject(%guardObject))
	{
		%this.allowMovement(true);
		%this.enableChase(true, %this.guardCloseDist, %this.guardFarDist); 
		// bot will retreat if we'll come to close
		%this.enableFlee(true, 2,  4.5);
		// disabling strafe
		%this.enableStrafe(false, 0, 0, 0);
		// no real attack possible
		%this.attackParams(-1, 0);
		%this.setAimObject(%guardObject, "0 0 1.9");
		// assigning guardObject as a fake enemy,  to enable manovering algorithms
		%this.setEnemy(%guardObject);
	}
}

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
activatePackage(TemplateFunctions);
registerTemplate("AiBot", "Abstracts", "");
//Events
setTemplateEvent("AiBot", "onSpawn", "", "%this - AiBot. Evokes bot just has spawned.");
setTemplateEvent("AiBot", "onDamage", "", "%this - AiBot. %arg0 - who cast damage.", 1);
setTemplateEvent("AiBot", "onAlert", "", "%this - AiBot. %arg0 - who cause alert.", 1);
setTemplateEvent("AiBot", "onDeath", "", "%this - AiBot");
setTemplateEvent("AiBot", "onNoEnemy", "", "%this - AiBot. There's no more enemies.");

setTemplateEvent("AiBot", "onPathNodeReached", "", "%this - AiBot, %arg0 - current node index", 1);
setTemplateEvent("AiBot", "onPathEnd", "", "%this - AiBot");
//Actions
setTemplateAction("AiBot", "setEnemy", "%arg0 - must by an enemy object", "%enemyObject");
setTemplateAction("AiBot", "followPath", "%path - path object, %movementType", "%path, %movementType");
setTemplateAction("AiBot", "enablePerception", "%arg0 - must by bool value", "%flag");
setTemplateAction("AiBot", "setGuard", "%arg0 - must by an object to guard", "%guardObject");
//Fields
setTemplateField("AiBot", "health", "100", "", "Misc", "Bot's health.");
setTemplateField("AiBot", "blockMovement", "false", "bool", "Misc", "Blocks bot movement.");
setTemplateField("AiBot", "item", "", "", "Misc", "An item dataBlock that bot spawns on his death.");
//AI 
setTemplateField("AiBot", "perceptionEnabled", "false", "bool", "AI", "Perception activity flag.");
setTemplateField("AiBot", "viewDist", 40, "", "AI", "Bot's max view dist.");
setTemplateField("AiBot", "ourTeam", $TEAMS_LIST, "list", "AI", "Bot's team name.");
setTemplateField("AiBot", "oppositeTeam", $TEAMS_LIST, "list", "AI", "Enemy to bot team.");
//Guard
setTemplateField("AiBot", "guardObject",  "", "", "Guard", "Target to guard.");
setTemplateField("AiBot", "guardCloseDist", 3, "", "Guard", "Close guard dist.");
setTemplateField("AiBot", "guardFarDist", 5, "", "Guard", "Far guard dist.");
deactivatePackage(TemplateFunctions);


