//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------
// A helper functions and utilities
//-----------------------------------------------------------------------------

function Helpers::evalWithArgs(%callbackString, %arg1, %arg2, %arg3, %arg4, %arg5)
{
    %retValue = "";
	if(strlen(%callbackString) != 0)
	{
		eval("function helpersLocalFunction(%arg1, %arg2, %arg3, %arg4, %arg5) {" @ %callbackString @ "}");
		%retValue = helpersLocalFunction(%arg1, %arg2, %arg3, %arg4, %arg5);
		$helpersLocalFunction = 0;
	}
	return %retValue;
}

function Helpers::evalWithThisObj(%callbackString, %this, %obj, %checkEvaluation)
{
    %retValue = "";
    %checkRetValue = "";
	if(strlen(%callbackString) != 0)
	{	    
	    %chunk = "function helpersLocalFunction(%this, %obj) {" @ %callbackString @ "}";
	    if(%checkEvaluation)
	        %chunk = %chunk @ " return 1;";
		%checkRetValue = eval(%chunk);
		%retValue = helpersLocalFunction(%this, %obj);
		$helpersLocalFunction = 0;
	}
	if(%checkEvaluation)
	    return %checkRetValue;
	else
	    return %retValue;
}


function Helpers::scheduleWithThisObj(%callbackString, %this, %obj)
{
	if(strlen(%callbackString) != 0)
	{
		eval("function helpersLocalFunction(%this, %obj) {" @ %callbackString @ "}");
		helpersLocalFunction(%this, %obj);
		$helpersLocalFunction = 0;
	}
}