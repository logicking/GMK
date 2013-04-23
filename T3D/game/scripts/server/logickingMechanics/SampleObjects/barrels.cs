//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Wooden Barrel
datablock StaticShapeData(WoodenBarrel)
{
	category = "Breakables";
	class = "BreakableData";
    shapeFile = "art/shapes/barrel/barrel.dts";
	
	timeToBreak = 5000;
	timeToBreakVariance = 2000;
	timeToVanish = 6000;
	breakAnimation = "Sequence01";
	health = 10;
};

//-----------------------------------------------------------------------------
// SteelBarrel

datablock ParticleData(BarrelFire)
{
   canSaveDynamicFields = 1;
   Enabled = 1;
   dragCoefficient = 0;
   windCoefficient = 0.545455;
   gravityCoefficient = -0.272727;
   inheritedVelFactor = 0;
   constantAcceleration = -0.454545;
   lifetimeMS = 2750;
   lifetimeVarianceMS = 363;
   spinSpeed = 0;
   spinRandomMin = -63.6364;
   spinRandomMax = 45.4545;
   useInvAlpha = 0;
   animateTexture = 0;
   framesPerSec = 1;
   textureCoords[0] = "0 0";
   textureCoords[1] = "0 1";
   textureCoords[2] = "1 1";
   textureCoords[3] = "1 0";
   animTexTiling = "0 0";
   textureName = "art/shapes/particles/smoke";
   colors[0] = "1 0.4 0 0.5";
   colors[1] = "1 0.3 0 0";
   colors[2] = "1 0.3 0 0";
   colors[3] = "1 1 1 1";
   sizes[0] = 0.3;
   sizes[1] = 0.75;
   sizes[2] = 0.75;
   sizes[3] = 1;
   times[0] = 0;
   times[1] = 0.5;
   times[2] = 1;
   times[3] = 1;
};

datablock ParticleEmitterData(BarrelFireEmitter)
{
   canSaveDynamicFields = 1;
   Enabled = 1;
   ejectionPeriodMS = 10;
   periodVarianceMS = 0;
   ejectionVelocity = 0.25;
   velocityVariance = 0.1;
   ejectionOffset = 0.363636;
   thetaMin = 0;
   thetaMax = 90;
   phiReferenceVel = 0;
   phiVariance = 360;
   overrideAdvance = 1;
   orientParticles = 0;
   orientOnVelocity = 1;
   particles = "BarrelFire";
   lifetimeMS = 0;
   lifetimeVarianceMS = 0;
   useEmitterSizes = 0;
   useEmitterColors = 0;
   blendStyle = "ADDITIVE";
   srcBlendFactor = "SRC_ALPHA";
   dstBlendFactor = "ONE";
   sortParticles = 0;
   reverseOrder = 0;
};

datablock ParticleEmitterNodeData(BarrelFireNode)
{
   timeMultiple = 1;
};

// ----------------------------------------


datablock StaticShapeData(SteelBarrel)
{
	category = "Breakables";
	class = "BreakableData";
    shapeFile = "art/shapes/steel_barrel/steel_barrel.dts";
	
	timeToBreak = 5000;
	timeToBreakVariance = 2000;
	timeToVanish = 15000;
	preparatoryEffect = SteelBarrelBurn;
	breakEffect = SteelBarrelExplosion;

	breakAnimation = "X-plode_001";
	
	health = 60;
	healthBound = 50;
};

datablock SFXProfile(SteelBarrelBurnSound)
{
	filename = "art/sound/steel_barrel_burn";
	description = AudioClosest3d;
	preload = true;
};

datablock SFXProfile(SteelBarrelExplosionSound)
{
	filename = "art/sound/explosion_mono_01";
	description = AudioLoud3d;
	preload = true;
};

datablock ExplosionData(SteelBarrelBurnExpl)
{
   soundProfile = SteelBarrelBurnSound;
   lifeTimeMS = 8000;

   // Point emission
   emitter[0] = BarrelFireEmitter;

   // Dynamic light
   lightStartRadius = 4;
   lightEndRadius = 4;
   lightStartColor = "1 0.7 0";
   lightEndColor = "1 0.7 0";
};

datablock VisualEffectData(SteelBarrelBurn)
{
	explosion = "SteelBarrelBurnExpl";
   
   //Damage
   damageRadius = 1.5;
   damageForce = 1;
   damagePeriod = 300;
};


//-----------------------------------------------------------------------------

datablock ExplosionData(SteelBarrelExplosionExpl)
{
   soundProfile = SteelBarrelExplosionSound;
   
   lifeTimeMS = 200;

   // Volume particles
   particleEmitter = RocketExplosionFireEmitter;
   particleDensity = 10;
   particleRadius = 2;

   // Point emission
   emitter[0] = RocketExplosionSmokeEmitter;
   emitter[1] = RocketExplosionSparkEmitter;
   emitter[2] = RocketExplosionSpark2Emitter;

   // Sub explosion objects
   subExplosion[0] = RocketSubExplosion1;
   subExplosion[1] = RocketSubExplosion2;
   
   // Camera Shaking
   shakeCamera = true;
   camShakeFreq = "4.0 4.0 4.0";
   camShakeAmp = "24.0 24.0 24.0";
   camShakeDuration = 0.5;
   camShakeRadius = 20.0;

   // Dynamic light
   lightStartRadius = 20;
   lightEndRadius = 3;
   lightStartColor = "1 0.7 0";
   lightEndColor = "1 0.7 0";
};

datablock VisualEffectData(SteelBarrelExplosion)
{
   explosion = "SteelBarrelExplosionExpl";
   //Damage
   damageRadius = 6;
   damageForce = 70;
   impulseForce = 400;
};

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);
inheritTemplate("WoodenBarrel", "AbstractBreakable");
registerTemplate("WoodenBarrel", "Breakables", "BreakableData::create(\"WoodenBarrel\"); ");

inheritTemplate("SteelBarrel", "AbstractBreakable");
registerTemplate("SteelBarrel", "Breakables", "BreakableData::create(\"SteelBarrel\"); ");
DeactivatePackage(TemplateFunctions);