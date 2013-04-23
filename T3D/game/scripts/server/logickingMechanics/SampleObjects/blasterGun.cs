//-----------------------------------------------------------------------------
// Torque Game Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------
// Blaster Gun and ammo
//-----------------------------------------------------------------------------

datablock SFXProfile(BlasterReloadSound)
{
filename = "art/sound/crossbow_reload";
description = AudioClose3d;
preload = true;
};

datablock SFXProfile(BlasterFireSound)
{
	filename = "art/sound/laser02";
	description = AudioDefault3d;
	preload = true;
};

datablock SFXProfile(GreenBlasterFireSound)
{
	filename = "art/sound/laser01";
	description = AudioDefault3d;
	preload = true;
};


datablock SFXProfile(BlasterFireEmptySound)
{
	filename = "art/sound/crossbow_firing_empty";
	description = AudioClose3d;
	preload = true;
};

datablock SFXProfile(LaserBeamExplosionSound)
{
	filename = "art/sound/laserHit01";
	description = AudioClose3d;
	preload = true;
};
// ----------------------------------------

datablock ParticleData(RedLaserParticle)
{
   textureName = "art/shapes/particles/spark_wet";
   dragCoefficient = 0.997067;
   windCoefficient = 1;
   gravityCoefficient = 1;
   inheritedVelFactor = 0.199609;
   lifetimeMS = 481;
   lifetimeVarianceMS = 350;
   spinSpeed = 0;
   spinRandomMin = 0;
   spinRandomMax = 0;
   useInvAlpha = 1;
   
   colors[0] = "1 0.4 0 1";
   colors[1] = "1 0.2 0 1";
   colors[2] = "1 0.1 0 0";
   colors[3] = "1 1 1 1";
   
   sizes[0] = 0.15;
   sizes[1] = 0.1;
   sizes[2] = 0.1;
   sizes[3] = 1;
   
   times[0] = 0;
   times[1] = 0.5;
   times[2] = 1;
   times[3] = 1;
};

datablock ParticleEmitterData(RedLaserEmitter)
{
  
   ejectionPeriodMS = 3;
   periodVarianceMS = 0;
   
   ejectionVelocity = 5;
   velocityVariance = 1;
   ejectionOffset = 0;  
  
   thetaMin = 0;
   thetaMax = 130;
   
   lifetimeMS = 70;
   lifetimeVarianceMS = 0;
   
   blendStyle = "ADDITIVE";
   srcBlendFactor = "SRC_ALPHA";
   dstBlendFactor = "ONE";
   
   particles = "RedLaserParticle";
   orientParticles = "1";
};

datablock ParticleEmitterNodeData(RedLaserNode)
{
   timeMultiple = 1;
};

// ----------------------------------------

datablock ParticleData(GreenLaserParticle)
{
   textureName = "art/shapes/particles/spark_wet";
   dragCoefficient = 0.997067;
   windCoefficient = 1;
   gravityCoefficient = 1;
   inheritedVelFactor = 0.199609;
   lifetimeMS = 481;
   lifetimeVarianceMS = 350;
   spinSpeed = 0;
   spinRandomMin = 0;
   spinRandomMax = 0;
   useInvAlpha = 1;
   
   colors[0] = "0.2 1 0 1";
   colors[1] = "0.1 1 0 1";
   colors[2] = "0 1 0 0";
   colors[3] = "1 1 1 1";
   
   sizes[0] = 0.12;
   sizes[1] = 0.08;
   sizes[2] = 0.08;
   sizes[3] = 1;
   
   times[0] = 0;
   times[1] = 0.5;
   times[2] = 1;
   times[3] = 1;
};

datablock ParticleEmitterData(GreenLaserEmitter)
{
  
   ejectionPeriodMS = 3;
   periodVarianceMS = 0;
   
   ejectionVelocity = 5;
   velocityVariance = 1;
   ejectionOffset = 0;  
  
   thetaMin = 0;
   thetaMax = 130;
   
   lifetimeMS = 70;
   lifetimeVarianceMS = 0;
   
   blendStyle = "ADDITIVE";
   srcBlendFactor = "SRC_ALPHA";
   dstBlendFactor = "ONE";
   
   particles = "GreenLaserParticle";
   orientParticles = "1";
};

datablock ParticleEmitterNodeData(GreenLaserNode)
{
   timeMultiple = 1;
};

// ----------------------------------------

datablock ExplosionData(LaserBeamExplosion)
{
   soundProfile = LaserBeamExplosionSound;
   lifeTimeMS = 120;

	// Point emission
   emitter[0] = RedLaserEmitter;

   // Dynamic light
   lightStartRadius = 4;
   lightEndRadius = 0;
   lightStartColor = "1 0 0";
   lightEndColor = "1 0 0";
};

/*
datablock ExplosionData(LaserBeamExplosion)
{
   soundProfile = LaserBeamExplosionSound;
   lifeTimeMS = 120;

	// Point emission
   emitter[0] = RedLaserEmitter;

   // Dynamic light
   lightStartRadius = 3;
   lightEndRadius = 3;
   lightStartColor = "1 0.3 0.3";
   lightEndColor = "0 0 0";
};
*/

datablock ExplosionData(GreenLaserBeamExplosion : LaserBeamExplosion)
{
   soundProfile = LaserBeamExplosionSound;
   emitter[0] = GreenLaserEmitter;
	// Dynamic light
   lightStartColor = "0 1 0";
   lightEndColor = "0 0 0";
};

//-----------------------------------------------------------------------------
// Projectile Object
/*
datablock DecalData(laserBeamHole00){
   sizeX       = 0.1;   
   sizeY       = 0.1;   
   textureName = "art/shapes/lasers/laser_hit_01";
};

datablock DecalData(laserBeamHole01){
   sizeX       = 0.1;   
   sizeY       = 0.1;   
   textureName = "art/shapes/lasers/laser_hit_02";
};

datablock DecalData(laserBeamHole02){
   sizeX       = 0.15;   
   sizeY       = 0.15;   
   textureName = "art/shapes/lasers/laser_hit_01";
};

datablock DecalData(laserBeamHole03){
   sizeX       = 0.13;   
   sizeY       = 0.13;   
   textureName = "art/shapes/lasers/laser_hit_02";
};
*/


datablock ProjectileData(LaserBeamProjectile)
{
	projectileShapeName = "art/shapes/lasers/laser_red/red_laser.dts";

	directDamage        = 13;
	areaImpulse         = 2000;

	explosion           = LaserBeamExplosion;
	//particleEmitter     = RocketEmitter;

	muzzleVelocity      = 70;
	velInheritFactor    = 0.1;

	armingDelay         = 0;
	lifetime            = 8000;
	fadeDelay           = 1500;
	bounceElasticity    = 0;
	bounceFriction      = 0;
	isBallistic         = false;
	gravityMod = 0.10;

	hasLight    = true;
	lightRadius = 6.0;
	lightColor  = "1.0 0.3 0.3";
	/*
	decals[0] = laserBeamHole00;
	decals[1] = laserBeamHole01;
	decals[2] = laserBeamHole02;
	decals[3] = laserBeamHole03;
*/
};

datablock ProjectileData(GreenLaserBeamProjectile : LaserBeamProjectile)
{
	projectileShapeName = "art/shapes/lasers/laser_green/green_laser.dts";
	explosion           = GreenLaserBeamExplosion;
	
	directDamage        = 33;
	muzzleVelocity      = 110;
	velInheritFactor    = 0.1;

	lightRadius = 5.0;
	lightColor  = "0.0 1.0 0";
	
	superClass = "LaserBeamProjectile";
};

function LaserBeamProjectile::onCollision(%this,%obj,%col,%fade,%pos,%normal)
{
	echo("OnCol1", %pos, %normal);
   if (%col.getType() & $TypeMasks::ShapeBaseObjectType)
   {
      %col.damage(%obj,%pos,%this.directDamage, "LaserBeam");
	  %force = VectorScale(%normal,400);
	  %force = VectorSub("0 0 0",%force);
	  echo("OnCol2", %pos, %force);
	  %col.applyImpulse(%pos,%force);
   }
}
//-----------------------------------------------------------------------------
// Ammo Item
datablock ItemData(BlasterAmmo)
{
   // Mission editor category
   category = "Ammo";

   // Add the Ammo namespace as a parent.  The ammo namespace provides
   // common ammo related functions and hooks into the inventory system.
   className = "Ammo";

   // Basic Item properties
   shapeFile = "art/shapes/weapons/SwarmGun/swarmgun.dts";
   mass = 1;
   elasticity = 0.2;
   friction = 0.6;

   // Dynamic properties defined by the scripts
   pickUpName = "blaster ammo";
   maxInventory = 50;
};

datablock ItemData(CrossbowAmmo : BlasterAmmo)
{
	pickUpName = "another blaster ammo";
};

datablock ItemData(BlasterGun)
{
	category = "Weapon";
	className = "Weapon";

	// Basic Item properties
	shapeFile = "art/shapes/weapons/SwarmGun/swarmgun.dts";
	mass = 1;
	elasticity = 0.2;
	friction = 0.6;
	emap = true;

	// Dynamic properties defined by the scripts
	pickUpName = "a blaster gun";
	image = BlasterGunImage;
};


//--------------------------------------------------------------------------
// Rocket Launcher image which does all the work.  Images do not normally exist in
// the world, they can only be mounted on ShapeBase objects.

datablock ShapeBaseImageData(BlasterGunImage)
{
   // Basic Item properties
   shapeFile = "art/shapes/weapons/spaceRifle/gun.dts";
   emap = true;

   // Specify mount point & offset for 3rd person, and eye offset
   // for first person rendering.
   mountPoint = 0;
   firstPerson = false;
   offset = "0 0.25 0";
   eyeOffset = "0.45 0.55 -0.5";
   
   // The model may be backwards
   // rotation = "0.0 0.0 1.0 180.0";
   // eyeRotation = "0.0 0.0 1.0 180.0";

   // When firing from a point offset from the eye, muzzle correction
   // will adjust the muzzle vector to point to the eye LOS point.
   // Since this weapon doesn't actually fire from the muzzle point,
   // we need to turn this off.
   correctMuzzleVector = true;

   // Add the WeaponImage namespace as a parent, WeaponImage namespace
   // provides some hooks into the inventory system.
   className = "WeaponImage";

   // Projectile && Ammo.
   item = BlasterGun;
   ammo = BlasterAmmo;
   projectile = LaserBeamProjectile;
   projectileType = Projectile;
   casing = RocketLauncherShell;
   
   shellExitDir        = "1.0 0.3 1.0";
   shellExitOffset     = "0.15 -0.56 -0.1";
   shellExitVariance   = 15.0;
   shellVelocity       = 3.0;

   // Images have a state system which controls how the animations
   // are run, which sounds are played, script callbacks, etc. This
   // state system is downloaded to the client so that clients can
   // predict state changes and animate accordingly.  The following
   // system supports basic ready->fire->reload transitions as
   // well as a no-ammo->dryfire idle state.

   // Initial start up state
   stateName[0]                     = "Preactivate";
   stateTransitionOnLoaded[0]       = "Activate";
   stateTransitionOnNoAmmo[0]       = "NoAmmo";

   // Activating the gun.  Called when the weapon is first
   // mounted and there is ammo.
   stateName[1]                     = "Activate";
   stateTransitionOnTimeout[1]      = "Ready";
   stateTimeoutValue[1]             = 0.5;
   stateSequence[1]                 = "Activate";
   stateScript[1]                   = "onActivate";

   // Ready to fire, just waiting for the trigger
   stateName[2]                     = "Ready";
   stateTransitionOnNoAmmo[2]       = "NoAmmo";
   stateTransitionOnTriggerDown[2]  = "Fire";

   // Fire the weapon. Calls the fire script which does
   // the actual work.
   stateName[3]                     = "Fire";
   stateTransitionOnTimeout[3]      = "Reload";
   stateTimeoutValue[3]             = 0;
   stateFire[3]                     = true;
   stateRecoil[3]                   = LightRecoil;
   stateAllowImageChange[3]         = false;
   stateSequence[3]                 = "Fire";
   stateScript[3]                   = "onFire";
   //stateEmitter[3]                  = RocketLauncherFireEmitter;
   //stateEmitterTime[3]              = 0.3;
   stateSoundOnFire                    = BlasterFireSound;

   // Play the relead animation, and transition into
   stateName[4]                     = "Reload";
   stateTransitionOnNoAmmo[4]       = "NoAmmo";
   stateTransitionOnTimeout[4]      = "Ready";
   stateTimeoutValue[4]             = 0.4;
   stateAllowImageChange[4]         = false;
   stateSequence[4]                 = "Reload";
   stateEjectShell[4]               = true;
   stateSound[4]                    = RocketReloadSound;

   // No ammo in the weapon, just idle until something
   // shows up. Play the dry fire sound if the trigger is
   // pulled.
   stateName[5]                     = "NoAmmo";
   stateTransitionOnAmmo[5]         = "Reload";
   stateSequence[5]                 = "NoAmmo";
   stateTransitionOnTriggerDown[5]  = "DryFire";

   // No ammo dry fire
   stateName[6]                     = "DryFire";
   stateTimeoutValue[6]             = 1.0;
   stateTransitionOnTimeout[6]      = "NoAmmo";
   stateScript[6]                   = "onDryFire";
};

datablock ShapeBaseImageData(GreenBlasterGunImage : BlasterGunImage) 
{
	//shapeFile = "art/shapes/weapons/SwarmGun/swarmgun.dts";
	projectile = GreenLaserBeamProjectile;
	stateSoundOnFire = GreenBlasterFireSound;
	
	superClass = "BlasterGunImage";
};

	
//-----------------------------------------------------------------------------

function BlasterGunImage::onFire(%this, %obj, %slot)
{
   %projectile = %this.projectile;

   // Determine initial projectile velocity based on the
   // gun's muzzle point and the object's current velocity
   %muzzleVector = %obj.getMuzzleVector(%slot);
   %objectVelocity = %obj.getVelocity();
   %muzzleVelocity = VectorAdd(
      VectorScale(%muzzleVector, %projectile.muzzleVelocity),
      VectorScale(%objectVelocity, %projectile.velInheritFactor));

   // Create the projectile object
   %p = new (%this.projectileType)() {
      dataBlock        = %projectile;
      initialVelocity  = %muzzleVelocity;
      initialPosition  = %obj.getMuzzlePoint(%slot);
      sourceObject     = %obj;
      sourceSlot       = %slot;
      client           = %obj.client;
   };
  
   MissionCleanup.add(%p);
   
   
   %pos = %obj.getPosition();
   sfxPlayOnce(%this.stateSoundOnFire, getWord(%pos, 0), getWord(%pos, 1), getWord(%pos, 2));
   
   
 
   return %p;
}

function GreenBlasterGunImage::onFire(%this, %obj, %slot)
{
	return BlasterGunImage::onFire(%this, %obj, %slot);
}


function BlasterGunImage::onDryFire(%this, %obj, %slot)
{
   error("No ammo!!!");
}