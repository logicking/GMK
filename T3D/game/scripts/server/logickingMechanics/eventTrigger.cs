//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// EventTrigger- a trigger that evokes an event when object
// enters or leaves the trigger.
//-----------------------------------------------------------------------------

datablock TriggerData(EventTrigger)
{
   // The period is value is used to control how often the console
   // onTriggerTick callback is called while there are any objects
   // in the trigger.  The default value is 100 MS.
   tickPeriodMS = 300;
};

//-----------------------------------------------------------------------------
function EventTrigger::onAdd(%this, %trigger)
{
}

function EventTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	if(!%trigger.isEnabled()) return;
	if(!%obj.playerControlled  && %this.ignoreAI) return;
	%trigger.signal("onEnter", %obj); //evoking "onEnter" event with object which enters trigger as an argument
	//Parent::onEnterTrigger(%this, %trigger, %obj);
}

function EventTrigger::onLeaveTrigger(%this, %trigger, %obj)
{
	if(!%trigger.isEnabled()) return;
	if(!%obj.playerControlled && %this.ignoreAI) return;
	%trigger.signal("onLeave", %obj);
	//Parent::onLeaveTrigger(%this, %trigger, %obj);
}

function EventTrigger::onTickTrigger(%this, %trigger)
{
	if(!%trigger.isEnabled()) return;
	%trigger.signal("onTick");
	//Parent::onTickTrigger(%this, %trigger);
}

function EventTrigger::create(%dataBlock)
{  	
	%trigger = new Trigger() {
		dataBlock = %dataBlock;
		polyhedron = "0.0000000 0.0000000 0.0000000 1.0000000 0.0000000 0.0000000 0.0000000 -1.0000000 0.0000000 0.0000000 0.0000000 1.0000000";
	};
	return %trigger;
}

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
activatePackage(TemplateFunctions);
registerTemplate("EventTrigger", "Triggers", "EventTrigger::create(EventTrigger);");
setTemplateField("EventTrigger", "ignoreAI", "1", "bool", "Misc", " Check true to ignore AI characters.");
// events
setTemplateEvent("EventTrigger", "onEnter", "", " %this - trigger object. %arg0 - is an object that enters the trigger. ", 1);
setTemplateEvent("EventTrigger", "onLeave", "", " %this - trigger object. %arg0 - is an object that leaves the trigger. ", 1);
setTemplateEvent("EventTrigger", "onTick", "", " %this - trigger object. ");
// action
setTemplateAction("EventTrigger", "setEnabled", "(%isEnabled)");
deactivatePackage(TemplateFunctions);