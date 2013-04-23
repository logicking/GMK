//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Counter  - a helper object, that counts incoming signal,
// and generates event when certain bounds are reached
//-----------------------------------------------------------------------------
datablock MissionMarkerData(CounterData)
{
   category = "Misc";
   shapeFile = "core/art/shapes/octahedron.dts";
};
   
function Counter::create()
{
	%obj = new MissionMarker()
	{
		dataBlock = CounterData;
		class = "Counter";
		value = 0;
		minValue = -1;
		maxValue = 1;
	};
	return %obj;
}

function Counter::onAdd(%this)
{
}


function Counter::checkBounds(%this)
{
	%this.signal("onValueChanged", %this.value);

	if(%this.value <= %this.minValue)
	{
		%this.signal("onLowerBound", %this.value);
		%this.signal("onBound", %this.value);
	} 
	else if(%this.value >= %this.maxValue)
	{
		%this.signal("onUpperBound", %this.value);
		%this.signal("onBound", %this.value);
	}
}

function Counter::inc(%this)
{
	%this.value = %this.value + 1;
	%this.checkBounds();
}

function Counter::dec(%this)
{
	%this.value = %this.value - 1;
	%this.checkBounds();
}

function Counter::set(%this, %value)
{
	%this.value = %value;
	%this.checkBounds();
}

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------

activatePackage(TemplateFunctions);
registerTemplate("Counter", "Misc", "  Counter::create(); ");
setTemplateField("Counter", "value", "0");
setTemplateField("Counter", "minValue", "-1");
setTemplateField("Counter", "maxValue", "1");
// events
setTemplateEvent("Counter", "onValueChanged",  "", "%arg0 is value", 1);
setTemplateEvent("Counter", "onLowerBound",  "", "%arg0 is value", 1);
setTemplateEvent("Counter", "onUpperBound",  "", "%arg0 is value", 1);
setTemplateEvent("Counter", "onBound", "", "%arg0 is value", 1);
// actions
setTemplateAction("Counter", "inc", "");
setTemplateAction("Counter", "dec", "");
setTemplateAction("Counter", "set", " %arg0 - new value ");
deactivatePackage(TemplateFunctions);
