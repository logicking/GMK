//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------
// Elf Bot
//-----------------------------------------------------------------------------

exec("art/shapes/actors/elf/elf.cs");


datablock SFXDescription(AudioScream3d)
{
   volume   = 1.0;
   isLooping = false;

   is3D = true;
   ReferenceDistance = 40.0;
   MaxDistance = 80.0;
   channel = $SimAudioType;
};

datablock SFXProfile(ElfSoundDeath)
{
   fileName = "art/sound/elf_death";
   description = AudioScream3d;
   preload = true;
};


datablock SFXProfile(ElfSoundPain01)
{
   fileName = "art/sound/elf_pain_01";
   description = AudioScream3d;
   preload = true;
};



datablock PlayerData(ElfBotData : DefaultPlayerData)
{
   renderFirstPerson = false;
   emap = true;
   
   jumpTowardsNormal = false;
   airControl = 0;
   
   maxForwardSpeed = 12;
   maxBackwardSpeed = 7; 
   maxSideSpeed = 7;
   jumpForce = 30.0 * 90;

   shapeFile = "art/shapes/actors/Elf/Elf.dts";
   
   category = "AI";
   className = "AiBotData";
   
   ragdoll = "ElfRagDoll";
   
   deathSnd = ElfSoundDeath;
   painSnd[0] = ElfSoundPain01;
   painSndCount = 1;
   
   weapon = RocketLauncherImage;
   ammo = RocketLauncherAmmo;
   ammoCount = 3000;
   shootingDelay = 5000;
   shootingDelayVariant = 2000;
   
   chaseFarDist = 30;
   chaseCloseDist = 24;
   attackFov = 45;
   attackDist = 55;
   
   strafeMinDist = 8;
   strafeMaxDist = 20;
   strafeChangeDirTime = 1200;
};



datablock PlayerData(ElfBotData2 : ElfBotData)
{
   weapon = GreenBlasterGunImage;
   ammo = CrossbowAmmo;
   ammoCount = 3000;
   shootingDelay = 1000;
   shootingDelayVariant = 1000;
};


//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
activatePackage(TemplateFunctions);
inheritTemplate("ElfBot", "AiBot");
registerTemplate("ElfBot", "AI", "AiBotData::create(ElfBotData); ");
setTemplateField("ElfBot", "health", "150");
setTemplateField("ElfBot", "item", "HealthPatch", "", "Misc", "An item that bot spawns on his death.");
deactivatePackage(TemplateFunctions);