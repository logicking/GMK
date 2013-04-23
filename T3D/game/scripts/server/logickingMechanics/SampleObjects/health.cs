//-----------------------------------------------------------------------------
// Torque Game Engine 
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Health Patchs cannot be picked up and are not meant to be added to 
// inventory.  Health is applied automatically when an objects collides
// with a patch.
//-----------------------------------------------------------------------------

datablock SFXProfile(HealthTakeSound)
{
	filename = "art/sound/itemTake";
	description = AudioDefault3d;
	preload = true;
};


datablock ItemData(HealthPatch)
{
   // Mission editor category, this datablock will show up in the
   // specified category under the "shapes" root category.
   category = "Items";

   // Basic Item properties
   shapeFile = "art/shapes/health_pack/health_pack.dts";
   mass = 0;
   friction = 0;
   elasticity = 0;
   rotate = true;
   pickUpName = "Health";
   
   // sound will be played when item is taken
   takeSound = HealthTakeSound;
   destroyAfterTake = true; // Item will be destroyed immidiately after take
   repairAmount = 20;
   maxInventory = 0; // No pickup or throw
   
};

function HealthPatch::onCollision(%this, %obj, %col)
{
	// Apply health to colliding object if it needs it.
	// Works for all shapebase objects.
	if (%col.getDamageLevel() != 0 && %col.getState() !$= "Dead" ) 
	{
		if(!InventoryItem::take(%obj, %col)) return;
		%col.applyRepair(%this.repairAmount);
		
		%obj.startFade(0, 0, true);
		%obj.setHidden(true);
	}
}

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);
inheritTemplate("HealthPatch", "AbstractInventoryItem");
registerTemplate("HealthPatch", "Items", "InventoryItemData::create(HealthPatch);");
DeactivatePackage(TemplateFunctions);