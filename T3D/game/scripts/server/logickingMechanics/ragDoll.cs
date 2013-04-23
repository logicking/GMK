//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//---------------------------------------------------------------------------------------------
function RagDollData::create(%block)
{   
	// The mission editor invokes this method when it wants to create   
	// an object of the given datablock type.   
	%obj = new RagDoll()   {    dataBlock = %block;   };   
	return %obj;
}


function createRagDoll(%ragdollData, %obj)
{
   %ragDoll_obj = new RagDoll()
            {
					position = "0 0 0";
					rotation = "1 0 0 0";
					dataBlock = %ragdollData;
				};
				
   %ragDoll_obj.initRagDoll(%obj);
   
   %force = VectorSub(%obj.getPosition(), %obj.damagePos);
   %force = setWord(%force,2,0);
   %force = VectorNormalize(%force);
   %force = VectorScale(%force,1500);
   %ragDoll_obj.applyImpulse(%obj.damagePos,%force);
   //%ragDoll_obj.applyImpulse(%obj.damagePos, "1500 0 0");

   %ragDoll_obj.schedule($CorpseTimeoutValue - 1000, "startFade", 1000, 0, true);
   %ragDoll_obj.schedule($CorpseTimeoutValue, "delete");

   return %ragDoll_obj;
}


//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------
activatePackage(TemplateFunctions);
registerTemplate("AbstractRagDollBody", "AbstractsPhysics", "");
setTemplateAction("AbstractRagDollBody", "setEnabled", "(%isEnabled)");
deactivatePackage(TemplateFunctions);


//test
function cro()
{
   new AIBot(orc) {
      dataBlock = "SpaceOrcBotData";
      position = "530 660 256.41";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      canSave = "1";
      canSaveDynamicFields = "1";
      Enabled = "1";
         blockMovement = "false";
         category = "AI";
         editorIcon = "tools/LogickingEditor/images/AI";
         guardCloseDist = "3";
         guardFarDist = "5";
         Health = "100";
         invBlasterAmmo = "3000";
         Item = "HealthPatch";
         perceptionEnabled = "false";
         templateName = "SpaceOrcBot";
         viewDist = "40";
   };
}
function ite()
{
 new Item(ite) {
			position = "530 660 256.41";
			rotation = "1 0 0 0";
			dataBlock = "HealthPatch";
			rotate = true;
		};
}
		
function en()
{
	orc.setEnemy($playerForAi);
}

function sh()
{
	orc.setImageTrigger(0,true);
	orc.setImageTrigger(0,false);
}

function de()
{
	orc.delete();
}

function rag()
{
		new RagDoll( rd)
            {
					position = "530 660 256.41";
					rotation = "1 0 0 0";
					dataBlock = SpaceOrcRagDoll;
		};
}

function bar()
{
	   new StaticShape(bar) {
      receiveSunLight = "1";
      receiveLMLighting = "1";
      useCustomAmbientLighting = "0";
      customAmbientLighting = "0 0 0 1";
      dataBlock = "SteelBarrel";
      position =  "530 660 256.41";
      rotation = "1 0 0 0";
      scale = "1 1 1";
      canSaveDynamicFields = "1";
      class = "Breakable";
      className = "Breakable";
      Enabled = "1";
         category = "Breakables";
         Collision = "0";
         editorIcon = "tools/missionEditor/images/LogickingEditor/Breakable";
         health = "60";
         healthBound = "50";
         templateName = "SteelBarrel";
   };
}

//test ai
function pauseGame(%val)
{
	if ((%val) || (%val $= ""))
	{
		if ($timeScale != 0)
		{
			$timeScale = 0;
		}
		else
			$timeScale = 1;
	}
}
GlobalActionMap.bind(keyboard, pause, pauseGame);
