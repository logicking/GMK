//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-------------------------------------------------------------------------------
datablock SFXProfile(bigDoorOpenSound)
{
	filename = "art/sound/GarageDoorOpens";
	description = AudioDefault3d;
	preload = true;
};

datablock StaticShapeData(BigDoor){
 	category = "Doors";
	class = "DoorData";
	shapeFile = "art/shapes/Doors/Big/Big_door.dts";
	position = "0 0 0";
	Scale="1 1 1";
	emap = true;
	receiveSunLight = "1";
	
	openAnimation = "Sequence01";
	closeAnimation = "Sequence01";
	closeAnimationReverse = true;
	
	openSnd = bigDoorOpenSound;
	closeSnd = bigDoorOpenSound;
 };

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);
inheritTemplate("GarageDoor", "AbstractDoor");
registerTemplate("GarageDoor", "Doors", "DoorData::create(BigDoor);");
DeactivatePackage(TemplateFunctions);
 
 
//-----------------------------------------------------------------------------
datablock SFXProfile(doorOpenSound)
{
	filename = "art/sound/doorSmallOpen";
	description = AudioClose3d;
	preload = true;
};

datablock SFXProfile(doorCloseSound)
{
	filename = "art/sound/doorSmallClose";
	description = AudioClose3d;
	preload = true;
};

datablock StaticShapeData(SlidingDoor){
 	category = "Doors";
	class = "DoorData";
	shapeFile = "art/shapes/Doors/Small/Door_small.dts";
	position = "0 0 0";
	Scale="1 1 1";
	emap = true;
	receiveSunLight = "1";
	
	openAnimation = "Open";
	closeAnimation = "Open";
	closeAnimationReverse = true;
	
	openSnd = doorOpenSound;
	closeSnd = doorCloseSound;
 };
 
 
//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);
inheritTemplate("SlidingDoor", "AbstractDoor");
registerTemplate("SlidingDoor", "Doors", "DoorData::create(SlidingDoor);");
DeactivatePackage(TemplateFunctions);