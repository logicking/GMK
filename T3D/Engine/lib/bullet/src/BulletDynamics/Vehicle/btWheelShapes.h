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
#ifndef BTWHEEL_SHAPES_H
#define BTWHEEL_SHAPES_H

#include "BulletCollision/CollisionShapes/btMultiSphereShape.h"
#include "BulletCollision/CollisionShapes/btCompoundShape.h"
#include "BulletCollision/CollisionShapes/btCylinderShape.h"


/** A collision shape to model a convex tyre shape.
    The axis of rotation (wheel height) is in the X direction.
	This is just a wrapper around btCylinderShapeX, so that I can pass just 2 args to its ctr
	(my laziness rules...).
*/
class btWheelCylinderShape : public btCylinderShapeX {
	protected:
	
	public:
	btWheelCylinderShape(const btScalar radius,const btScalar height) 
	: btCylinderShapeX(btVector3(height*0.5f,radius,radius))
	{}
	virtual ~btWheelCylinderShape() {}
};

/** A collision shape to model a convex tyre shape.
    The axis of rotation (wheel height) is in the X direction.
   	This is just a single scaled sphere!
	The advantage is that there are no "segmented circles" inside it, and that it's very light.
	Warning: Please read at the bottom of this page.
*/
class btWheelSimpleShape : public btMultiSphereShape {
	protected:
	
	public:
	btWheelSimpleShape(const btScalar radius,const btScalar height) 
	: btMultiSphereShape(*Create(radius,height))
	{}
	virtual ~btWheelSimpleShape() {}

	virtual const char*	getName()const {return "btWheelSimpleShape";}

	private:
	
	static btMultiSphereShape* Create(const btScalar radius,const btScalar height);	
};

/** A collision shape to model a convex tyre shape.
    The axis of rotation (wheel height) is in the X direction.
	This is a more complex btMultiSphereShape (that looks like a real wheel)
	The main "circular section" in the center isn't segmented, but the two slightly smaller "circular sections" on the sides are "segmented".
	if _smallSpheresHeightFactor == 1.0f, the small "circular sections" at the sides have the same radius as the bigger one at the center.	    
	Warning: The shape might be a bit bigger than needed (To be fixed?).
	Warning2: Please read at the bottom of this page.
*/
class btWheelShape : public btMultiSphereShape {
	protected:
	
	public:
	btWheelShape(const btScalar radius,const btScalar height,const int numSegments=16,const btScalar _smallSpheresHeightFactor=0.95f) 
	: btMultiSphereShape(*Create(radius,height,numSegments,_smallSpheresHeightFactor))
	{}
	virtual ~btWheelShape() {}
	virtual const char*	getName()const {return "btWheelShape";}

	private:
	
	static btMultiSphereShape* Create(const btScalar radius,const btScalar height,const int numSegments=16,const btScalar _smallSpheresHeightFactor=0.95f);
};

/** A collision shape to model a simple train wheel that can be used to "ride" narrow box shapes.
    The axis of rotation (named wheel width or wheel height) is in the X direction.
	This is a btCompoundShape made with a btCylinderX at the center plus 2 cones at the sides with their base outside.
	|\ - /|
	| | | |
	|/ - \|
	Because of this the total width must be longer than the height of one cone (so that its vertex does not come out of the other side).
	That's why the ctr takes an argument called: totWidthThatCanBeIncreased.
	P.S. It's surely possible to delete this requirement, but this code is old, and I'm very lazy... do it better yourself!
*/
class btWheelTrainShape : public btCompoundShape {
	protected:
	
	public:
	/** totRadius = total radius of the wheel
	    totWidthThatCanBeIncreased = total width of the wheel
	*/
	btWheelTrainShape(const btScalar totRadius,const btScalar totWidthThatCanBeIncreased,const btScalar innerRadius=btScalar(-1.f),const btScalar innerWidth=btScalar(-1.f)) 
	: btCompoundShape(*Create(totRadius,totWidthThatCanBeIncreased,innerRadius,innerWidth))
	{}
	virtual ~btWheelTrainShape() {}
	virtual const char*	getName()const {return "btWheelTrainShape";}

	private:
	
	static btCompoundShape* Create(btScalar outerRadius,btScalar totalWidth,btScalar _innerRadius,btScalar _innerWidth);
};

/** A simple torus shape (a cylinder with an hole in it), made up of "bricks".
    Warning: The axis of rotation (named wheel width or wheel height) is in the Y direction.
    This shape is not intended to be used inside vehicles.
    deltaLocalAABBXToFillGaps is just a value (that must be manually adjusted every time) that can be used to close gaps (if present)
    between bricks (use it with care).
    Warning: this shape was created in a hurry just for this demo; it should be rewritten better.
*/
class btWheelTorusShape : public btCompoundShape {
	protected:
	
	public:
	btWheelTorusShape(const btVector3& brickFullDimensions,int numBricks=8,int numBricksToFormA360Circle=-1,bool useConvexHullShape=false,const btVector3& COMoffset=btVector3(0.f,0.f,0.f),btScalar deltaLocalAABBXToFillGaps=-1.0f) 
	: btCompoundShape(*Create(brickFullDimensions,numBricks,numBricksToFormA360Circle,useConvexHullShape,COMoffset,deltaLocalAABBXToFillGaps))
	{}
	virtual ~btWheelTorusShape() {}
	virtual const char*	getName()const {return "btWheelTorusShape";}

	private:
	
	static btCompoundShape* Create(const btVector3& brickFullDimensions,int numBricks=8,int numBricksToFormA360Circle=-1,bool useConvexHullShape=false,const btVector3& COMoffset=btVector3(0.f,0.f,0.f),btScalar deltaLocalAABBXToFillGaps=-1.0f);
};


// FOOT NOTE ABOUT THE BULLET DEBUG DRAWER (at the time of writing):
/*
I'm not very familiar with the code of the Bullet debug drawer, and I got no idea on how it works, 
but the wheel shapes are not drawn correctly.

On a closer view, I've found out that this is the code used by Bullet to draw a btMultiSphereShape in GL_ShapeDrawer.cpp:
				for (int i = multiSphereShape->getSphereCount()-1; i>=0;i--)
				{
					btSphereShape sc(multiSphereShape->getSphereRadius(i));
					childTransform.setOrigin(multiSphereShape->getSpherePosition(i));
					btScalar childMat[16];
					childTransform.getOpenGLMatrix(childMat);
					drawOpenGL(childMat,&sc,color,debugMode,worldBoundsMin,worldBoundsMax);
				}
There are two issues about it:
1) The collision shape local scaling (maybe of all shapes) seems to be ignored (maybe a general glScalef(...) call above it could be enough).
2) (This just an option) IMO drawing spheres is not the best way to draw a btMultiSphereShape: it should be far better to reuse the convex hull shape engine, and adding
	for each sphere a bunch of points that represent it (i.e. equally spaced points on the surface or so).				

In any case to have a better look at the wheel shapes (in particular btWheelShape), only raytracing can show the details fully
(I'm going to include a raytrace screenshot somewhere...).
*/

#endif //BTWHEEL_SHAPES_H
