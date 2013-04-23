//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

#ifndef _BULLET_H_
#define _BULLET_H_

// NOTE: We set these defines which bullet needs here.
#ifdef TORQUE_OS_WIN32
#define WIN32
#endif

// NOTE: All the Bullet includes we use should be here and
// nowhere else.... beware!

#include <btBulletDynamicsCommon.h>
#include <BulletCollision/CollisionDispatch/btGhostObject.h>
#include <BulletCollision/CollisionShapes/btHeightfieldTerrainShape.h>

#include <BulletMultiThreaded/PlatformDefinitions.h>
#include <BulletMultiThreaded/SpuGatheringCollisionDispatcher.h>
#include <BulletMultiThreaded/Win32ThreadSupport.h>
#include <BulletMultiThreaded/SpuNarrowPhaseCollisionTask/SpuGatheringCollisionTask.h>

//.logicking >>
#include "BulletSoftBody/btSoftRigidDynamicsWorld.h"
#include "BulletSoftBody/btSoftBodyRigidBodyCollisionConfiguration.h"
#include "BulletSoftBody/btSoftBodyHelpers.h"
//.logicking <<

#endif // _BULLET_H_