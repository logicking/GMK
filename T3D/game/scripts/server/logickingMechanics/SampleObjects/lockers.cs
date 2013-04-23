//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Garage locker
datablock StaticShapeData(GarageLocker)
{
	class = "LockerData";
    shapeFile = "art/shapes/garage_locker/garage_locker.dts";
    
    position = "0 0 0";
	Scale="1 1 1";
	emap = true;
	receiveSunLight = "1";
	
	openAnimation = "door_opening";
	closeAnimation = "door_close";
	closeAnimationReverse = false;
	
	openSnd = garageLockerOpenSound;
	closeSnd = garageLockerCloseSound;
};

datablock SFXProfile(garageLockerOpenSound)
{
	filename = "art/sound/garageLockerOpen";
	description = AudioClose3d;
	preload = true;
};

datablock SFXProfile(garageLockerCloseSound)
{
	filename = "art/sound/garageLockerClose";
	description = AudioClose3d;
	preload = true;
};

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);
inheritTemplate("GarageLocker", "AbstractLocker");
registerTemplate("GarageLocker", "Objects", "LockerData::create(GarageLocker);");
DeactivatePackage(TemplateFunctions);