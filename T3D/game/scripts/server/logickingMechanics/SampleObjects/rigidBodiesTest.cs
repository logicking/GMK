//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------
// Test rigid bodies
//---------------------------------------------------------------

function coll()
{
   new TSStatic(coll) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      position = "560.095 659.057 258.09";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      //shapeName = "art/shapes/test/LMA_LampBase.dae";
      shapeName = "art/shapes/test/LMA_LampBase2.dae";
      receiveSunLight = "1";
      receiveLMLighting = "1";
      useCustomAmbientLighting = "0";
      customAmbientLighting = "0 0 0 1";
      usePolysoup = "0";
      allowPlayerStep = "1";
      renderNormals = "0";
   };
}
//////////////test functions/////////////////
function crai()
{
	new RigidBody(rsh) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      //position = "355 570 145";
      position = $playerForAi.getPosition();
      //position = "560.095 661.057 261.09";
	  //position = "519.416 673.461 258.4";
      rotation = "1 0 0 0";
      scale = "0.5 0.5 0.5";
	  //scale = "0.3 0.3 0.3";
      dataBlock = "PhysBox";
      collision = "0";
   };
}

function crpx()
{
	new PxMultiActor(rsh) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      position = "560.095 661.057 261.09";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      dataBlock = "pxBlackBarrel";
      collision = "0";
   };
}

function fl()
{
	new SoftBody(fl) {
      canSaveDynamicFields = "1";
      Enabled = "1";
	  //position = "370 572 145";
	  position = "560 661 261";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      dataBlock = "PhysFlag";
      collision = "0";
   };
}

function crs2()
{
	new SoftBody(rsh2) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      //position = "370 572 145";
      position = "560.095 661.057 261.09";
      rotation = "1 0 0 0";
      scale = "0.3 0.3 0.3";
      dataBlock = "PhysSoftSphere";
      collision = "0";
   };
}


function cr()
{
	new RigidBody(rsh) {
      canSaveDynamicFields = "1";
      Enabled = "1";
	  position = "560.095 661.057 261.09";
     //position = "560.095 661.057 261.09";
	  //position = "519.416 673.461 258.4";
      rotation = "1 0 0 0";
      scale = "0.5 0.5 0.5";
	  //scale = "0.3 0.3 0.3";
      dataBlock = "PhysBox";
      collision = "0";
   };
}
function crup()
{
   rsh2.setPosition(VectorAdd("0 0 2",rsh2.getPosition()));
}
function cr2()
{
	new RigidBody(rsh2) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      //position = "355 570 145";
	  //position = "370 572 145";
      //position = "220 506 178";
      position = "560.095 661.057 261.09";
	  //position = "519.416 673.461 258.4";
      rotation = "1 0 0 0";
      scale = "0.3 0.3 0.3";
      dataBlock = "PhysSphere";
      collision = "0";
   };
}
function cr3()
{
	new RigidBody(rsh3) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      position = "355 570 142";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      dataBlock = "PhysBarrel";
      collision = "0";
   };
}

function cr4()
{
	new RigidBody(rsh4) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      position = "355 570 142";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      dataBlock = "PhysWheel";
      collision = "0";
   };
}
function ra()
{
   new RagDoll(rc) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      position = "560.095 661.057 257";
      //position = "355 570 140.763";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      dataBlock = "SpaceOrcRagDoll";
      collision = "0";
   };
}
function orc()
{
	new AIBot(orc) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      //position = "355 570 140.763";
      position = "560.095 661.057 261.09";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      dataBlock = "SpaceOrcBotData";
      collision = "0";
   };
}
//$nullRagDoll = 1;
function ra2()
{
   new RagDoll(rc2) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      //position = "355 570 140.763";
      position = "560.095 661.057 257.09";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      dataBlock = "ElfRagDoll";
      collision = "0";
   };
}

function elf()
{
	new AIBot(elf) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      //position = "355 570 140.763";
      position = "560.095 661.057 257.09";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      dataBlock = "ElfBotData";
      collision = "0";
   };
}
function ra3()
{
   new RagDoll(rc3) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      position = "357 570 140.763";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      dataBlock = "CasualFemaleRagDoll";
      collision = "0";
   };
}
function casual()
{
	new AIBot(casual) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      position = "357 570 140.763";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      dataBlock = "CasualFemaleBotData";
      collision = "0";
   };
}
