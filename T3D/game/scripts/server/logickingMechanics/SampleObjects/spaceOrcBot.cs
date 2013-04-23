//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------
// SpaceOrc Bot
//-----------------------------------------------------------------------------

exec("art/shapes/actors/SpaceOrc/SpaceOrc.cs");


datablock SFXDescription(AudioScream3d)
{
   volume   = 1.0;
   isLooping = false;

   is3D = true;
   ReferenceDistance = 40.0;
   MaxDistance = 80.0;
   channel = $SimAudioType;
};

datablock SFXProfile(SpaceOrcSoundDeath)
{
   fileName = "art/sound/spaceOrc_death";
   description = AudioScream3d;
   preload = true;
};


datablock SFXProfile(SpaceOrcSoundPain01)
{
   fileName = "art/sound/spaceOrc_pain_01";
   description = AudioScream3d;
   preload = true;
};

datablock SFXProfile(SpaceOrcSoundPain02)
{
   fileName = "art/sound/spaceOrc_pain_02";
   description = AudioScream3d;
   preload = true;
};



datablock PlayerData(SpaceOrcBotData : DefaultPlayerData)
{
   renderFirstPerson = false;
   emap = true;
   
   jumpTowardsNormal = false;
   airControl = 0;
   
   maxForwardSpeed = 7;
   maxBackwardSpeed = 5; 
   maxSideSpeed = 5;
   jumpForce = 30.0 * 90;

   shapeFile = "art/shapes/actors/SpaceOrc/SpaceOrc.dts";
   
   category = "AI";
   className = "AiBotData";
   
   deathSnd = SpaceOrcSoundDeath;
   painSnd[0] = SpaceOrcSoundPain01;
   painSnd[1] = SpaceOrcSoundPain02;
   painSndCount = 2;
   
   ragdoll = "SpaceOrcRagDoll";
   
   weapon = BlasterGunImage;
   ammo = BlasterAmmo;
   ammoCount = 3000;
   //shootingDelay = 2000;
   
   shootingDelay = 500;
   shootingDelayVariant = 400;
   
   
   chaseFarDist = 20;
   chaseCloseDist = 14;
   attackFov = 45;
   attackDist = 50;
   
   strafeMinDist = 5;
   strafeMaxDist = 10;
   strafeChangeDirTime = 800;
   
   maxDamage = 50;//10000;
   
   maxInv[BlasterAmmo] = 5000;
};

datablock PlayerData(SpaceOrcBotData2 : SpaceOrcBotData)
{
   weapon = RocketLauncherImage;
   ammo = RocketLauncherAmmo;
   ammoCount = 3000;
   shootingDelay = 2000;
   shootingDelayVariant = 2000;
};

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
activatePackage(TemplateFunctions);
inheritTemplate("SpaceOrcBot", "AiBot");
registerTemplate("SpaceOrcBot", "AI", "AiBotData::create(SpaceOrcBotData); ");
setTemplateField("SpaceOrcBot", "health", "100");
setTemplateField("SpaceOrcBot", "item", "HealthPatch", "", "Misc", "An item that bot spawns on his death.");
deactivatePackage(TemplateFunctions);