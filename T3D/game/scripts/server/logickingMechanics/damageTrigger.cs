//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// DamageTrigger- a trigger that damages object when it 
// enters a trigger
//-----------------------------------------------------------------------------
datablock TriggerData(DamageTrigger : EventTrigger)
{
	tickPeriodMS = 300;
	superClass = "EventTrigger";
};

//-----------------------------------------------------------------------------
function DamageTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function DamageTrigger::onLeaveTrigger(%this, %trigger, %obj)
{
	Parent::onLeaveTrigger(%this, %trigger, %obj);
}

function DamageTrigger::onTickTrigger(%this, %trigger)
{
	Parent::onTickTrigger(%this, %trigger);

	if(!%trigger.isEnabled()) return;
	// iterate through all objects in trigger and damage them
	for(%i = 0; %i < %trigger.getNumObjects(); %i++)
	{
		%targetObject = %trigger.getObject(%i);
		if(!%targetObject.playerControlled  && %this.ignoreAI) 
			continue;
		%targetObject.damage(%trigger, %targetObject.getPosition(),	%trigger.damage, %trigger.damageType);
	}
}

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
activatePackage(TemplateFunctions);
inheritTemplate("DamageTrigger", "EventTrigger");
registerTemplate("DamageTrigger", "Triggers", "EventTrigger::create(DamageTrigger);");
setTemplateField("DamageTrigger", "damage", "3");
setTemplateField("DamageTrigger", "damageType", "TriggerDamage");
deactivatePackage(TemplateFunctions);