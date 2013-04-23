//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Locker  - a base class for the lockers objects,
//-----------------------------------------------------------------------------

function LockerData::create(%data)
{
	%obj = new StaticShape() {
		class = "Locker";
		dataBlock = %data;
	};
	return %obj;
}

function LockerData::onAdd(%this,%obj)
{
	%obj.init();
}

function LockerData::onEndSequence(%this, %obj, %slot)
{
	%obj.onAnimationEnd(%slot);
}

function Locker::init(%this)
{
	Openable::init(%this);
}

function Locker::open(%this)
{
	Openable::open(%this);
}

function Locker::close(%this)
{
	Openable::close(%this);
}

function Locker::onAnimationEnd(%this, %slot)
{
	Openable::onAnimationEnd(%this, %slot);
}

function Locker::setLockedState(%this, %flg)
{
    Openable::setLockedState(%this, %flg);            
}

function Locker::use(%this, %user)
{
    Openable::use(%this, %user);
}

ActivatePackage(TemplateFunctions);	// opening package with template functions
inheritTemplate("AbstractLocker", "AbstractOpenable");//register AbstractLocker template
DeactivatePackage(TemplateFunctions); // close package with template functions