//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-------------------------------------------------------------------------------
// Alarm light with siren object.
//-------------------------------------------------------------------------------

datablock SFXProfile(alarmSirenSound)
{
	filename = "art/sound/alarmSiren";
	description = AudioDefaultLoop3d;
	preload = true;
};


   
datablock StaticShapeData(SirenData)
{
   category = "Misc";
   shapeFile = "art/shapes/Siren/Siren.dts";
   
};

function SirenData::create()
{
	%obj = new StaticShape() {
		class = "Siren";
		dataBlock = SirenData;
	};
	return %obj;
}

function SirenData::onAdd(%this, %obj)
{
	if(%obj.isActive)
	{
		%obj.isActive = false;
		%obj.start();
	}
}

function SirenData::onRemove(%this, %obj)
{
	if(%obj.isActive)
	{
		%obj.stop();
	}
}


function Siren::start(%this)
{
	if(%this.isActive) return;
	
	%this.isActive = true;
	
	%this.playThread(0, "Action");
	%this.playAudio(0, alarmSirenSound);
	%this.light = new SpotLight() {
      range = "40";
      innerAngle = "60";
      outerAngle = "70";
      isEnabled = "1";
      color = "1 0 0.188235 1";
      brightness = "1";
      castShadows = "0";
      priority = "1";
      animate = "1";
      animationPeriod = "1";
      animationPhase = "1";
      flareScale = "1";
      attenuationRatio = "0 1 1";
      shadowType = "Spot";
      texSize = "512";
      overDarkFactor = "2000 1000 500 100";
      shadowDistance = "400";
      shadowSoftness = "0.15";
      numSplits = "1";
      logWeight = "0.91";
      fadeStartDistance = "0";
      lastSplitTerrainOnly = "0";
      splitFadeDistances = "10 20 30 40";
      representedInLightmap = "0";
      shadowDarkenColor = "0 0 0 -1";
      includeLightmappedGeometryInShadow = "0";
      position = "504.765 706.362 257.101";
      rotation = "1 0 0 8.73678";
      canSaveDynamicFields = "1";
      Enabled = "1";
   };
	%this.mountObject(%this.light, 0);
}

function Siren::stop(%this)
{
	if(!%this.isActive) return;
	
	%this.isActive = false;
	
	%this.stopAudio(0);
	%this.stopThread(0);

    if(isObject(%this.light))
    {
		%this.unmountObject(%this.light);
        %this.light.delete();
    }
	%this.light = "";
}

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);
registerTemplate("Siren", "Objects", "SirenData::create();");
setTemplateField("Siren", "isActive", "0");
// actions
setTemplateAction("Siren", "start", "");
setTemplateAction("Siren", "stop", "");
DeactivatePackage(TemplateFunctions);