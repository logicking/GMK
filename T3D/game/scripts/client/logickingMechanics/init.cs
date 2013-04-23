//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

moveMap.bind(keyboard, "e", useObject);

function reloadMission(%missionName)
{
	if(%missionName $= "") 
	{
		if($Server::MissionFile !$= "")
			schedule( 0, 0, loadMission, $Server::MissionFile);
		else
			error("Wrong mission name");

		return;
	}
	else
	{
		%missionName = expandFileName("~/data/missions/" @ %missionName);
		%missionName = makeRelativePath(%missionName, getWorkingDirectory());
		schedule( 0, 0, loadMission, %missionName);
	}
}


// Used to call "use" method
function useObject(%flg)
{    
    commandToServer('useObj', %flg);
}

function clientCmdUpdateUseIcon(%isUsable)
{
	if(%isUsable)
	{
        crossHair.setVisible(false);
        useCrossHair.setVisible(true);
	}
	else
	{
        crossHair.setVisible(true);
        useCrossHair.setVisible(false);
	}
} 


function clientCmdUpdateGameScore(%score)
{
   GameScoreText.setText("Orcs killed: " @ %score);
} 

function clientCmdPlayerDied(%msg)
{
  if ( $Server::ServerType $= "SinglePlayer" )
  {
      MessageBoxYesNo( "ORCS RULE!!!", %msg, "reloadMission();", "disconnect();");
   }
}

addMessageCallback( 'MsgDoorLocked', handleDoorLocked );


function GameMessageText::hideText()
{
	GameMessageText.needToHide = GameMessageText.needToHide - 1;
	if(GameMessageText.needToHide == 0)
		GameMessageText.setVisible(false);
	
}

function handleDoorLocked(%msgType, %msgString)
{
   GameMessageText.setVisible(true);
   GameMessageText.setText(detag(%msgString));
   GameMessageText.needToHide = GameMessageText.needToHide $="" ? 0 : GameMessageText.needToHide;
   GameMessageText.needToHide = GameMessageText.needToHide + 1;
   GameMessageText.schedule(4000, hideText);
}


function onReadInfo()
{
	gotoWebPage("http://www.logicking.com/index.php?page=gameMechanicsKit");
}