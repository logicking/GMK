//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

#include "platformWin32/platformWin32.h"
#include "core/strings/stringFunctions.h"

void Platform::postQuitMessage(const U32 in_quitVal)
{
   if (!Platform::getWebDeployment())
      PostQuitMessage(in_quitVal);
}
//.logicking added normal debug break
#include <assert.h>

void Platform::debugBreak()
{
	assert(false);
    DebugBreak();
}

void Platform::forceShutdown(S32 returnValue)
{
   // Don't do an ExitProcess here or you'll wreak havoc in a multithreaded
   // environment.

   exit( returnValue );
}

void Platform::outputDebugString( const char *string, ... )
{
   // Expand string.

   char buffer[ 2048 ];
   
   va_list args;
   va_start( args, string );
   
   dVsprintf( buffer, sizeof( buffer ), string, args );
   va_end( args );

   // Append a newline to buffer.  This is better than calling OutputDebugStringA
   // twice as in a multi-threaded environment, some other thread may output some
   // stuff in between the two calls.

   U32 length = strlen( buffer );
   if( length == ( sizeof( buffer ) - 1 ) )
      length --;

   buffer[ length ]     = '\n';
   buffer[ length + 1 ] = '\0';

   OutputDebugStringA( buffer );
}

