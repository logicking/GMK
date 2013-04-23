//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

package logickingMechanicsFunctions
{
    
    //Mission download hooks
    function serverCmdMissionStartPhase3Ack(%client, %seq)
    {
        // Make sure to ignore calls from a previous mission load
        if(%seq != $missionSequence || !$MissionRunning)
            return;
        if(%client.currentPhase != 2)
            return;
        //Call the parent function      
        parent::serverCmdMissionStartPhase3Ack(%client, %seq);

        GameMechanics::hookMissionLoaded();
    }
   
    function Armor::onAdd(%this, %obj)
    {
        parent::onAdd(%this, %obj);
        
        %obj.schedule(500, "scheduledUpdate");         
    }
/*
    function GameCore::spawnPlayer(%game, %this, %spawnPoint)
    {
        if(%spawnPoint $= "")
		  {
		   	%spawnPoint = pickPlayerSpawnPoint($Game::DefaultPlayerSpawnGroups);
		  }

        parent::spawnPlayer(%game,%this, %spawnPoint);
    
        addToTeam(%this.player, $PLAYERS_TEAM);
	
        updateGameScore(0);
        $playerForAi = %this.player;
        %this.player.playerControlled = true;
    }
    
    function GameCore::loadOut(%game, %player)
    {
        %player.setInventory(BlasterGun, 1);
        %player.setInventory(BlasterAmmo,%player.maxInventory(BlasterAmmo));
        %player.mountImage(GreenBlasterGunImage, 0);
    }
	*/
};
	
//-----------------------------------------------------------------------------
// Activate Package.
//-----------------------------------------------------------------------------
activatePackage(logickingMechanicsFunctions);

function updateGameScore(%score)
{
	for( %clientIndex = 0; %clientIndex < ClientGroup.getCount(); %clientIndex++ ) 
	{
		%cl = ClientGroup.getObject( %clientIndex );
		commandToClient(%cl, 'updateGameScore', %score);
	}
}

function gameOver(%client)
{
	commandToClient(%client, 'playerDied', "Orcs've got you! And you have killed " @ KilledOrcsCounter.value @ " of them! Repeat?");
}


function spawnOrcs(%count)
{
	for(%i = 0; %i < %count; %i++)
	{
		if(isObject($playerForAi))
		{
			$playerForAi.schedule(%i * 500, "spawnSingleOrc", %i);
		}
	}
}


// To diperse bot around the garage
$dispersalPos[0] = "537.707 681.202 256.409";
$dispersalPos[1] = "537.236 691.797 256.422";
$dispersalPos[2] = "481.353 700.924 256.403";
$dispersalPos[3] = "508.871 660.917 256.421";

function Player::spawnSingleOrc(%this, %count)
{
	%block = "SpaceOrcBotData";
	%template = "SpaceOrcBot";
	
	//one in 3 are Elf
	if(getRandom(3) == 0)
	{
		%block = "ElfBotData";
		%template = "ElfBot";
	}
	%bot = new AIBot(/*aiOrc @ %count*/) {
	      canSaveDynamicFields = "1";
	      Enabled = "1";
	      position = "506.822 732.968 256.4";
	      rotation = "1 0 0 0";
	      scale = "1 1 1";
	      dataBlock = %block;
	      collision = "0";
	         category = "AI";
	         editorIcon = "tools/logickingEditor/images/AI";
	         health = "100";
	         invCrossbowAmmo = "50";
	         Item = "HealthPatch";
	         onDeath = "AliveOrcsCounter.dec(); KilledOrcsCounter.inc();";
			 onSpawn = "AliveOrcsCounter.inc();";
			 onAlert = " %this.allowTacticalMovement(false); %this.followPath(OrcPath0 @ getRandom(2), $Path::TO_TARGET, 1, -1, -1);";
			 onPathEnd = " %this.allowTacticalMovement(true); ";
	         templateName = %template;
	   };
	   %bot.setEnemy($playerForAi);
}

function con()
{
    Canvas.setContent(JoinServerGui);
}

//////////////test functions/////////////////
function cr()
{
	new RigidShape(rsh) {
      canSaveDynamicFields = "1";
      Enabled = "1";
      position = "355 570 145";
      rotation = "1 0 0 0";
      scale = "0.5 0.5 0.5";
//      scale = "1 1 1";
      dataBlock = "BouncingBoulder";
      collision = "0";
   };
}

datablock SFXDescription(AudioLoud3d)
{
   volume   = 1.0;
   isLooping= false;

   is3D     = true;
   ReferenceDistance= 35.0;
   MaxDistance= 100.0;
   channel = $SimAudioType;
};

datablock SFXDescription(AudioLoudLooping3d)
{
   volume   = 1.0;
   isLooping= true;

   is3D     = true;
   ReferenceDistance= 35.0;
   MaxDistance= 100.0;
   channel = $SimAudioType;
};

function serverCmdAttachCamera(%client, %isAttaching)
{
   if ($Server::TestCheats || $Server::ServerType $= "SinglePlayer")
   {
      %control = %client.getControlObject();
      if (!%isAttaching)
	  {
		  if (%control == %client.player)
	      {
	         %control = %client.camera;
	         %control.mode = toggleCameraFly;
	      }
	  }
      else
      {
         %control = %client.player;
         %control.mode = observerFly;
      }
      %client.setControlObject(%control);
   }
}