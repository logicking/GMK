//-----------------------------------------------------------------------------
// Torque Game Engine 
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock SFXProfile(KeyTakeSound)
{
	filename = "art/sound/itemTake";
	description = AudioDefault3d;
	preload = true;
};

datablock ItemData(RedKeyItemData)
{
   // Basic Item properties
   shapeFile = "art/shapes/cards/Card_red.dts";
   
   mass = 0;
   friction = 0;
   elasticity = 0;
   pickUpName = "Red Key";
   
   usable = true;
   takeSound = KeyTakeSound;
   maxInventory = 1;
};

datablock ItemData(BlueKeyItemData)
{
   // Basic Item properties
   shapeFile = "art/shapes/cards/Card_blue.dts";
   
   mass = 0;
   friction = 0;
   elasticity = 0;
   pickUpName = "Blue Key";
   
   usable = true;
   takeSound = KeyTakeSound;
   maxInventory = 1;
};

datablock ItemData(GreenKeyItemData)
{
   // Basic Item properties
   shapeFile = "art/shapes/cards/Card_red.dts";
   
   mass = 0;
   friction = 0;
   elasticity = 0;
   pickUpName = "Green Key";
   
   usable = true;
   takeSound = KeyTakeSound;
   maxInventory = 1;
};


//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);
inheritTemplate("RedKey", "AbstractInventoryItem");
registerTemplate("RedKey", "Items", "InventoryItemData::create(RedKeyItemData);");

inheritTemplate("BlueKey", "AbstractInventoryItem");
registerTemplate("BlueKey", "Items", "InventoryItemData::create(BlueKeyItemData);");

inheritTemplate("GreenKey", "AbstractInventoryItem");
registerTemplate("GreenKey", "Items", "InventoryItemData::create(GreenKeyItemData);");

DeactivatePackage(TemplateFunctions);