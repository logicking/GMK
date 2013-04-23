//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Usable  - a base class for the objects that can be used,
// by player
//-----------------------------------------------------------------------------

function Usable::use(%this, %user)
{
    if(!%this.isEnabled()) return false;
    %this.signal("onUse", %user);
	return true;
}

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);	// opening package with template functions
registerTemplate("AbstractUsable", "Abstracts", "");
setTemplateField("AbstractUsable", "usable", "1", "bool", "");

DeactivatePackage(TemplateFunctions); // close package with template functions