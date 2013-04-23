//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Garage lever
datablock StaticShapeData(GarageLever)
{
	class = "SwitcherData";
    shapeFile = "art/shapes/lever/lever.dts";
    
    position = "0 0 0";
	Scale="1 1 1";
	emap = true;
	receiveSunLight = "1";
	
	openAnimation = "Switch_on";
	closeAnimation = "Switch_off";
	closeAnimationReverse = false;
	
	openSnd = switcherSound;
	closeSnd = switcherSound;
};

datablock SFXProfile(switcherSound)
{
	filename = "art/sound/switcher";
	description = AudioClose3d;
	preload = true;
};

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);
inheritTemplate("GarageLever", "AbstractSwitcher");
registerTemplate("GarageLever", "Switches", "SwitcherData::create(GarageLever);");
DeactivatePackage(TemplateFunctions);