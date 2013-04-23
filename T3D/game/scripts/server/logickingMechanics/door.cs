//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Door  - a base class for the doors objects,
//-----------------------------------------------------------------------------

function DoorData::create(%data)
{
	%obj = new StaticShape() {
		class = "Door";
		dataBlock = %data;
	};
	return %obj;
}

function DoorData::onAdd(%this,%obj)
{
	%obj.init();
}

function DoorData::onEndSequence(%this, %obj, %slot)
{
	%obj.onAnimationEnd(%slot);
}

function Door::init(%this)
{
    Openable::init(%this);
}


function Door::open(%this)
{
	Openable::open(%this);
}

function Door::close(%this)
{
	Openable::close(%this);
}

function Door::onAnimationEnd(%this, %slot)
{
	Openable::onAnimationEnd(%this, %slot);
	%this.updatePhysics();
}

function Door::setLockedState(%this, %flg)
{
    Openable::setLockedState(%this, %flg);       
}

function Door::use(%this, %user)
{
    Openable::use(%this, %user);
}


//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);	// opening package with template functions
inheritTemplate("AbstractDoor", "AbstractOpenable");//register AbstractDoor template
DeactivatePackage(TemplateFunctions); // close package with template functions