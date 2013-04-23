//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Switcher  - a base class for the objects like levers, buttons etc.
//-----------------------------------------------------------------------------

function SwitcherData::create(%data)
{
	%obj = new StaticShape() {
		class = "Switcher";
		dataBlock = %data;
	};
	return %obj;
}

function SwitcherData::onAdd(%this,%obj)
{
	%obj.init();
}

function SwitcherData::onEndSequence(%this, %obj, %slot)
{
	%obj.onAnimationEnd(%slot);
}

function Switcher::init(%this)
{
	Openable::init(%this);
}


function Switcher::open(%this)
{
	Openable::open(%this);
}

function Switcher::close(%this)
{
	Openable::close(%this);
}

function Switcher::onAnimationEnd(%this, %slot)
{
	Openable::onAnimationEnd(%this, %slot);
}

function Switcher::setLockedState(%this, %flg)
{
    Openable::setLockedState(%this, %flg);            
}

function Switcher::use(%this, %user)
{
    Openable::use(%this, %user);
}

ActivatePackage(TemplateFunctions);	// opening package with template functions
inheritTemplate("AbstractSwitcher", "AbstractOpenable");//register AbstractSwitcher template
DeactivatePackage(TemplateFunctions); // close package with template functions