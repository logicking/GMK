//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Openable  - a base class for the objects like doors, lockers,
// switcher etc. Anything that can be opened and closed.
//-----------------------------------------------------------------------------

//--------------------------------------------------------------------------------------------------

function Openable::init(%this)
{
	%this.inTransition = false;
	//Set the right position of the Openable by starting corresponding animation
	if (%this.isOpen)
	{
		%this.setThreadDir(0, !%this.getDatablock().openAnimationReverse);
		%this.playThread(0, %this.getDatablock().openAnimation);
	}
}

function Openable::open(%this)
{
	if (!%this.getFieldValue(isLocked) && !%this.getFieldValue(isOpen) && !%this.inTransition)
	{
		%this.setFieldValue(inTransition, true);
		%this.playThread(0, %this.getDatablock().openAnimation);
		if (%this.getDatablock().openAnimationReverse)
		{
		   %this.setThreadDir(0, false);
		   %this.setThreadPosition(0, 1);
		}
		%this.playAudio(0, %this.getDatablock().openSnd);
		%this.signal("onOpening");
	}
}

function Openable::close(%this)
{
	if (!%this.getFieldValue(isLocked) && %this.getFieldValue(isOpen) && !%this.inTransition)
	{
		%this.setFieldValue(inTransition, true);
		%this.playThread(0, %this.getDatablock().closeAnimation);
		if (%this.getDatablock().closeAnimationReverse)
		{
		   %this.setThreadDir(0, false);
		   %this.setThreadPosition(0, 1);
		}
		%this.playAudio(0, %this.getDatablock().closeSnd);
		%this.signal("onClosing");
	}
}

function Openable::onAnimationEnd(%this, %slot)
{
	if(%slot != 0 || !%this.inTransition) return;
	%this.setFieldValue(inTransition, false);
	
	if(%this.isOpen)
	{
	    %this.setFieldValue(isOpen, false);
		%this.signal("onClosed");
	}
	else
	{
		%this.setFieldValue(isOpen, true);
		%this.signal("onOpened");
	}
}

function Openable::setLockedState(%this, %flg)
{
    %this.setFieldValue(isLocked, %flg);            
}

function Openable::use(%this, %user)
{
    if(!Usable::use(%this, %user)) return;
	
	//if the openable is closed check whether we need a key to unlock
	if(%this.getFieldValue(isLocked))
	{
		%key = %this.getFieldValue(keyToUnlock);
		echo("KEY:", %key, " user ", %user.getInventory(%key));
		if(%key !$="")
		{
			if(%user.getInventory(%key) > 0)
			{
				%this.isLocked = false;
				messageClient(%user.client, 'MsgDoorLocked', 'Door is unlocked.', %key.pickUpName);
			}
			else
			{
				messageClient(%user.client, 'MsgDoorLocked', 'You need a %1!', %key.pickUpName);
				return false;
			}
		}
		else
			messageClient(%user.client, 'MsgDoorLocked', 'Door is locked.');
	}

    if(%this.getFieldValue(isOpen))
        %this.close();
    else
        %this.open();
	return true;
}

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);	// opening package with template functions
inheritTemplate("AbstractOpenable", "AbstractUsable"); //register AbstractDoor template
setTemplateField("AbstractOpenable", "isLocked", "0", "bool", "Misc");
setTemplateField("AbstractOpenable", "keyToUnlock", "", "", "Misc", "", "Item");
setTemplateField("AbstractOpenable", "isOpen", "0", "bool", "Misc", " ");
// actions
setTemplateAction("AbstractOpenable", "open", " open door");
setTemplateAction("AbstractOpenable", "close", " close door");
// events
setTemplateEvent("AbstractOpenable", "onOpening", "echo(\"onOpening\");"); // opening begin
setTemplateEvent("AbstractOpenable", "onOpened", "echo(\"onOpened\");"); // fully opened
setTemplateEvent("AbstractOpenable", "onClosing", "echo(\"onClosing\");"); //closing begin
setTemplateEvent("AbstractOpenable", "onClosed", "echo(\"onClosed\");"); // fully closed

DeactivatePackage(TemplateFunctions); // close package with template functions