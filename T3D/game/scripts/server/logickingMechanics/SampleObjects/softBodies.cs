//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------
// Sample soft bodies
//-----------------------------------------------------------------------------
datablock SoftBodyData( PhysFlag )
{	
   category = "SoftBody";
   shapeFile = "art/shapes/flag/Triapko.dts";
   mass = 5;
   
   // A softness of body. 1 - to have a solid rigid body, 0 for cloth(for physX - poseMatchKoef = pressure /5)
   poseMatchKoef = 0;
   
   scale = "1 1 1";
   
   attachedPointsNum = 2;
   attachedPoints[0] = "-10 10 0";
   attachedPoints[1] = "10 10 0";
   
   onlyOnClient = true;
};

datablock SoftBodyData( PhysSoftSphere )
{	
   category = "SoftBody";
   shapeFile = "art/shapes/ball/ball.dts";
   shapeType = $ShapeType::SoftMesh;
   mass = 3;
   scale = "0.4 0.4 0.4";
   poseMatchKoef = 0.2;
   
   slidingThreshold = 0.7;
   minContactSpeed = 1.0;
   collisionSoundsCount = 1;
   collisionSound[0] = boxFall0;
   
   slideSoundsCount = 1;
   slideSound[0] = stoneRoll0;
   onlyOnClient = true;
};

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
ActivatePackage(TemplateFunctions);
inheritTemplate("PhysFlag", "AbstractRigidBody");
registerTemplate("PhysFlag", "Physics", "SoftBodyData::create(PhysFlag);");

inheritTemplate("PhysSoftSphere", "AbstractRigidBody");
registerTemplate("PhysSoftSphere", "Physics", "SoftBodyData::create(PhysSoftSphere);");

DeactivatePackage(TemplateFunctions);