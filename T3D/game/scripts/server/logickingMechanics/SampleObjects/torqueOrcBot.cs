//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------
// TorqueOrc Bot
//-----------------------------------------------------------------------------

exec("art/shapes/players/TorqueOrc/TorqueOrc.cs");


datablock SFXDescription(AudioScream3d)
{
   volume   = 1.0;
   isLooping = false;

   is3D = true;
   ReferenceDistance = 40.0;
   MaxDistance = 80.0;
   channel = $SimAudioType;
};

datablock SFXProfile(TorqueOrcSoundDeath)
{
   fileName = "art/sound/spaceOrc_death";
   description = AudioScream3d;
   preload = true;
};


datablock SFXProfile(TorqueOrcSoundPain01)
{
   fileName = "art/sound/spaceOrc_pain_01";
   description = AudioScream3d;
   preload = true;
};

datablock SFXProfile(TorqueOrcSoundPain02)
{
   fileName = "art/sound/spaceOrc_pain_02";
   description = AudioScream3d;
   preload = true;
};



datablock PlayerData(TorqueOrcBotData : DefaultPlayerData)
{
   renderFirstPerson = false;
   emap = true;
   
   jumpTowardsNormal = false;
   airControl = 0;
   
   maxForwardSpeed = 7;
   maxBackwardSpeed = 5; 
   maxSideSpeed = 5;
   jumpForce = 30.0 * 90;

   shapeFile = "art/shapes/players/TorqueOrc/TorqueOrc.dts";
   
   category = "AI";
   className = "AiBotData";
   
   deathSnd = TorqueOrcSoundDeath;
   //painSnd[0] = TorqueOrcSoundPain01;
   //painSnd[1] = TorqueOrcSoundPain02;
   //painSndCount = 2;
   
   ragdoll = "TorqueOrcRagDoll";
   
   weapon = GreenBlasterGunImage;
   ammo = CrossbowAmmo;
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
   
   maxDamage = 10000;
};

datablock PlayerData(TorqueOrcBotData2 : TorqueOrcBotData)
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
inheritTemplate("TorqueOrcBot", "AiBot");
registerTemplate("TorqueOrcBot", "AI", "AiBotData::create(TorqueOrcBotData); ");
setTemplateField("TorqueOrcBot", "health", "100");
setTemplateField("TorqueOrcBot", "item", "HealthPatch", "", "Misc", "An item that bot spawns on his death.");
deactivatePackage(TemplateFunctions);