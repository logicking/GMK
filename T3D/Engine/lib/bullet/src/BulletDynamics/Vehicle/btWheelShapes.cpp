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
#include "btWheelShapes.h"
#include "BulletCollision/CollisionShapes/btConeShape.h"
#include "BulletCollision/CollisionShapes/btConvexHullShape.h"

btMultiSphereShape* btWheelSimpleShape::Create(const btScalar radius,const btScalar height)	{
	
	const btScalar scaling = height/(radius*2.0f);	
	const btVector3 positions[] = { btVector3(0.f,0.f,0.f)};
	const btScalar radii[] = {	radius };
	const btVector3	localScaling = btVector3(scaling,1.0f,1.0f);						
	const int numSpheres = sizeof(positions)/sizeof(positions[0]);							
	if (numSpheres != sizeof(radii)/sizeof(radii[0])) {
		printf("Error: numPositions!=numRadii in btMultiSphereShape [btWheelSimpleShape::Create(...)]\n");
		return NULL;
	}							
	btMultiSphereShape* shape = new btMultiSphereShape(&positions[0],&radii[0],numSpheres);
	shape->setLocalScaling(localScaling);
		
	return shape;
}

btMultiSphereShape* btWheelShape::Create(const btScalar radius,const btScalar height,const int numSegments,const btScalar _smallSpheresHeightFactor)	{
	//const btScalar height = _height*0.35f;	// Empiric fix
	
	const int numOfSmallSpheresPerCircle = numSegments;	// 12 // Twickable (less = faster, higher = more precise)
	const btScalar smallSpheresHeightFactor = _smallSpheresHeightFactor;//0.95f;	// (0,1) I'd stick to 0.95f (lower values should increase the tyre curvature at the center)
	
	const btScalar scaling = height/(radius*2.0);//height/(radius*2.0);	// correct value: height/(radius*2.0); we don't use it to have a better round tyre surface towards the ground (exceeding a bit the shape height (i.e.width))	
	const btScalar newHeight = radius*2.0;	// When we'll scale it, it will became = height
	
	const int numPositions = 2*numOfSmallSpheresPerCircle+1;	// This is the number of spheres in the btMultiSphereShape
	btAlignedObjectArray<btVector3> positions;positions.resize(numPositions);
	btAlignedObjectArray<btScalar> radii;radii.resize(numPositions);
	
	int i = 0;
	positions[i] = btVector3(0.f,0.f,0.f);
	radii[i++] = radius;
	
	// Small spheres
	const btScalar delta = smallSpheresHeightFactor * radius;	// + smallRadius
	const btScalar smallRadius = newHeight*0.25 < delta*0.5 ? newHeight*0.25 : delta*0.5;
	const btScalar R= delta-smallRadius >= smallRadius ? delta-smallRadius : smallRadius;
	const btScalar h1 = newHeight*0.25*0.75;	// The "correct" value should be newHeight*0.25, but the 0.75 factor increases the tyre curvature at the borders a bit, making it more realistic (TODO: further test this).
	const btScalar h2 = -h1;
	
	for (int t=0;t<numOfSmallSpheresPerCircle;t++)	{
		const btScalar s = R*btSin(2.f*SIMD_PI*(btScalar)t/numOfSmallSpheresPerCircle);
		const btScalar c = R*btCos(2.f*SIMD_PI*(btScalar)t/numOfSmallSpheresPerCircle);
		positions[i] = btVector3(h1,s,c);
		radii[i++] = smallRadius;
		positions[i] = btVector3(h2,c,s);
		radii[i++] = smallRadius;
	}
		
	const btVector3	localScaling = btVector3(scaling,1.0,1.0);						
	const int numSpheres = numPositions;//sizeof(positions)/sizeof(positions[0]);							
	if (numSpheres != radii.size()) {
		printf("Error: numPositions!=numRadii in btMultiSphereShape [btWheelShape::Create(...)]\n");
		return NULL;
	}							
	btMultiSphereShape* shape = new btMultiSphereShape(&positions[0],&radii[0],numSpheres);
	shape->setLocalScaling(localScaling);
	
	return shape;
}

btCompoundShape* btWheelTrainShape::Create(btScalar outerRadius,btScalar totalWidth,btScalar _innerRadius,btScalar _innerWidth)	{
	const btScalar defaultParametersFactor = 0.6f/1.4f;	// inner / outer dimensions when using default params
	btScalar innerRadius(_innerRadius);if (innerRadius<0 || innerRadius>=outerRadius) innerRadius = outerRadius*defaultParametersFactor;
	btScalar innerWidth(_innerWidth);if (innerWidth<0 || innerWidth>=totalWidth) innerWidth = totalWidth*defaultParametersFactor;
	//printf("outerRadius = %10.2f\ntotalWidth = %10.2f\nInner Width = %10.2f\nInner Radius = %10.2f\n",outerRadius,totalWidth,innerWidth,innerRadius);	
	const btScalar outerWidth=(totalWidth - innerWidth)*0.5f;
	
	// If the 2 apicies of the cones don't come out of the side they're facing we can use 2 cones and a cylinder:
		const btScalar deltaRadius = outerRadius-innerRadius; // DR : OW = OR : TW | TW = OW * OR / DR 
		const btScalar coneHeight =  outerWidth * outerRadius / deltaRadius;
		if (totalWidth<coneHeight) totalWidth = coneHeight;	// Yes, we override the totalWidth argument passed by the user to fulfil the condition below. 
															// P.S. It's surely possible to delete this requirement, but this code is old, and I'm very lazy... do it better yourself!
		//if (totalWidth>=coneHeight) {
			btCylinderShape* centralShape = new btCylinderShapeX(btVector3(totalWidth*0.5,innerRadius,innerRadius));//(btVector3(innerWidth*0.5,innerRadius,innerRadius));	// We replace innerWidth with totalWidth to make it bigger and overlapping
			btConeShape* coneShape = new btConeShape(outerRadius,coneHeight);			
			// Compound Shape
    		btCompoundShape* wheelShape = new btCompoundShape();
			wheelShape->addChildShape(btTransform::getIdentity(),centralShape);
			const btQuaternion Q1(btVector3(0.f,0.f,1.f),-SIMD_HALF_PI);
			wheelShape->addChildShape(btTransform(Q1,btVector3(-totalWidth*0.5+coneHeight*0.5,0,0)),coneShape);
			const btQuaternion Q2(btVector3(0.f,0.f,1.f),SIMD_HALF_PI);
			wheelShape->addChildShape(btTransform(Q2,btVector3(+totalWidth*0.5-coneHeight*0.5,0,0)),coneShape);			
		
			return wheelShape;
		//}
}


btCompoundShape* btWheelTorusShape::Create(const btVector3& brickFullDimensions,int numBricks,int numBricksToFormA360Circle,bool useConvexHullShape,const btVector3& COMoffset,btScalar deltaLocalAABBXToFillGaps){
		if (numBricks<0) numBricks=1;
		if (numBricksToFormA360Circle<0) numBricksToFormA360Circle=numBricks;
		if (numBricksToFormA360Circle<3) numBricksToFormA360Circle = 3;
		
		const btVector3 brickHalfDimensions = brickFullDimensions*btScalar(0.5);
		const btScalar h=brickFullDimensions.y(); const btScalar hh= h*0.5f;
		const btScalar l=brickFullDimensions.x(); const btScalar hl= l*0.5f; 
		const btScalar z=brickFullDimensions.z(); const btScalar hz= z*0.5f;  

		const btScalar elementOffsetAngle = 2.0f*SIMD_PI/(btScalar)numBricksToFormA360Circle;
		const btScalar floorOffsetAngleBase = elementOffsetAngle * 0.5f;
		const btScalar perimeter = l*numBricksToFormA360Circle;
		btScalar radius = perimeter/(2.0f*SIMD_PI);
		if (radius<hz) radius=hz;
		if (deltaLocalAABBXToFillGaps<0) deltaLocalAABBXToFillGaps = 0;//l*0.01f;
		btScalar collisionMargin(0.0f);
		
		btCollisionShape* shape = NULL;
		if (!useConvexHullShape) shape = new btBoxShape(btVector3(brickHalfDimensions.x()+deltaLocalAABBXToFillGaps,brickHalfDimensions.y(),brickHalfDimensions.z()));
		else	{
			const btScalar deltaHL = fabs(hz * btTan(floorOffsetAngleBase));					
			const btScalar maxHL = hl + deltaHL + collisionMargin + deltaLocalAABBXToFillGaps;		
			const btScalar minHL = hl - deltaHL + collisionMargin + deltaLocalAABBXToFillGaps;

			btVector3 points[8]={
				btVector3(maxHL,hh,hz),
				btVector3(-maxHL,hh,hz),
				btVector3(minHL,hh,-hz),
				btVector3(-minHL,hh,-hz),

				btVector3(maxHL,-hh,hz),
				btVector3(-maxHL,-hh,hz),
				btVector3(minHL,-hh,-hz),
				btVector3(-minHL,-hh,-hz)				
			};
			//btConvexHullShape* chs = new btConvexHullShape(&points.x(),sizeof(points)/sizeof(points[0]));
			// /*
			btConvexHullShape* chs = new btConvexHullShape();
			for (int t=0;t<sizeof(points)/sizeof(points[0]);t++) chs->addPoint(points[t]);
			// */
			shape = chs;
			collisionMargin = 0.f;//2.0f * shape->getMargin();	// ...so when using the convex hull shape we keep it into considerations (even if decreasing it probably helps)
		}
		if (!shape) return NULL;								
		
		btCompoundShape* csh = new btCompoundShape();
		
		btTransform T=btTransform::getIdentity();
		T.setOrigin(-COMoffset);//+T.getBasis().getColumn(1)*(hh+collisionMargin*0.5f));	
		btTransform T2;
		{
				const btScalar floorOffsetAngle = numBricks==numBricksToFormA360Circle ? 0 : (numBricks%2==0 ? floorOffsetAngleBase : 0.0f);
				const int start = -numBricks/2;
				const int end = numBricks/2 + (numBricks%2==1 ? 1 : 0);				
				for (int t=start;t<end;t++)	{
					T2=T;						
					T2.setRotation(btQuaternion(btVector3(0.f,1.f,0.f),(btScalar)t * elementOffsetAngle + floorOffsetAngle));//assignAY( t * elementOffsetAngle+ floorOffsetAngle );
					T2.setOrigin(T2.getOrigin()+T2.getBasis().getColumn(2)*radius);							
					// Body Creation:
					csh->addChildShape(T2,shape);
				}
		}	
		//printf("Torus shape: radius=%10.2f,  brickHalfDimensions(%10.2f,%10.2f,%10.2f),  elementOffsetAngle=%10.2f,  numBricks=%i\n",radius,brickHalfDimensions.x(),brickHalfDimensions.y(),brickHalfDimensions.z(),elementOffsetAngle*180.0f/SIMD_PI,numBricks);
		return csh;
}

