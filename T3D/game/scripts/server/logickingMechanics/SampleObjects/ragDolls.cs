//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------
// Sample rag dolls
//-----------------------------------------------------------------------------

datablock SFXProfile(bodyFall0)
{
	filename = "art/sound/physics/bodyFall";
	description = AudioDefault3d;
	preload = true;
};

if (getPhysicsLib() $= "Bullet")
{
	exec("./ragDollsBullet.cs");
}
else if (getPhysicsLib() $= "PhysX")
{
	exec("./ragDollsPhysX.cs");
}