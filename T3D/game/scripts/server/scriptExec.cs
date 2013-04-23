//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

// Load up all scripts.  This function is called when
// a server is constructed.
exec("./camera.cs");
exec("./triggers.cs");
exec("./inventory.cs");
exec("./shapeBase.cs");
exec("./item.cs");
exec("./health.cs");
exec("./projectile.cs");
exec("./radiusDamage.cs");
exec("./teleporter.cs");

// Load our supporting weapon script, it contains methods used by all weapons.
exec("./weapon.cs");

// Load our weapon scripts
// We only need weapon scripts for those weapons that work differently from the
// "generic" methods defined in weapon.cs
exec("./rocketLauncher.cs");
exec("./soldierGun.cs");
exec("./grenadeLauncher.cs");
exec("./proximityMine.cs");

// Load our default player script
exec("./player.cs");

// Load our player scripts
exec("./aiPlayer.cs");

exec("./vehicle.cs");
exec("./vehicleWheeled.cs");
exec("./cheetah.cs");

// Load turret support scripts
exec("./turret.cs");

// Load our gametypes
exec("./gameCore.cs"); // This is the 'core' of the gametype functionality.
exec("./gameDM.cs"); // Overrides GameCore with DeathMatch functionality.
//.logicking >>
exec("./logickingMechanics/logickingMechanics.cs");
//.logicking <<