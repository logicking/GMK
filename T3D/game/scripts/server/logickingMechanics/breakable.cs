//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// BreakableData  - a base class for breakable objects,
// 
//-----------------------------------------------------------------------------
function BreakableData::create(%data)
{
    %obj = new StaticShape() {
      dataBlock = %data;
	  class = "Breakable";
   };
   return %obj;
}

function BreakableData::onAdd(%this,%obj)
{
	if(%obj.health $= "")
		%obj.health = %this.health;
	if(%obj.healthBound $= "")
		%obj.healthBound = %this.healthBound;
}

function BreakableData::damage(%this, %obj, %position, %source, %amount, %damageType)
{
	if(%obj.enabled != true) return;

	Parent::damage(%this, %obj, %position, %source, %amount, %damageType);
   
	%curHealth = %obj.health - %amount;
	if(%obj.health > 0)
	{
		%obj.health = %curHealth;
		if(%curHealth <= 0)
		{
			%obj.explode();
		}
		else if(%curHealth <= %obj.healthBound)
		{
			%obj.prepareExplosion();
		}
	}
}

function Breakable::prepareExplosion(%obj)
{
	%this = %obj.getDataBlock();
	if(%obj.explosionPrepared !$= "") return;
	%obj.explosionPrepared = true;

	if(%this.preparatoryEffect !$= "")
	{
		%obj.preparatoryEffectInstance = new VisualEffect() { 
			dataBlock = %this.preparatoryEffect; 
			position = %obj.getPosition();
		};
	}
	%obj.schedule(%this.timeToBreak + %this.timeToBreakVariance * getRandom(), "explode");
}

function Breakable::explode(%obj)
{
	if(%obj.exploded !$= "") return;
	%obj.exploded = true;
	
	%obj.schedule(%obj.getDataBlock().timeToVanish - 1000, "startFade", 1000, 0, true);
	%obj.schedule(%obj.getDataBlock().timeToVanish, "delete");
	
	if(isObject(%obj.preparatoryEffectInstance))
		%obj.preparatoryEffectInstance.schedule(100, "delete");
	%obj.preparatoryEffectInstance = "";
	
	if(%obj.getDataBlock().breakEffect !$= "")
	{
		new VisualEffect() 
		{ 
			dataBlock = %obj.getDataBlock().breakEffect;
			position = %obj.getPosition();
		};
	}
	
	if(%obj.getDataBlock().breakAnimation !$= "") 
	{
		%obj.playThread(0, %obj.getDataBlock().breakAnimation);
	}
}

//temporary, for allowing explosions to actually damage objects
function VisualEffectData::doDamage(%this, %obj, %radius, %damage, %damageType, %impulse)
{
	//echo("doDamage:  radius ",%radius, ", damage ", %damage, ", type ", %damageType, ", impulse ", %impulse);
	radiusDamage(%obj, %obj.getPosition(), %radius, %damage, %damageType, %impulse);
}


//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);
registerTemplate("AbstractBreakable", "Abstracts", "");
setTemplateField("AbstractBreakable", "health", "60", "", "Misc", "Health of breakable.");
setTemplateField("AbstractBreakable", "healthBound", "50", "", "Misc", "Level of health, when breakable will start burning.");
// actions
setTemplateAction("AbstractBreakable", "prepareExplosion", "explodes object");
// events
setTemplateEvent("AbstractBreakable", "onDamage", "", " %this - our object. ");
setTemplateEvent("AbstractBreakable", "onPrepareExplosion", "", " %this - our object. ");
setTemplateEvent("AbstractBreakable", "onExplosion", "", " %this - our object. ");
DeactivatePackage(TemplateFunctions);