//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

// trace dist in meters
$Player::useTraceDist = 2;


function Player::scheduledUpdate(%this)
{
	// additional update for client sided player
	if(isObject(%this.client) && %this == %this.client.getControlObject())
	{		
		%this.checkObjectsForUse();
	}	
	%this.schedule(150, "scheduledUpdate");
}

function Player::checkObjectsForUse(%this)
{
    %eyeVec = %this.getEyeVector();

    %startPos = VectorAdd(%this.getEyePoint(), VectorScale(%eyeVec, 0.2));
    %endPos = VectorAdd(%startPos, VectorScale(%eyeVec, $Player::useTraceDist));    

    %this.useTarget = ContainerRayCast(%startPos, %endPos, $TypeMasks::ShapeBaseObjectType, %this);
    %this.useTarget = getWord(%this.useTarget, 0);
    
    if(%this.useTarget != 0 && %this.useTarget.getFieldValue("usable") == true)
    {
        commandToClient(%this.client, 'updateUseIcon', true);
		return %this.useTarget;
    }
    else
    {
		commandToClient(%this.client, 'updateUseIcon', false);
    }
}

function serverCmdUseObj(%client, %buttonState, %additional)
{    
	%player = %client.player;
    // doing an additional ray cast check on the server to prevent possibility of cheating
	%target = %player.checkObjectsForUse();
    if(isObject(%target))
    {
        %target.use(%player, %buttonState, %additional);
    }
}