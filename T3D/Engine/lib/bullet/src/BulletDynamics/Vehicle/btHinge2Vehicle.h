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
#pragma once
#ifndef HINGE2_VEHICLE_H
#define HINGE2_VEHICLE_H

#include <stdio.h> //printf debugging
#include "btBulletDynamicsCommon.h"

/** Just a pure abstract class that expose key feedback (to be called by the main event loop).
*/
class IDrivingInterface	{
	public:
	
	virtual void onUp()=0;
	virtual void onDown()=0;
	virtual void onLeft()=0;
	virtual void onRight()=0;
	
	virtual void onPostInput()=0;
	
	virtual const btRigidBody* getChassis() const=0;	// This is required for camera targeting purpose
		
	static btScalar m_inputSpeed;	// This can be used to adjust speed on a fast or slow PC.
};

/** Basically this class implements a (simple) constraint that can be used to keep together a vehicle chassis
    with the vehicle wheels, together with some (extremely simple) methods to drive it.
    Note that no "advanced" logic is implemented at all (e.g. no gears, no differential and so on).
    And please keep present that in real applications raycast vehicles usually behave better than this kind of vehicles.

	AFAIR the vehicle should be oriented in its Z direction (to be checked).
*/
class btHinge2Vehicle : public IDrivingInterface{
	public:
	 //region Ctr And Dtr
	/** ctr:
		The rigid bodies that must be passed to it need to be added to a btWorld and can't be deleted after the call.
		This class just adds contraints between chassis and wheels.	
	*/
	btHinge2Vehicle(btDynamicsWorld* btWorld,btRigidBody* chassisRB,btAlignedObjectArray<btRigidBody*>& wheels,unsigned short numberOfSteeringWheelsThatComeFirst,unsigned short tractionMode=0,btScalar verticalSlidersExtension=-1,btScalar verticalSlidersMotorVelocity=-1,btScalar verticalSlidersMotorMaxForce=-1)	
	: btWorld(NULL),chassisRB(NULL),tractionMode(0),velocity(0),steeringAngle(0),steeringVelocity(0),steeringLock(false),velocityLock(false)
	{
		init(btWorld,chassisRB,wheels,numberOfSteeringWheelsThatComeFirst,tractionMode,verticalSlidersExtension,verticalSlidersMotorVelocity,verticalSlidersMotorMaxForce);
	}
	virtual void destroy();		// Can be called by the user before exiting, otherwise it's called in the dtr, where btWorld could be already gone...
	virtual ~btHinge2Vehicle()	{destroy();}
	//endregion
	
	 //region btRigidBody* Getters
	SIMD_FORCE_INLINE const btRigidBody* getChassis() const {return chassisRB;}	// IDrivingInterface as well
	SIMD_FORCE_INLINE btRigidBody* getChassis() {return chassisRB;}
	SIMD_FORCE_INLINE int getNumWheels() const {
		return steeringWheelsRB.size()+stillWheelsRB.size();		
	}	
	SIMD_FORCE_INLINE btRigidBody* getWheel(int i) {
		const int twSize = steeringWheelsRB.size();
		const int swSize = stillWheelsRB.size();
		const int totwSize = twSize+swSize;
		if (i<0 || i>=totwSize) return NULL;
		return i < twSize ? steeringWheelsRB[i] : stillWheelsRB[i-twSize];
	} 
	SIMD_FORCE_INLINE int getNumSteeringWheels() const {
		return steeringWheelsRB.size();		
	}	
	SIMD_FORCE_INLINE btRigidBody* getSteeringWheel(int i) {
		return (i>=0 && i<steeringWheelsRB.size()) ? steeringWheelsRB[i] : NULL;
	} 
	// "Still" wheels are just wheels that don't steer.
	SIMD_FORCE_INLINE int getNumStillWheels() const {
		return stillWheelsRB.size();		
	}	
	SIMD_FORCE_INLINE btRigidBody* getStillWheel(int i) {
		return (i>=0 && i<stillWheelsRB.size()) ? stillWheelsRB[i] : NULL;
	} 
	SIMD_FORCE_INLINE int getNumTractionWheels() const {
		return (tractionMode==0 ? getNumSteeringWheels() : tractionMode==1 ? getNumStillWheels() : getNumWheels());		
	}
	SIMD_FORCE_INLINE btRigidBody* getTractionWheel(int i)	{
		return (tractionMode==0 ? getSteeringWheel(i) : tractionMode==1 ? getStillWheel(i) : getWheel(i));
	}
	//endregion
	
	 //region Runtime Methods (Low Level)
	// It's the target angular velocity of the traction wheels, not the instant linear velocity
	void setVelocity(btScalar targetVelocity = 5.0f,btScalar maxMotorForce = 0.1f);
	SIMD_FORCE_INLINE void addVelocity(btScalar additionalVelocity,btScalar m_minPossibleVelocity,btScalar m_maxPossibleVelocity,btScalar maxMotorForce = 0.1f)	{
		if (velocityLock) return;
		btScalar newVelocity = additionalVelocity + getVelocity();
		newVelocity = newVelocity < m_minPossibleVelocity ? m_minPossibleVelocity : newVelocity > m_maxPossibleVelocity ? m_maxPossibleVelocity : newVelocity;
		setVelocity(newVelocity,maxMotorForce);
	}
	// This does not work as expected: velocity is the target (angular) velocity, not the actual average (angular) velocity of all the wheels
	// TODO: modify it, otherwise addVelocity(...) will keep increasing additionalVelocity too fast...
	SIMD_FORCE_INLINE btScalar getVelocity() const {return velocity;}	
	
	// It's the target steering angle
	void setSteeringAngle(btScalar steeringAngle,btScalar steeringVelocity = 10.0f);
	SIMD_FORCE_INLINE void addSteeringAngle(btScalar additionalSteeringAngle,btScalar minPossibleSteeringAngle,btScalar maxPossibleSteeringAngle,btScalar steeringVelocity = 10.0f)	{
		if (steeringLock) return;
		btScalar newSteeringAngle = additionalSteeringAngle + getSteeringAngle();
		newSteeringAngle = newSteeringAngle < minPossibleSteeringAngle ? minPossibleSteeringAngle : newSteeringAngle > maxPossibleSteeringAngle ? maxPossibleSteeringAngle : newSteeringAngle;
		setSteeringAngle(newSteeringAngle,steeringVelocity);
	}	
	SIMD_FORCE_INLINE btScalar getSteeringAngle() const {return steeringAngle;}
	//endregion
	
	 //region Other Methods
	/** Allows passive steering to the (selected) wheels.
	    #params mode0front1rear2all - selects the wheels
	*/
	void setLooseWheels(btScalar minAngle,btScalar maxAngle,unsigned short mode0front1rear2all=2); 
	/** The velocity lock flag inhibits the setVelocity(...) and addVelocity(...) methods.
	*/
	SIMD_FORCE_INLINE void setVelocityLock(bool flag) {velocityLock=flag;}
	/** The velocity lock flag inhibits the setVelocity(...) and addVelocity(...) methods.
	*/
	SIMD_FORCE_INLINE bool getVelocityLock() const {return velocityLock;}
	/** The steering lock flag inhibits the setSteeringAngle(...) and addSteeringAngle(...) methods.
	*/
	SIMD_FORCE_INLINE void setSteeringLock(bool flag) {steeringLock=flag;}
	/** The steering lock flag inhibits the setSteeringAngle(...) and addSteeringAngle(...) methods.
	*/
	SIMD_FORCE_INLINE bool getSteeringLock() const {return steeringLock;}
	//endregion
	
	 //region IDrivingInterface (Plus High Level Methods)
	// Please note that all the code and additional variables) inside IDrivingInterface blocks can be avoided,
	// we just need to call addVelocity(...) or setVelocity(...) and addSteeringAngle(...) ourself manually and that's all.
	
	// I've just added it, because I wanted to drive many different vehicles, and I'm too lazy (as usual...) to
	// check for all the different vehicle conditions in the main glut event loop to set up the correct params...
	virtual void onUp()	{
		// Since inverting speed is usually too slow, we add the first line:
		if (getVelocity()<0) addVelocity(3.0f*m_velocityIncrement,m_minPossibleVelocity,0,m_engineMotorForce*2.0);	
		else addVelocity(m_velocityIncrement,m_minPossibleVelocity,m_maxPossibleVelocity,m_engineMotorForce);
	}
	virtual void onDown() {
		// Since inverting speed is usually too slow, we add the first line:
		if (getVelocity()>0) addVelocity(-5.0f*m_velocityIncrement,0,m_maxPossibleVelocity,m_engineMotorForce*3.0);	
		else addVelocity(-m_velocityIncrement,m_minPossibleVelocity,m_maxPossibleVelocity,m_engineMotorForce);	
	}
	virtual void onLeft() {
		//printf("onLeft() -> m_steeringIncrement=%10.2f m_minPossibleSteeringAngle=%10.2f, m_maxPossibleSteeringAngle=%10.2f m_steeringVelocity=%10.2f steeringAngle=%10.2f\n",m_steeringIncrement/SIMD_PI*180.f,m_minPossibleSteeringAngle/SIMD_PI*180.f,m_maxPossibleSteeringAngle/SIMD_PI*180.f,m_steeringVelocity,getSteeringAngle()/SIMD_PI*180.f);
		addSteeringAngle(m_steeringIncrement,m_minPossibleSteeringAngle,m_maxPossibleSteeringAngle,m_steeringVelocity);
		m_steerLeft=true;		
	}
	virtual void onRight(){
		//printf("onRight() -> -m_steeringIncrement=%10.2f m_minPossibleSteeringAngle=%10.2f, m_maxPossibleSteeringAngle=%10.2f m_steeringVelocity=%10.2f steeringAngle=%10.2f\n",-m_steeringIncrement/SIMD_PI*180.f,m_minPossibleSteeringAngle/SIMD_PI*180.f,m_maxPossibleSteeringAngle/SIMD_PI*180.f,m_steeringVelocity,getSteeringAngle()/SIMD_PI*180.f);
		addSteeringAngle(-m_steeringIncrement,m_minPossibleSteeringAngle,m_maxPossibleSteeringAngle,m_steeringVelocity);
		m_steerRight=true;	
	}	
	virtual void onPostInput(){
		// Sets up the "steering return" behavior and reset some variables
		// Hint: to implement different behaviors, we can override this method...
		const btScalar m_inputFactor = m_inputSpeed * 0.04f;
		const btScalar streeringReturnConstant = 0.0175f * m_streeringReturnConstant * m_inputFactor;
		m_velocityIncrement = 0.25f * m_velocityIncrementFactor * m_maxPossibleVelocity * m_inputFactor;		
		m_steeringIncrement = 5.0f * m_steeringIncrementFactor * m_maxPossibleSteeringAngle * m_inputFactor;
		
		btScalar steeringAngle = getSteeringAngle();
		btScalar velocity = getVelocity();
		if (velocity>0 && steeringAngle!=0)	{
			if (fabs(steeringAngle)>0.5f*m_steeringIncrement)	{
				// Close curve radius
				if (steeringAngle<0 && !m_steerRight) {
					steeringAngle += streeringReturnConstant*velocity;
					if (steeringAngle>0) steeringAngle=0;
					setSteeringAngle(steeringAngle);
				}	
				else if (steeringAngle>0 && !m_steerLeft) {
					steeringAngle -= streeringReturnConstant*velocity;
					if (steeringAngle<0) steeringAngle=0;
					setSteeringAngle(steeringAngle);
				}
			}	
			else {
				steeringAngle=0;
				setSteeringAngle(steeringAngle);
			}
		}					
		
		m_steerRight = m_steerLeft = false;
		
		static unsigned long frameCnt=0;	// We don't want to check it each frame
		if (m_restoreVehicleOrientationIfNotGoodWhenVehicleIsStopped && (++frameCnt)%50==0)	{
			frameCnt=0;
			btMatrix3x3& m = chassisRB->getWorldTransform().getBasis();
			const btScalar dot = m.getColumn(1).dot(btVector3(0.,1.,0.));
			if (dot < 0.2 && chassisRB->getLinearVelocity().length2()<0.2)	{
				setVelocity(0.f);
				// We limit the restore directions to the closest match between these:
				const btVector3 vehicleForward=m.getColumn(2);
				if (vehicleForward.dot(btVector3(0.f,0.f,1.f))>0.5f) chassisRB->setWorldTransform(btTransform(btQuaternion(btVector3(0.,1.,0.),0),chassisRB->getWorldTransform().getOrigin()));
				else if (vehicleForward.dot(btVector3(0.f,0.f,-1.f))>0.5f) chassisRB->setWorldTransform(btTransform(btQuaternion(btVector3(0.,1.,0.),SIMD_PI),chassisRB->getWorldTransform().getOrigin()));
				else if (vehicleForward.dot(btVector3(1.f,0.f,0.f))>0.5f) chassisRB->setWorldTransform(btTransform(btQuaternion(btVector3(0.,1.,0.),-SIMD_HALF_PI),chassisRB->getWorldTransform().getOrigin()));
				else if (vehicleForward.dot(btVector3(-1.f,0.f,0.f))>0.5f) chassisRB->setWorldTransform(btTransform(btQuaternion(btVector3(0.,1.,0.),SIMD_HALF_PI),chassisRB->getWorldTransform().getOrigin()));
				else m = btMatrix3x3::getIdentity();
			
				chassisRB->setLinearVelocity(btVector3(0,0,0));
				chassisRB->setAngularVelocity(btVector3(0,0,0));
				btWorld->getPairCache()->cleanProxyFromPairs(chassisRB->getBroadphaseProxy(),btWorld->getDispatcher());		
				}
		}
	}	

	// How wide is steering:
	SIMD_FORCE_INLINE void setMaxPossibleSteeringAngle(const btScalar angle) {
		m_maxPossibleSteeringAngle = angle;
		m_minPossibleSteeringAngle = -angle;
	}
	// How fast is steering:	
	SIMD_FORCE_INLINE void setSteeringVelocity(const btScalar value) {
		m_steeringVelocity = value;
	}
	// How fast the vehicle goes forward (TO CHECK: does it depend on the vehicle mass?)
	SIMD_FORCE_INLINE void setMaxPossibleVelocity(const btScalar value)	{
		m_maxPossibleVelocity = value;
		if (m_minPossibleVelocity>m_maxPossibleVelocity) m_minPossibleVelocity=m_maxPossibleVelocity;
	}
	SIMD_FORCE_INLINE btScalar getMaxPossibleVelocity() const	{
		return m_maxPossibleVelocity;
	}	
	// How fast the vehicle goes backward. This value is typically < 0. (TO CHECK: does it depend on the vehicle mass?)
	SIMD_FORCE_INLINE void setMinPossibleVelocity(const btScalar value)	{
		m_minPossibleVelocity = value;
		if (m_minPossibleVelocity>m_maxPossibleVelocity) m_maxPossibleVelocity=m_minPossibleVelocity;
	}
	SIMD_FORCE_INLINE btScalar getMinPossibleVelocity() const	{
		return m_minPossibleVelocity;
	}		
	// How long does it take to get to an assigned velocity (TO CHECK: probably a heavier vehicle must be assigned a bigger value in order to make it reach the full speed...)	
	SIMD_FORCE_INLINE void setEngineMotorForce(const btScalar value)	{
		m_engineMotorForce = value;
	}
	SIMD_FORCE_INLINE void setAutoRecoverVehicleEnabled(bool flag) {
		m_restoreVehicleOrientationIfNotGoodWhenVehicleIsStopped=flag;
	}
	SIMD_FORCE_INLINE bool getAutoRecoverVehicleEnabled(bool flag) const {
		return m_restoreVehicleOrientationIfNotGoodWhenVehicleIsStopped;
	}

	// How fast the vehicle increment its velocity (in terms of parts of m_maxPossibleVelocity) each time a key is pressed (default value = 1.0).
	SIMD_FORCE_INLINE void setVelocityIncrementFactor(const btScalar value)	{
		m_velocityIncrementFactor = value;
	}
	SIMD_FORCE_INLINE btScalar getVelocityIncrementFactor() const	{
		return m_velocityIncrementFactor;
	}		
	// How fast the vehicle increment its steering angle  (in terms of parts of m_maxPossibleSteeringAngle) each time a key is pressed (default value = 1.0).
	SIMD_FORCE_INLINE void setSteeringIncrementFactor(const btScalar value)	{
		m_steeringIncrementFactor = value;
	}
	SIMD_FORCE_INLINE btScalar getSteeringIncrementFactor() const	{
		return m_steeringIncrementFactor;
	}		
	// How fast the vehicle resets its steering angle (default 1.0f)
	SIMD_FORCE_INLINE void setStreeringReturnConstant(const btScalar value)	{
		m_streeringReturnConstant = value;
	}
	SIMD_FORCE_INLINE btScalar getStreeringReturnConstant() const	{
		return m_streeringReturnConstant;
	}		

	//endregion

	protected:
	 //region Protected Stuff
	btDynamicsWorld* btWorld;	// We store it to delete the constraints in the destroy() method 
	// CONSTRAINTS:
	btAlignedObjectArray<btHinge2Constraint*> steeringWheelsCS;
	btAlignedObjectArray<btHinge2Constraint*> stillWheelsCS;
	// RBs:
	btRigidBody* chassisRB;
	btAlignedObjectArray<btRigidBody*> steeringWheelsRB;
	btAlignedObjectArray<btRigidBody*> stillWheelsRB;
	unsigned short tractionMode; 	// 0 = front, 1 = rear, 2 = 4x4 ( NO differential implemented )
	// velocity
	btScalar velocity;
	void setVelocityToTurningWheels(btScalar targetVelocity = 5.0f,btScalar maxMotorForce = 0.1f);
	void setVelocityToStillWheels(btScalar targetVelocity = 5.0f,btScalar maxMotorForce = 0.1f);
	void setVelocityToAllWheels(btScalar targetVelocity = 5.0f,btScalar maxMotorForce = 0.1f);
	// steer
	btScalar steeringAngle;
	btScalar steeringVelocity;
	bool steeringLock;
	bool velocityLock;
	
	// Mandatory with empty ctr:
	void init(btDynamicsWorld* btWorld,btRigidBody* chassisRB,btAlignedObjectArray<btRigidBody*>& wheels,unsigned short numberOfSteeringWheelsThatComeFirst,unsigned short tractionMode=0,btScalar verticalSlidersExtension=-1,btScalar verticalSlidersMotorVelocity=-1,btScalar verticalSlidersMotorMaxForce=-1);
	//endregion
	 //region IDrivingInterface additional variables
    btScalar m_maxPossibleSteeringAngle;//(btRadians(40.0));
	btScalar m_minPossibleSteeringAngle;//(-m_maxPossibleSteeringAngle);
	btScalar m_steeringVelocity;//(0.2f);	// How fast is steering
	btScalar m_steeringIncrement;// Fixed:  = m_maxPossibleSteeringAngle*m_steeringIncrementFactor*m_inputFactor*SOME_CONST;
	btScalar m_steeringIncrementFactor;// = 1.0f
	btScalar m_streeringReturnConstant;// = 1.0f
	
	btScalar m_maxPossibleVelocity;//(80.0); //* total mass?	// It's the ANGULAR velocity of the traction wheels
	btScalar m_minPossibleVelocity;//(-m_maxPossibleVelocity*0.35);
	btScalar m_engineMotorForce;//(1.05f);	
	btScalar m_velocityIncrement;// Fixed: = m_maxPossibleVelocity*m_velocityIncrementFactor*m_inputFactor*SOME_CONST;
	btScalar m_velocityIncrementFactor;// = 1.0f;
	
	bool m_restoreVehicleOrientationIfNotGoodWhenVehicleIsStopped;
	
	bool m_steerLeft;//=false;
	bool m_steerRight;//=false;	
	//endregion
	
	private:
	 //region Forbid bad stuff
	btHinge2Vehicle()	{}
	const btHinge2Vehicle& operator=(const btHinge2Vehicle& V) {}
	//endregion

};


#endif //HINGE2_VEHICLE_H