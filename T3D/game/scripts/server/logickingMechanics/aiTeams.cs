//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------
// AI Teams functions
//-----------------------------------------------------------------------------
// You can have unlimited number of teams
// %bot = createNewBot();
// %bot.assignTeam($BOTS_TEAM, $PLAYERS_TEAM);  // $BOTS_TEAM - our team, $PLAYERS_TEAM - opponent teams
//-----------------------------------------------------------------------------

//Interval for bot's sensor's update
$botUpdateTime = 300;
//Max distance where AI can see enemy
$defaultViewDist = 30;

// global array that stores info about all members of all teams
$teamsList = new ArrayObject();
for(%i = 0; %i < getWordCount($TEAMS_LIST); %i++)
{
    $teamsList.add(getWord($TEAMS_LIST, %i), new ArrayObject());
}
$teamsList.echo();

function clearTeams()
{
	for(%i = 0; %i < $teamsList.count(); %i++)
	{
		$teamsList.getValue(%i).empty();
	}
}

// prints items in teams
function echoTeams()
{
	for(%i = 0; %i < $teamsList.count(); %i++)
	{
		$teamsList.getValue(%i).echo();
	}
}


function addToTeam(%obj, %team)
{
	%teamArray = $teamsList.getValue($teamsList.getIndexFromKey(%team));
	if(isObject(%teamArray))
	{
		%teamArray.add(%obj.getId(), "");
		%obj.ourTeam = %team;
	}
	else
		error(" Can't add ", %obj.getName(), ",  there's no such team ", %team);
}

function removeFromTeam(%obj, %team)
{
	%teamArray = $teamsList.getValue($teamsList.getIndexFromKey(%team));
	if(isObject(%teamArray))
	{
		%obj.ourTeam = "";
		%teamArray.erase(%teamArray.getIndexFromKey(%obj.getId()));
	}
}

function AiBot::assignTeam(%this, %ourTeam, %oppositeTeam)
{
	removeFromTeam(%this, %this.ourTeam);
	addToTeam(%this, %ourTeam);
	%this.oppositeTeam = %oppositeTeam;
}

function AiBot::getViewDist(%this)
{
    return %this.viewDist || %this.getDataBlock().viewDist || $defaultViewDist;
}


function AiBot::enablePerception(%this, %flg)
{
    %this.perceptionEnabled = %flg;
}

function AiBot::isPerceptionEnabled(%this)
{
    return %this.perceptionEnabled !$= "" && %this.perceptionEnabled != 0;
}

function AiBot::scheduledUpdate(%this)
{
	%this.updatePerception();
	%this.schedule($botUpdateTime, "scheduledUpdate");
}

function AiBot::updatePerception(%this)
{
    if(! %this.isPerceptionEnabled() ) return;
    
	//finding closest enemy from opposite team
	%currentEnemy = "";
	%currentEnemyDist = 9999999;
	%ourPos = %this.getPosition();
	
	%teamArray = $teamsList.getValue($teamsList.getIndexFromKey(%this.oppositeTeam));
	if(isObject(%teamArray) && %teamArray.count() > 0)
	{
		for(%i = 0; %i < %teamArray.count(); %i++)
		{
			%enemy = %teamArray.getKey(%i);
			if(isObject(%enemy) && %enemy.getState() !$= "Dead")
			{
				%dist = VectorDist(%enemy.getPosition(), %ourPos);
				if(%dist < %currentEnemyDist && %dist < %this.getViewDist())
				{
					%currentEnemy = %enemy;
					%currentEnemyDist = %dist;
				}
			}
		}
	}
	
	if(%currentEnemy !$= "")
		%this.setEnemy(%currentEnemy);
}

package aiTeamsFunctions
{
    function AiBot::init( %this )
    {
        parent::init( %this );
        
        %this.schedule($botUpdateTime, "scheduledUpdate");        
        
        if( %this.ourTeam !$= "" && %this.oppositeTeam !$= "" )
            %this.assignTeam( %this.ourTeam, %this.oppositeTeam );
        else
			//if we have no team assigned then there's no reason to update perception
            %this.enablePerception(false);
    }
    
    function AiBotData::onDisabled(%this, %obj, %state)
    {
        removeFromTeam(%obj, %obj.ourTeam);
        parent::onDisabled(%this, %obj, %state);
    }
};


//-----------------------------------------------------------------------------
// Activate Package.
//-----------------------------------------------------------------------------
activatePackage(aiTeamsFunctions);