//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------
// Sample rigid bodies
//-----------------------------------------------------------------------------

datablock SFXProfile(boxFall0)
{
	filename = "art/sound/physics/boxFall0";
	description = AudioDefault3d;
	preload = true;
};

datablock SFXProfile(boxFall1)
{
	filename = "art/sound/physics/boxFall1";
	description = AudioDefault3d;
	preload = true;
};

datablock SFXProfile(boxFall2)
{
	filename = "art/sound/physics/boxFall2";
	description = AudioDefault3d;
	preload = true;
};

datablock RigidBodyData( PhysBox )
{	
   category = "RigidBody";

   shapeFile = "art/shapes/crates/crate1.dts";
   shapeType = $ShapeType::Box;
   mass = 2;
   scale = "0.5 0.5 0.5";
   
   minContactSpeed = 1.0;
   slidingThreshold = 0.1;
   collisionSoundsCount = 3;
   collisionSound[0] = boxFall0;
   collisionSound[1] = boxFall1;
   collisionSound[2] = boxFall2;
};

//----------------------------------------------------------------------------------------------------------------------------------------------------

datablock SFXProfile(stoneRoll0)
{
	filename = "art/sound/physics/stoneRoll";
	description = AudioClosest3d;
	preload = true;
};


datablock RigidBodyData( StatPhysBox )
{	
   category = "RigidBody";

   shapeFile = "art/shapes/crates/crate1.dts";
   shapeType = $ShapeType::Box;
   mass = 0;
};

datablock RigidBodyData( PhysSphere )
{	
   category = "RigidBody";
   shapeFile = "art/shapes/rocks/boulder.dts";
   shapeType = $ShapeType::Sphere;
   mass = 5;
   scale = "0.3 0.3 0.3";
 
   
   slidingThreshold = 0.7;
   minContactSpeed = 1.0;
   collisionSoundsCount = 1;
   collisionSound[0] = boxFall0;
   
   slideSoundsCount = 1;
   slideSound[0] = stoneRoll0;

};

//----------------------------------------------------------------------------------------------------------------------------------------------------
datablock SFXProfile(barrelFall0)
{
	filename = "art/sound/physics/barrelFall0";
	description = AudioDefault3d;
	preload = true;
};

datablock SFXProfile(barrelFall1)
{
	filename = "art/sound/physics/barrelFall1";
	description = AudioDefault3d;
	preload = true;
};

datablock SFXProfile(barrelRoll)
{
	filename = "art/sound/physics/barrelFall1";
	description = AudioDefault3d;
	preload = true;
};
datablock RigidBodyData( PhysBarrel )
{	
   category = "RigidBody";
   shapeFile =  "art/shapes/steel_barrel_green/steel_barrel_green.dts";
   shapeType = $ShapeType::Cylinder;
   rotAngles = "0 0 0 0";
   offset = "0 0 0.5 0";
   mass = 4;
  
   slidingThreshold = 0.7;

   minContactSpeed = 1.0;
   collisionSoundsCount = 1;
   collisionSound[0] = barrelFall0;
   collisionSound[1] = barrelFall1;
   
   slideSoundsCount = 1;
   slideSound[0] = barrelRoll;
};

//----------------------------------------------------------------------------------------------------------------------------------------------------
datablock SFXProfile(wheelFall0)
{
	filename = "art/sound/physics/wheelFall0";
	description = AudioDefault3d;
	preload = true;
};

datablock SFXProfile(wheelFall1)
{
	filename = "art/sound/physics/wheelFall1";
	description = AudioDefault3d;
	preload = true;
};

datablock SFXProfile(wheelFall2)
{
	filename = "art/sound/physics/wheelFall2";
	description = AudioDefault3d;
	preload = true;
};

datablock RigidBodyData( PhysWheel )
{	
   category = "RigidBody";
   shapeFile =  "art/shapes/Wheel/Wheel.dts";
   shapeType = $ShapeType::Cylinder;
   mass = 1;
   rotAngles = "0 90 0 0";
   offset = "0 0 0 0";

  
   slidingThreshold = 0.7;

   minContactSpeed = 1.0;
   collisionSoundsCount = 1;
   collisionSound[0] = wheelFall0;
   collisionSound[1] = wheelFall1;
   collisionSound[2] = wheelFall2;
   
   slideSoundsCount = 1;
   slideSound[0] = wheelFall0;
};
exec("./rigidBodiesTest.cs");
//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);
inheritTemplate("PhysBox", "AbstractRigidBody");
registerTemplate("PhysBox", "Physics", "RigidBodyData::create(PhysBox);");

inheritTemplate("PhysSphere", "AbstractRigidBody");
registerTemplate("PhysSphere", "Physics", "RigidBodyData::create(PhysSphere);");

inheritTemplate("PhysBarrel", "AbstractRigidBody");
registerTemplate("PhysBarrel", "Physics", "RigidBodyData::create(PhysBarrel);");

inheritTemplate("PhysWheel", "AbstractRigidBody");
registerTemplate("PhysWheel", "Physics", "RigidBodyData::create(PhysWheel);");

DeactivatePackage(TemplateFunctions);