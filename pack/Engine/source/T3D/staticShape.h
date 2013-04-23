//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

#ifndef _STATICSHAPE_H_
#define _STATICSHAPE_H_

#ifndef _SHAPEBASE_H_
#include "T3D/shapeBase.h"
#endif

//.logicking - torque physics support
class PhysicsBody;
//----------------------------------------------------------------------------

struct StaticShapeData: public ShapeBaseData {
   typedef ShapeBaseData Parent;

  public:
   StaticShapeData();

   bool  noIndividualDamage;
   S32   dynamicTypeField;
   bool  isShielded;
   F32   energyPerDamagePoint;

   //
   DECLARE_CONOBJECT(StaticShapeData);
   static void initPersistFields();
   virtual void packData(BitStream* stream);
   virtual void unpackData(BitStream* stream);
};


//----------------------------------------------------------------------------

class StaticShape: public ShapeBase
{
   typedef ShapeBase Parent;

   StaticShapeData*  mDataBlock;
   bool              mPowered;

   void onUnmount(ShapeBase* obj,S32 node);

   //.logicking
   PhysicsBody *mPhysicsRep;
protected:
   enum MaskBits {
      PositionMask = Parent::NextFreeMask,	  
	  //.logicking
	  PhysicsMask = Parent::NextFreeMask << 1,	  
      NextFreeMask = Parent::NextFreeMask << 2
   };

public:
   DECLARE_CONOBJECT(StaticShape);

   StaticShape();
   ~StaticShape();

   bool onAdd();
   void onRemove();
   bool onNewDataBlock(GameBaseData *dptr, bool reload);

   void processTick(const Move *move);
   void interpolateTick(F32 delta);
   void setTransform(const MatrixF &mat);

   U32  packUpdate  (NetConnection *conn, U32 mask, BitStream *stream);
   void unpackUpdate(NetConnection *conn,           BitStream *stream);

   // power
   void setPowered(bool power)      {mPowered = power;}
   bool isPowered()                 {return(mPowered);}

   static void initPersistFields();   
   //.logicking
   void updatePhysics();
};


#endif
