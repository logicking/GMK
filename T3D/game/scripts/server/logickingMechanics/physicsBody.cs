//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Physics bodies
//-----------------------------------------------------------------------------

// Hook into the mission editor.
function RigidBodyData::create(%data)
{
   // The mission editor invokes this method when it wants to create
   // an object of the given datablock type.
   %obj = new RigidBody() {
      dataBlock = %data;
	  scale = %data.scale;
   };
   return %obj;
}

function SoftBodyData::create(%data)
{
   %obj = new SoftBody() {
      dataBlock = %data;
	  scale = %data.scale;
   };
   return %obj;
}


function PhysicsBodyData::onContact(%this, %obj, %pos, %vel, %slideOrCollide)
{
	//echo(" RigidBodyData::onContact ", %vel SPC %slideOrCollide);
	if(%this.collisionSoundsCount > 0 || %this.slideSoundsCount > 0)
	{
		//we're sliding
		if(%this.slidingThreshold !$="" && %this.slidingThreshold > %slideOrCollide)
		{
			if(%this.slideSoundsCount > 0)
			{
				%snd = %this.slideSound[getRandom(%this.slideSoundsCount - 1)];
				%obj.playAudio(0, %snd);
				//%obj.slideSnd = sfxPlayOnce(%snd, getWord(%pos, 0), getWord(%pos, 1), getWord(%pos, 2));
			}
		}
		//we're colliding
		else
		{
			if(%this.collisionSoundsCount > 0)
			{
				//echo("Collide ", %obj SPC %vel);
				%snd = %this.collisionSound[getRandom(%this.collisionSoundsCount - 1)];
				%obj.playAudio(0, %snd);
				//Calc volume from velocity.
				/*
				%vol = mClamp(%vel / 6, 0.2, 1);
				if(isObject(%obj.collideSnd) && %vol >= %obj.collideSndVol)
					%obj.collideSnd.stop();
				%obj.collideSnd = sfxPlayOnce(%snd, getWord(%pos, 0), getWord(%pos, 1), getWord(%pos, 2));
				%obj.collideSndVol = %vol;
				%obj.collideSnd.setVolume(%vol);
				*/
			}
		}
	}
}


//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
activatePackage(TemplateFunctions);
registerTemplate("AbstractRigidBody", "AbstractsPhysics", "");
setTemplateAction("AbstractRigidBody", "setEnabled", "(%isEnabled)");
deactivatePackage(TemplateFunctions);
