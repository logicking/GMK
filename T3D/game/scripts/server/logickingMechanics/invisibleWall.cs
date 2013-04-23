//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// InvisibleWall allows to pass Player objects depending on
// it's type
//-----------------------------------------------------------------------------


function PhysicalZone::create(%isWall)
{
	%obj = new PhysicalZone() {
		polyhedron = "0.0000000 0.0000000 0.0000000 1.0000000 0.0000000 0.0000000 0.0000000 -1.0000000 0.0000000 0.0000000 0.0000000 1.0000000";
		class = "InvisibleWall";
		invisibleWall = %isWall;
	};
	return %obj;
}

// callback, to check whether react on object
function PhysicalZone::isWallForObject(%this, %obj)
{
	if(!%obj.playerControlled  && %this.ignoreAI) return false;
	return true;
}
//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
activatePackage(TemplateFunctions);
registerTemplate("InvisibleWall", "PhysicalZones", "PhysicalZone::create(true);");
setTemplateField("InvisibleWall", "ignoreAI", "1", "bool", "Misc", " Check true to ignore AI characters.");


registerTemplate("PhysicalZone", "PhysicalZones", "PhysicalZone::create(false);");
setTemplateField("PhysicalZone", "velocityMod", "1", "", "Misc", "");
setTemplateField("PhysicalZone", "gravityMod", "1", "", "Misc", "");
setTemplateField("PhysicalZone", "appliedForce", "0 0 0", "Misc", "");
deactivatePackage(TemplateFunctions);

