/*
This software is provided 'as-is', without any express or implied warranty.
In no event will the authors be held liable for any damages arising from the use of this software.
Permission is granted to anyone to use this software for any purpose, 
including commercial applications, and to alter it and redistribute it freely, 
subject to the following restrictions:

1. The origin of this software must not be misrepresented; you must not claim that you wrote the original software. If you use this software in a product, an acknowledgment in the product documentation would be appreciated but is not required.
2. Altered source versions must be plainly marked as such, and must not be misrepresented as being the original software.
3. This notice may not be removed or altered from any source distribution.
*/
#include <stdio.h> //printf debugging
#include "btHinge2Vehicle.h"

btScalar IDrivingInterface::m_inputSpeed=btScalar(1.0f);

 //region Static Helper Methods
// This is the heart of this class (and outside this method, there's very little more left). 
static btHinge2Constraint* CreateHinge2Joint(btDynamicsWorld* btWorld,btRigidBody* upperBody,btRigidBody* lowerBody,btScalar verticalSlidersExtension=-1,btScalar verticalSlidersMotorVelocity=-1,btScalar verticalSlidersMotorMaxForce=-1)
{
		if (!upperBody || !lowerBody) return NULL;

		 //region validate and set invalid fields to some logical values ( by completely guessing at them and hoping we are lucky )
		if (verticalSlidersExtension<0) {
			verticalSlidersExtension=0;
			if (lowerBody->getCollisionShape())	{
				btVector3 aabbMin;
				btVector3 aabbMax;
				lowerBody->getCollisionShape()->getAabb(lowerBody->getWorldTransform(),aabbMin,aabbMax);
				verticalSlidersExtension = (aabbMax-aabbMin).y()*0.25;
			}
		}
		if (verticalSlidersMotorVelocity<0) verticalSlidersMotorVelocity = 1.0;
		if (verticalSlidersMotorMaxForce<0) verticalSlidersMotorMaxForce = upperBody->getInvMass() == 0 ? 0 : (1.0/upperBody->getInvMass())	* 2.5 / 20.0;
		//endregion

		lowerBody->setActivationState(DISABLE_DEACTIVATION);
				
		btVector3 parentAxis(upperBody->getWorldTransform().getBasis().getColumn(1));	// y Axis
		btVector3 childAxis(-upperBody->getWorldTransform().getBasis().getColumn(0));	// x Axis (negative so that a positive spin is a forward spin)
		btVector3 anchor(lowerBody->getWorldTransform().getOrigin());//lowerBody->getPosition());
		btHinge2Constraint* pHinge2 = new btHinge2Constraint(*upperBody, *lowerBody, anchor, parentAxis, childAxis);
		
		// Steering angle ( we'll set a motor and some stuff to control it later )
		pHinge2->setLowerLimit(0);
		pHinge2->setUpperLimit(0);
		
		// Vertical suspension:
		// Axis Y is actually the 3rd component ( and axis number 2 ):
		const bool useSpringSuspensionModel = false;		// I set it to false by default. It seems to work better (simpler and coarser suspension model, but I can't find good spring params to set...)
		pHinge2->enableSpring(2, useSpringSuspensionModel);	// Spring keeps going up/down, instead we use a motor to create the suspension (basically we're not really the spring of the btHinge2Constraint constraint!)  
															// Thus our suspensions will be at maximum length most of the time (very bad suspension model!)
		if (useSpringSuspensionModel)	{
			pHinge2->setLinearUpperLimit(btVector3(0,0,0));
			pHinge2->setLinearLowerLimit(btVector3(0,0,-verticalSlidersExtension*2.5f));

			// I know nothing about right params here... I've tried many things, but the solution without spring seems to work better
			// Maybe somebody is able to make this work better...
			pHinge2->setStiffness(2, 5000);//0.5f);		
			pHinge2->setDamping(2, 0.25);//0.5f);	// between 0 and 1 (1 == no damping)
			//pHinge2->setEquilibriumPoint(2);  // set the current constraint position/orientation as an equilibrium point for given DOF
		}
		else	
		{
			pHinge2->setLinearUpperLimit(btVector3(0,0,0));
			pHinge2->setLinearLowerLimit(btVector3(0,0,-verticalSlidersExtension));
					
			pHinge2->getTranslationalLimitMotor()->m_enableMotor[2] = true;
			pHinge2->getTranslationalLimitMotor()->m_targetVelocity[2] = verticalSlidersMotorVelocity;//1.0f;
			pHinge2->getTranslationalLimitMotor()->m_maxMotorForce[2] = verticalSlidersMotorMaxForce;//2.5f;		
		}
		// add constraint to world
		btWorld->addConstraint(pHinge2, true);
		
		return pHinge2;
}	
// This are just to save coding time, since I'm feeling very lazy.
template < typename T,typename U > static void iterate(btAlignedObjectArray<btHinge2Constraint*>& A,void (*predicate)(btHinge2Constraint* C,T arg,U arg2),T arg,U arg2)	{
	if (!predicate) return;
	for (int i = 0,size = A.size();i<size;i++)	{
		btHinge2Constraint* C = A[i];
		if (C) predicate(C,arg,arg2);
	}
}
template < typename T,typename U > static void iterate(btAlignedObjectArray<btHinge2Constraint*>& A,btAlignedObjectArray<btHinge2Constraint*>& B,void (*predicate)(btHinge2Constraint* C,T arg,U arg2),T arg,U arg2)	{
	iterate<T,U>(A,predicate);
	iterate<T,U>(B,predicate);
}
 //region predicates
static void enableMotor(btHinge2Constraint* pHinge2,btScalar targetVelocity = 5.0f,btScalar maxMotorForce = 0.1f) {
	pHinge2->getRotationalLimitMotor(0)->m_enableMotor = true;
	pHinge2->getRotationalLimitMotor(0)->m_targetVelocity = targetVelocity;
	pHinge2->getRotationalLimitMotor(0)->m_maxMotorForce = maxMotorForce;	
}
static void disableMotor(btHinge2Constraint* pHinge2,btScalar targetVelocity = 5.0f,btScalar maxMotorForce = 0.1f) {
	pHinge2->getRotationalLimitMotor(0)->m_enableMotor = false;
	pHinge2->getRotationalLimitMotor(0)->m_targetVelocity = targetVelocity;
	pHinge2->getRotationalLimitMotor(0)->m_maxMotorForce = maxMotorForce;	
}
static void setSteeringAngle(btHinge2Constraint* pHinge2,btScalar steeringAngle = 0.0f,btScalar steeringVelocity = 10.0f) {
	pHinge2->setLowerLimit(steeringAngle);
	pHinge2->setUpperLimit(steeringAngle);

	pHinge2->getRotationalLimitMotor(2)->m_enableMotor = true;
	pHinge2->getRotationalLimitMotor(2)->m_targetVelocity = steeringVelocity;
	pHinge2->getRotationalLimitMotor(2)->m_maxMotorForce = 500.0;//maxMotorForce;		
}
static void setLooseWheels(btHinge2Constraint* pHinge2,btScalar minAngle,btScalar maxAngle) {
	pHinge2->setLowerLimit(minAngle);
	pHinge2->setUpperLimit(maxAngle);

	pHinge2->getRotationalLimitMotor(2)->m_enableMotor = false;
}
//endregion
//endregion

 //region Class btHinge2Vehicle  
void btHinge2Vehicle::init(btDynamicsWorld* btWorld,btRigidBody* chassisRB,btAlignedObjectArray<btRigidBody*>& wheels,unsigned short numberOfSteeringWheelsThatComeFirst,unsigned short tractionMode,btScalar verticalSlidersExtension,btScalar verticalSlidersMotorVelocity,btScalar verticalSlidersMotorMaxForce)	
{
	destroy();
	this->btWorld = btWorld;
	this->tractionMode = tractionMode>2 ? 0 : tractionMode;

	if (chassisRB==NULL) {
		printf("Param error: chassisRB==NULL in void btHinge2Vehicle::init(...)\n");
		return;
	}	 
	this->chassisRB = chassisRB;

	int wheelsSize = wheels.size();
	this->steeringWheelsRB.clear();
	this->stillWheelsRB.clear();	
	for (int t=0;t<numberOfSteeringWheelsThatComeFirst;t++)	{
	 	if (t<wheelsSize && wheels[t]) this->steeringWheelsRB.push_back(wheels[t]);	
	}
	for (int t=numberOfSteeringWheelsThatComeFirst;t<wheels.size();t++)	{
	 	if (wheels[t]) this->stillWheelsRB.push_back(wheels[t]);	
	}
	this->chassisRB->setActivationState(DISABLE_DEACTIVATION); 
	int size = steeringWheelsRB.size();
	for (int t=0;t<size;t++)	{
		btRigidBody* WRB = steeringWheelsRB[t];
		if (WRB) {
			btHinge2Constraint* hinge2 = CreateHinge2Joint(this->btWorld,this->chassisRB,WRB,verticalSlidersExtension,verticalSlidersMotorVelocity,verticalSlidersMotorMaxForce);
			if (hinge2) steeringWheelsCS.push_back(hinge2);
		}	
	}
	size = stillWheelsRB.size();
	for (int t=0;t<size;t++)	{
		btRigidBody* WRB = stillWheelsRB[t];
		if (WRB) {
			btHinge2Constraint* hinge2 = CreateHinge2Joint(this->btWorld,this->chassisRB,WRB,verticalSlidersExtension,verticalSlidersMotorVelocity,verticalSlidersMotorMaxForce);
			if (hinge2) stillWheelsCS.push_back(hinge2);
		}	
	}	
}

void btHinge2Vehicle::destroy()	{
	if (btWorld)	{
	int size = steeringWheelsCS.size();
	for (int t=0;t<size;t++)	{
		if (steeringWheelsCS[t]) {
			btWorld->removeConstraint(steeringWheelsCS[t]);
			delete steeringWheelsCS[t];
		}	
	}
	steeringWheelsCS.clear();
	size = stillWheelsCS.size();
	for (int t=0;t<size;t++)	{
		if (stillWheelsCS[t]) {
			btWorld->removeConstraint(stillWheelsCS[t]);
			delete stillWheelsCS[t];
		}	
	}
	stillWheelsCS.clear();
	size = steeringWheelsRB.size();
	for (int t=0;t<size;t++)	{
		if (steeringWheelsRB[t]) {
			btWorld->removeRigidBody(steeringWheelsRB[t]);
			delete steeringWheelsRB[t];
		}	
	}
	steeringWheelsRB.clear();
	size = stillWheelsRB.size();
	for (int t=0;t<size;t++)	{
		if (stillWheelsRB[t]) {
			btWorld->removeRigidBody(stillWheelsRB[t]);
			delete stillWheelsRB[t];
		}	
	}
	stillWheelsRB.clear();	
	}
	btWorld = NULL;
	steeringLock=velocityLock=false;

	 //region IDrivingInterface additional variables
	const btScalar m_inputFactor = m_inputSpeed * 0.04f;
	m_streeringReturnConstant = 1.0f;
	m_velocityIncrementFactor = 1.0f;		
	m_steeringIncrementFactor = 1.0f;
		
    m_maxPossibleSteeringAngle=btRadians(40.0);
	m_minPossibleSteeringAngle=-m_maxPossibleSteeringAngle;
	m_steeringVelocity=0.2f;	// How fast is steering
	
	m_maxPossibleVelocity=35.0f; // It's the ANGULAR velocity of the traction wheels
	m_minPossibleVelocity=-m_maxPossibleVelocity*0.3f;
	m_engineMotorForce=20.0f;	
	
	m_velocityIncrement = 0.25f * m_velocityIncrementFactor * m_maxPossibleVelocity * m_inputFactor;		
	m_steeringIncrement = 5.0f * m_steeringIncrementFactor * m_maxPossibleSteeringAngle * m_inputFactor;
	
	m_steerLeft=false;
	m_steerRight=false;	
	m_restoreVehicleOrientationIfNotGoodWhenVehicleIsStopped=true; 
	//endregion
}

void btHinge2Vehicle::setVelocity(btScalar targetVelocity,btScalar maxMotorForce)	{
	if (velocityLock) return;
	if (tractionMode == 1) setVelocityToStillWheels(targetVelocity,maxMotorForce);
	else if (tractionMode == 2)	setVelocityToAllWheels(targetVelocity,maxMotorForce);
	else setVelocityToTurningWheels(targetVelocity,maxMotorForce);
}
void btHinge2Vehicle::setVelocityToAllWheels(btScalar targetVelocity,btScalar maxMotorForce)	{
	if (velocityLock) return;
	setVelocityToTurningWheels(targetVelocity,maxMotorForce);
	setVelocityToStillWheels(targetVelocity,maxMotorForce);
}
void btHinge2Vehicle::setVelocityToStillWheels(btScalar targetVelocity,btScalar maxMotorForce)	{
	if (velocityLock) return;
	velocity = targetVelocity;
	iterate(stillWheelsCS,&enableMotor,targetVelocity,maxMotorForce);
}
void btHinge2Vehicle::setVelocityToTurningWheels(btScalar targetVelocity,btScalar maxMotorForce)	{
	if (velocityLock) return;
	velocity = targetVelocity;
	iterate(steeringWheelsCS,&enableMotor,targetVelocity,maxMotorForce);
}
void btHinge2Vehicle::setSteeringAngle(btScalar steeringAngle,btScalar steeringVelocity)	{
	if (steeringLock) return;
	this->steeringAngle = steeringAngle;
	this->steeringVelocity = steeringVelocity;
	iterate(steeringWheelsCS,&::setSteeringAngle,-steeringAngle,steeringVelocity);	// minus = steer right is positive
}

void btHinge2Vehicle::setLooseWheels(btScalar minAngle,btScalar maxAngle,unsigned short mode0front1rear2all)	{
	if (mode0front1rear2all<0 || mode0front1rear2all>2) mode0front1rear2all=2;
	if (mode0front1rear2all==0 || mode0front1rear2all==2)	
			iterate(steeringWheelsCS,&::setLooseWheels,minAngle,maxAngle);
	if (mode0front1rear2all==1 || mode0front1rear2all==2)	
			iterate(stillWheelsCS,&::setLooseWheels,minAngle,maxAngle);			
} 

//endregion
