//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Path Camera
//-----------------------------------------------------------------------------

datablock PathCameraData(CutSceneCam)
{
   mode = "";
};

function CutSceneCam::onNode(%this,%camera,%node)
{
    if( %camera.path.isLooping )
    {
        if( %node == %camera.loopNode - 1 )
        {
            %numNodesInPath = %camera.path.getCount();
            for( %i = 1; %i < %numNodesInPath; %i ++ )
                %camera.pushNode( %camera.path.getObject( %i ) );
            %camera.pushNode( %camera.path.getObject( 0 ) );
        }
        else if( %node == %camera.loopNode )
        {
            %numNodesInPath = %camera.path.getCount();
            for( %i = 0; %i < %numNodesInPath; %i ++ )
                %camera.popFront();
        }
    }
    else
    {    
        %path = %camera.path;   
        %nodeObject = %path.getObject(%node);                    
        if(!LogickingEditor.isActive)
            %nodeObject.signal("onEnter", %camera);
        if(%node == %path.getCount() - 1)
        {
            if(isObject(%nodeObject) && %nodeObject.pauseTime !$= "")
            {
                %this.schedule(%nodeObject.pauseTime, "stop", %camera);
            }        
            else
                %this.stop(%camera);
        }
        else
            if(isObject(%nodeObject) && %nodeObject.pauseTime !$= "")
            {
                %camera.pause();
                %camera.schedule(%nodeObject.pauseTime, "resume");
            } 
        %this.orientCamera(%camera, %nodeObject);
    }
}

function CutSceneCam::start(%this,%camera, %path)
{
    %camera.controlObject = LocalClientConnection.getControlObject();  
    LocalClientConnection.setControlObject(%camera);     
    %this.orientCamera(%camera, %path.getObject(0));
}

function CutSceneCam::stop(%this,%camera)
{    
    LocalClientConnection.setControlObject(%camera.controlObject);    
    %camera.controlObject = "";  
    %camera.signal("onEndPath");
}

function CutSceneCam::orientCamera(%this, %camera, %node)
{        
    if(isObject(%node.targetObject) || %node.offset !$= "")
        %camera.setAim(%node.targetObject, %node.offset);
    if(%node.lookDir !$= "")
        %camera.setLookDir(%node.lookDir);
}

function PathCamera::followPath(%this,%path)
{       
    %this.path = %path;
    if (!(%this.speed = %path.speed))
        %this.speed = 100;
   
    %this.pushPath(%path);   
    %this.popFront();
   
    %node = %path.getObject(0);        
	%this.getDataBlock().onNode(%this, 0); 
    if(%path.getCount() == 1)
    {              
        %node.pauseTime = %node.pauseTime $= "" ? 0 : %node.pauseTime;       
        %this.schedule(%node.pauseTime, "signal", "onEndPath"); 
    }
    else
        if(%node.pauseTime !$= "")
        {
            %this.pause();
            %this.schedule(%node.pauseTime, "resume");
        }
    
      
    if( %path.isLooping )
    {
        %this.loopNode = %path.getCount();
        %this.pushNode( %path.getObject( 0 ) );
    }
    
    %datablock = %this.getDataBlock();
    if(isObject(%datablock) && %datablock.isMethod("start"))
        %datablock.start(%this, %path);
}

function PathCamera::stop(%this)
{
    %datablock = %this.getDataBlock();
    if(isObject(%datablock) && %datablock.isMethod("stop"))
        %datablock.stop(%this);
}

function PathCamera::pushPath(%this,%path)
{
   for (%i = 0; %i < %path.getCount(); %i++)
      %this.pushNode(%path.getObject(%i));
}

function PathCamera::pushNode(%this,%node)
{
   if (!(%speed = %node.speed))
      %speed = %this.speed;
   if ((%type = %node.type) $= "")
      %type = "Normal";
   if ((%smoothing = %node.smoothing) $= "") 
      %smoothing = "Linear";
    if (%node.targetObject $= "") 
      %node.targetObject = -1; 
   %this.pushBack(%node.getTransform(),%speed,%type,%smoothing);
}