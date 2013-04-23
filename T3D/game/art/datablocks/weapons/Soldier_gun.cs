//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--------------------------------------------------------------------------
// Sounds
//--------------------------------------------------------------------------
datablock SFXDescription(BulletFireDesc : AudioEffect )
{
   isLooping         = false;
   is3D              = true;
   ReferenceDistance = 10.0;
   MaxDistance       = 60.0;
};
datablock SFXDescription(BulletImpactDesc : AudioEffect )
{
   isLooping         = false;
   is3D              = true;
   ReferenceDistance = 10.0;
   MaxDistance       = 30.0;
   volume = 0.4;
   pitch = 1.4;
};
datablock SFXProfile(BulletFireSound)
{
   filename = "art/sound/weapons/shot";
   description = BulletFireDesc;
   preload = true;
};

datablock SFXPlayList(GunFireSound)
{
   // Use a looped description so the list playback will loop.
   description = Audio2D;

   track[ 0 ] = BulletFireSound;
};

datablock SFXProfile(BulletImpactSound)
{
   filename = "art/sound/weapons/shot";
   description = BulletImpactDesc;
   preload = true;
};

// ----------------------------------------------------------------------------
// Particles
// ----------------------------------------------------------------------------
datablock ParticleData(GunFireSmoke)
{
   textureName          = "art/shapes/particles/smoke";
   dragCoefficient      = 0;
   gravityCoefficient   = -0.1;
   windCoefficient      = 0;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 500;
   lifetimeVarianceMS   = 200;
   spinRandomMin = -180.0;
   spinRandomMax =  180.0;
   useInvAlpha   = true;

   colors[0]     = "0.8 0.8 0.8 0.7";
   colors[1]     = "0.87 0.87 0.87 0.35";
   colors[2]     = "0.9 0.84 0.8 0";

   sizes[0]      = 0.4;
   sizes[1]      = 1.2;
   sizes[2]      = 1.7;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(GunFireSmokeEmitter)
{
   ejectionPeriodMS = 20;
   periodVarianceMS = 10;
   ejectionVelocity = "4";
   velocityVariance = 1.0;
   thetaMin         = "0";
   thetaMax         = "0";
   lifetimeMS       = 250;
   particles = "GunFireSmoke";
   blendStyle = "NORMAL";
   softParticles = "0";
   originalName = "GunFireSmokeEmitter";
   alignParticles = "0";
   orientParticles = "0";
};

datablock ParticleData(BulletDirtDust)
{
   textureName          = "art/shapes/particles/impact";
   dragCoefficient      = 0;
   gravityCoefficient   = -0.1;
   windCoefficient      = 0;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 800;
   lifetimeVarianceMS   = 300;
   spinRandomMin = -180.0;
   spinRandomMax =  180.0;
   useInvAlpha   = true;

   colors[0]     = "0.5 0.4 0.3 0.7";
   colors[1]     = "0.7 0.62 0.54 0.35";
   colors[2]     = "0.9 0.85 0.8 0.0";

   sizes[0]      = 1.0;
   sizes[1]      = 8;
   sizes[2]      = 12.0;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(BulletDirtDustEmitter)
{
   ejectionPeriodMS = 20;
   periodVarianceMS = 10;
   ejectionVelocity = 3.0;
   velocityVariance = 1.0;
   thetaMin         = 0.0;
   thetaMax         = 180.0;
   lifetimeMS       = 250;
   particles = "BulletDirtDust";
};

//-----------------------------------------------------------------------------
// Explosion
//-----------------------------------------------------------------------------
datablock ExplosionData(BulletDirtExplosion)
{
   soundProfile = BulletImpactSound;
   lifeTimeMS = 65;

   // Volume particles
   particleEmitter = BulletDirtDustEmitter;
   particleDensity = 4;
   particleRadius = 0.3;

   // Point emission
   emitter[0] = BulletDirtSprayEmitter;
   emitter[1] = BulletDirtSprayEmitter;
   emitter[2] = BulletDirtRocksEmitter;
};

//--------------------------------------------------------------------------
// Shell ejected during reload.
//-----------------------------------------------------------------------------
datablock DebrisData(BulletShell)
{
   shapeFile = "art/shapes/weapons/RifleShell/RifleShell.DAE";
   lifetime = 6.0;
   minSpinSpeed = 300.0;
   maxSpinSpeed = 400.0;
   elasticity = 0.65;
   friction = 0.05;
   numBounces = 5;
   staticOnMaxBounce = true;
   snapOnMaxBounce = false;
   ignoreWater = true;
   fade = true;
};

//-----------------------------------------------------------------------------
// Projectile Object
//-----------------------------------------------------------------------------
datablock LightDescription( BulletProjectileLightDesc )
{
   color  = "0.0 0.5 0.7";
   range = 3.0;
};

datablock ProjectileData( BulletProjectile )
{
   projectileShapeName = "";

   directDamage        = 1;
   radiusDamage        = 0;
   damageRadius        = 0.5;
   areaImpulse         = 0.5;
   impactForce         = 1;

   explosion           = BulletDirtExplosion;
   decal               = BulletHoleDecal;

   muzzleVelocity      = 120;
   velInheritFactor    = 1;

   armingDelay         = 0;
   lifetime            = 992;
   fadeDelay           = 1472;
   bounceElasticity    = 0;
   bounceFriction      = 0;
   isBallistic         = false;
   gravityMod          = 1;
};

function BulletProjectile::onCollision(%this,%obj,%col,%fade,%pos,%normal)
{
   // Apply impact force from the projectile.
   
   // Apply damage to the object all shape base objects
   if ( %col.getType() & $TypeMasks::GameBaseObjectType )
      %col.damage(%obj,%pos,%this.directDamage,"BulletProjectile");
}


//-----------------------------------------------------------------------------
// Ammo Item
//-----------------------------------------------------------------------------
datablock ItemData(BulletAmmo)
{
   // Mission editor category
   category = "Ammo";

   // Add the Ammo namespace as a parent.  The ammo namespace provides
   // common ammo related functions and hooks into the inventory system.
   className = "Ammo";

   // Basic Item properties
   shapeFile = "art/shapes/weapons/SwarmGun/rocket.dts";
   mass = 1;
   elasticity = 0.2;
   friction = 0.6;

   // Dynamic properties defined by the scripts
   pickUpName = "Bullet Ammo";
   maxInventory = 10000;
};

//--------------------------------------------------------------------------
// Weapon Item.  This is the item that exists in the world, i.e. when it's
// been dropped, thrown or is acting as re-spawnable item.  When the weapon
// is mounted onto a shape, the SoldierWeaponImage is used.
//-----------------------------------------------------------------------------
datablock ItemData(Rifle)
{
   // Mission editor category
   category = "Weapon";

   // Hook into Item Weapon class hierarchy. The weapon namespace
   // provides common weapon handling functions in addition to hooks
   // into the inventory system.
   className = "Weapon";

   // Basic Item properties
   shapeFile = "art/shapes/weapons/Soldier_gun/Soldier_Gun.DAE";
   mass = 1;
   elasticity = 0.2;
   friction = 0.6;
   emap = true;

   // Dynamic properties defined by the scripts
   pickUpName = "a soldier rifle";
   image = SoldierWeaponImage;
//   reticle = "crossHair";
};


datablock ShapeBaseImageData(SoldierWeaponImage)
{
   // Basic Item properties
   shapeFile = "art/shapes/weapons/Soldier_gun/Soldier_Gun.DAE";
   emap = true;

   // Specify mount point & offset for 3rd person, and eye offset
   // for first person rendering.
   mountPoint = 0;
   firstPerson = false;
   //offset = "0 0.25 0";
   //eyeOffset = "0.45 0.55 -0.5";

   // The model may be backwards
   // rotation = "0.0 0.0 1.0 180.0";
   // eyeRotation = "0.0 0.0 1.0 180.0";

   // When firing from a point offset from the eye, muzzle correction
   // will adjust the muzzle vector to point to the eye LOS point.
   // Since this weapon doesn't actually fire from the muzzle point,
   // we need to turn this off.
   correctMuzzleVector = false;

   // Add the WeaponImage namespace as a parent, WeaponImage namespace
   // provides some hooks into the inventory system.
   class = "WeaponImage";
   className = "WeaponImage";

   // Projectiles and Ammo.
   item = Rifle;
   ammo = BulletAmmo;

   projectile = BulletProjectile;
   projectileType = Projectile;
   projectileSpread = "0.02";

   altProjectile = GrenadeLauncherProjectile;
   altProjectileSpread = "0.02";

   casing = BulletShell;
   shellExitDir        = "1.0 0.3 1.0";
   shellExitOffset     = "0.15 -0.56 -0.1";
   shellExitVariance   = 15.0;
   shellVelocity       = 3.0;

   // Weapon lights up while firing
   lightType = "WeaponFireLight";
   lightColor = "0.992126 0.968504 0.708661 1";
   lightRadius = "4";
   lightDuration = "100";
   lightBrightness = 2;

   // Shake camera while firing.
   shakeCamera = false;
   camShakeFreq = "0 0 0";
   camShakeAmp = "0 0 0";

   // Images have a state system which controls how the animations
   // are run, which sounds are played, script callbacks, etc. This
   // state system is downloaded to the client so that clients can
   // predict state changes and animate accordingly.  The following
   // system supports basic ready->fire->reload transitions as
   // well as a no-ammo->dryfire idle state.

   useRemainderDT = true;

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

   // Ready to fire, just waiting for the trigger
   stateName[2]                     = "Ready";
   stateTransitionOnNoAmmo[2]       = "NoAmmo";
   stateTransitionOnTriggerDown[2]  = "Fire";
   stateTransitionOnAltTriggerDown[2]  = "AltFire";

   // Fire the weapon. Calls the fire script which does
   // the actual work.
   stateName[3]                     = "Fire";
   stateTransitionOnTimeout[3]      = "Reload";
   stateTimeoutValue[3]             = 0.2;
   stateFire[3]                     = true;
   stateRecoil[3]                   = "";
   stateAllowImageChange[3]         = false;
   stateSequence[3]                 = "Fire";
   stateSequenceRandomFlash[3]      = true;        // use muzzle flash sequence
   stateScript[3]                   = "onFire";
   stateSound[3]                    = GunFireSound;
   stateEmitter[3]                  = GunFireSmokeEmitter;
   stateEmitterTime[3]              = 0.025;

   // Play the reload animation, and transition into
   stateName[4]                     = "Reload";
   stateTransitionOnNoAmmo[4]       = "NoAmmo";
   stateTransitionOnTimeout[4]      = "Ready";
   stateWaitForTimeout[4]           = "0";
   stateTimeoutValue[4]             = 0.0;
   stateAllowImageChange[4]         = false;
   stateSequence[4]                 = "Reload";
   stateEjectShell[4]               = true;

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

   // Alt-fire
   stateName[7]                     = "AltFire";
   stateTransitionOnTimeout[7]      = "Ready";
   stateTimeoutValue[7]             = 1.2;
   stateFire[7]                     = true;
   stateRecoil[7]                   = LightRecoil;
   stateAllowImageChange[7]         = false;
   stateSequence[7]                 = "Fire";
   stateScript[7]                   = "onAltFire";
   stateSound[7]                    = GrenadeLauncherFireSound;
};
