//-----------------------------------------------------------------------------
// Torque        Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

// game specific functionality provided by shell gui callbacks.

/// Callback from the shell button for triggering single player.
function onSinglePlayer()
{
   loadDefaultMission();
}
function onMultiPlayer()
{
   loadDefaultMission("MultiPlayer");
}