//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// InventoryItem  - items that can be used by characters with 
// inventory
//-----------------------------------------------------------------------------

function InventoryItemData::create(%data)
{
	%obj = new Item() {
		class = "InventoryItem";
		dataBlock = %data;
		rotate = %data.rotate;
		static = %data.static; 
		takeOnUse = %data.takeOnUse;
	};
	return %obj;
}

function InventoryItem::take(%this, %taker, %amount)
{
	if(!%this.isEnabled()) return false;
	%this.signal("onTake", %taker);

	%data = %this.getDataBlock();
	if(isObject(%data.takeSound))
	{
		%pos = %this.getPosition();
		sfxPlayOnce(%data.takeSound, getWord(%pos, 0), getWord(%pos, 1), getWord(%pos, 2));
	}
	
	//add item to inventory
	%taker.getDatablock().maxInv[%data.getName()] = 999; // a little hack to avoid useless original datablock inventory description in PlayerData
	%res = %taker.pickup(%this, %amount);
	  
	return true;
}

function InventoryItem::use(%this, %user)
{
	if(!Usable::use(%this, %user)) return false;
	%this.take(%user);
	return true;
}


ActivatePackage(TemplateFunctions);	// opening package with template functions
inheritTemplate("AbstractInventoryItem", "AbstractUsable");
registerTemplate("AbstractInventoryItem", "Abstracts", "");	//register AbstractDoor template
setTemplateEvent("AbstractInventoryItem", "onTake", "echo(\"item taked by \", %arg0);", "%this - item, %arg0 - taker", 1);
DeactivatePackage(TemplateFunctions); // close package with template functions