//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

///////////////// GLOBALS
$GMKVersion = "1.2.9"; // current pack version 

$soundFilesMask = "Sound Files (*.ogg, *.wav)|*.ogg;*.wav|All Files (*.*)|*.*|";

//Includes

// Editor functionality
exec("./gameObjectCategories.cs");

// Object classes
exec("./player.cs");
exec("./packages.cs");
exec("./camera.cs");

exec("./helpers.cs");

exec("./breakable.cs");
exec("./usable.cs");
exec("./openable.cs");
exec("./door.cs");
exec("./locker.cs");
exec("./switcher.cs");
exec("./aiTeamsList.cs");
exec("./aiBot.cs");
exec("./aiTeams.cs");
exec("./eventTrigger.cs");
exec("./damageTrigger.cs");
exec("./counter.cs");
exec("./soundPlayer.cs");
exec("./invisibleWall.cs");
exec("./inventoryItem.cs");
exec("./switcher.cs");
exec("./cutScene.cs");
exec("./path.cs");

// Physics
exec("./physicsBody.cs");
exec("./ragDoll.cs");

// Sample Objects
exec("./sampleObjects/barrels.cs");
exec("./sampleObjects/doors.cs");
exec("./sampleObjects/lockers.cs");

exec("./sampleObjects/siren.cs");
exec("./sampleObjects/health.cs");
exec("./sampleObjects/keys.cs");
exec("./sampleObjects/sparks.cs");
exec("./sampleObjects/switchers.cs");
exec("./sampleObjects/rigidBodies.cs");
exec("./sampleObjects/ragDolls.cs");

exec("./sampleObjects/softBodies.cs");

exec("./sampleObjects/spaceOrcBot.cs");
exec("./sampleObjects/elfBot.cs");

exec("./sampleObjects/blasterGun.cs");