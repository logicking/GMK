//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------
// Boom Bot
//-----------------------------------------------------------------------------

datablock SFXDescription(AudioScream3d)
{
   volume   = 1.0;
   isLooping = false;

   is3D = true;
   ReferenceDistance = 40.0;
   MaxDistance = 80.0;
   channel = $SimAudioType;
};

datablock SFXProfile(BoomBotSoundDeath)
{
   fileName = "art/sound/spaceOrc_death";
   description = AudioScream3d;
   preload = true;
};


datablock SFXProfile(BoomBotSoundPain01)
{
   fileName = "art/sound/spaceOrc_pain_01";
   description = AudioScream3d;
   preload = true;
};

datablock SFXProfile(BoomBotSoundPain02)
{
   fileName = "art/sound/spaceOrc_pain_02";
   description = AudioScream3d;
   preload = true;
};



datablock PlayerData(AiBoomBotData : BoomBotData)
{
   renderFirstPerson = false;
   emap = true;
   
   jumpTowardsNormal = false;
   airControl = 0;
   
   maxForwardSpeed = 7;
   maxBackwardSpeed = 5; 
   maxSideSpeed = 5;
   jumpForce = 30.0 * 90;

   shapeFile = "art/shapes/players/BoomBot/BoomBot.dts";
   
   category = "AI";
   className = "AiBotData";
   
   deathSnd = BoomBotSoundDeath;
   painSnd[0] = BoomBotSoundPain01;
   painSnd[1] = BoomBotSoundPain02;
   painSndCount = 2;
   
   ragdoll = "BoomBotRagDoll";
   
   weapon = RocketLauncherImage;
   ammo = RocketLauncherAmmo;
   ammoCount = 3000;
   shootingDelay = 2000;
   shootingDelayVariant = 2000;
   
   
   chaseFarDist = 20;
   chaseCloseDist = 14;
   attackFov = 45;
   attackDist = 60;
   
   strafeMinDist = 5;
   strafeMaxDist = 10;
   strafeChangeDirTime = 800;
   
   maxDamage = 50;//10000;
};

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
activatePackage(TemplateFunctions);
inheritTemplate("BoomBot", "AiBot");
registerTemplate("BoomBot", "AI", "AiBotData::create(AiBoomBotData); ");
setTemplateField("BoomBot", "health", "100");
setTemplateField("BoomBot", "item", "HealthPatch", "", "Misc", "An item that bot spawns on his death.");
deactivatePackage(TemplateFunctions);