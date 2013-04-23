//-----------------------------------------------------------------------------
// Copyright 2008 (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

#ifndef _PHYSJOINTBULLET_H_
#define _PHYSJOINTBULLET_H_

#include "T3D/logickingMechanics/physics/physJoint.h"
#include "T3D/logickingMechanics/physics/bullet/physShapeBullet.h"

class PhysJointBullet : public PhysJoint
{
public:
	PhysJointBullet();
	PhysJointBullet(Physics* phys,PhysJointInfo &physJointDescr);
	virtual ~PhysJointBullet();
protected:
	btDiscreteDynamicsWorld* m_world;
	btTypedConstraint*	m_constrained;
};

#endif