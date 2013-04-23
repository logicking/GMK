//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

// First we execute the core default preferences.
exec( "core/scripts/server/defaults.cs" );


// Now add your own game specific server preferences as
// well as any overloaded core defaults here.




// Finally load the preferences saved from the last
// game execution if they exist.
if ( $platform !$= "xenon" )
{
   if ( isFile( "./prefs.cs" ) )
      exec( "./prefs.cs" );
}
else
{
   echo( "Not loading server prefs.cs on Xbox360" );
}
if ( isFile( "./logickingMechanics/physics.cs" ) )
   exec( "./logickingMechanics/physics.cs");

