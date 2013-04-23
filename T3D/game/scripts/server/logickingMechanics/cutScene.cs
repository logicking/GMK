//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

// Cut scene functional

new ActionMap(CutSceneActionMap);

CutSceneActionMap.bindCmd(keyboard, "space", " $currentPlayingScene.stop(); ", "");

datablock MissionMarkerData(CutSceneData)
{
   category = "Misc";
   shapeFile = "core/art/shapes/octahedron.dts";
};

function CutScene::create()
{
    %scene = new MissionMarker() {
        dataBlock = CutSceneData;
        class = "CutScene";
	};
	return %scene;
}

function CutSceneData::onAdd(%this, %obj)
{
    %obj.soundsCount = %obj.soundsCount $= "" ? 0 : %obj.soundsCount;
    %obj.chunksCount = %obj.chunksCount $= "" ? 0 : %obj.chunksCount;
    %obj.pathsCount = %obj.pathsCount $= "" ? 0 : %obj.pathsCount;
    %obj.prepareSounds();
}

function CutSceneData::onRemove(%this, %obj)
{
    %obj.clearSounds();
}

function CutScene::play(%this)
{    
    %this.player = LocalClientConnection.getControlObject();   
        
    %this.currentCameraPath = 0; 
    
    %this.createCamera();
    %this.playCamera();
    %this.processChunks();
    %this.playSounds();
    
    if(!LogickingEditor.isActive) 
        %this.signal("onPlay");
    
    $currentPlayingScene = %this;
    CutSceneActionMap.push();
}

function CutScene::createCamera(%this)
{
    %this.camera = new PathCamera() {
        dataBlock = CutSceneCam;
    };
    MissionCleanup.add( %this.camera  );
    %this.camera.scene = %this;        
}

function CutScene::destroyCamera(%this)
{
    %this.camera.delete();
    %this.camera = "";
}

function CutScene::playCamera(%this)
{
    %path = %this.getCameraPath();        
    %marker = %this.getCameraPosition();
    if(isObject(%path) && %path.getCount() > 0)
    {                  
        %node = %path.getObject(0);     
        %this.camera.setTransform(%node.getTransform());   
        %this.camera.reset(0);   
        %this.camera.followPath(%path);  
        %this.camera.onEndPath = %this @ ".onEndPath(true); ";
	}
    else if(isObject(%marker))
    {
        %this.camera.pushNode(%marker);
        %this.camera.popFront();
    }
    else
    {
        %this.stop(true);
    }
}

function CutScene::prepareSounds(%this)
{
    %this.clearSounds();
    %count = %this.soundsCount;
    
    if(%count $= "" || %count == 0) return;
    
    if(!isObject(%this.description))
    {
        %this.description = new SFXDescription()
                {
                   volume = 1.0;
                   isLooping = false;
                   is3D = false;
                   channel = $SimAudioType;
                };
        MissionCleanup.add(%this.description);
    }
        
    
    for(%i = 0; %i < %count; %i++)
    {
        %filePath = %this.sounds[%i, 0];
        if(%filePath $= "") continue;
        if(isObject(cutSceneSFXProfile))
            cutSceneSFXProfile.delete();
        
        %sfxProfile = new SFXProfile(cutSceneSFXProfile) {
			filename = %filePath;
			description = %this.description;
			preload = true;
		};
		
		if(!isObject(%sfxProfile))
		{
		    echo("Warning! ", %filePath, ". Unable to create profile for sound");
		    continue;
		}
		else
		    MissionCleanup.add(%sfxProfile);
		
        %this.sfxSource[%i] = sfxCreateSource(%sfxProfile, 0, 0, 0);                
    }
}

function CutScene::clearSounds(%this)
{
    %count = %this.soundsCount;
    
    if(%count $= "" || %count == 0) return;
    for(%i = 0; %i < %count; %i++)
    {
        %sfxSource = %this.sfxSource[%i];
        if(isObject(%sfxSource))
        {
            %sfxSource.stop();
            %sfxSource.delete();
            %this.sfxSource[%i] = "";
        }
    }
}

function CutScene::stopSounds(%this)
{
    %count = %this.soundsCount;
    
    if(%count $= "" || %count == 0) return;
    for(%i = 0; %i < %count; %i++)
    {
        %sfxSource = %this.sfxSource[%i];
        if(isObject(%sfxSource))
        {
            %sfxSource.stop();
        }
    }
}

function CutScene::playSounds(%this)
{
    %count = %this.soundsCount;
    
    if(%count $= "" || %count == 0) return;
    
    for(%i = 0; %i < %count; %i++)
    {
        if(isObject(%this.sfxSource[%i]))
        {
            if(%this.sounds[%i, 1] !$= "" && %this.sounds[%i, 1] > 0)
                %this.schedule(%this.sounds[%i, 1], "playSound", %i);
            else
                %this.playSound(%i);
        }
    }
}

function CutScene::playSound(%this, %idx)
{
    %sfxSource = %this.sfxSource[%idx];
    if(isObject(%sfxSource))
        %sfxSource.play();
}

function CutScene::processChunks(%this)
{
    %count = %this.chunksCount;
    
    if(%count $= "" || %count == 0) return;
    
    for(%i = 0; %i < %count; %i++)
    {
        %code = %this.chunks[%i, 0];
        %timeShift = %this.chunks[%i, 1];
        if(%code !$= "")
        {
            if(%timeShift $= "" || %timeShift == 0)
                %this.doChunk(%code);
            else            
                %this.schedule(%timeShift, "doChunk", %code);
        }
    }
}

function CutScene::doChunk(%this, %chunk)
{
    Helpers::evalWithThisObj(%chunk, %this);
}

function CutScene::getCurrentPath(%this)
{
    %path = %this.getFieldValue("paths" @ %this.currentCameraPath @ "_0");
    return %path;
}

function CutScene::getCameraPath(%this)
{    
    while((%this.getCurrentPath().isEnabled() == 0) && %this.currentCameraPath < %this.pathsCount)
    {
        %this.currentCameraPath++;
    }
    return %this.getCurrentPath();
}

function CutScene::getCameraPosition(%this)
{
    return %this.getId() @ "/" @ %this.getName() @ "CameraPosition";
}

function CutScene::onEndPath(%this)
{
    if(%this.pathsCount !$= "" && %this.currentCameraPath < %this.pathsCount) 
    {
        %this.currentCameraPath++;
        %this.playCamera();
    }
    else
        %this.stop(true);
}

function CutScene::stop(%this, %onEndCamera)
{    
    $currentPlayingScene = "";
    CutSceneActionMap.pop();   
    if(!LogickingEditor.isActive) 
        %this.signal("onStop");   
    if(%onEndCamera $= "")
    {
        %this.camera.onEndPath = "";
        %this.camera.stop();        
    }
    else
        LocalClientConnection.setControlObject(%this.player);  
        
    %this.camera = "";
    %this.player = "";
    
    %this.stopSounds();
}

function askPlayScene(%scene)
{
    MessageBoxYesNo( "Play current scene?", "Do you really want to play current cutScene? This may cause some changes im mission file.", " doPlayScene(" @ %scene @ "); ");
}

function doPlayScene(%scene)
{
    LogickingEditor.closeAllWindows(); 
    LogickingEditorFieldEditor.currentScene = %scene; 
    %scene.play();    
}

ActivatePackage(TemplateFunctions);
registerTemplate("CutScene", "CutScenes", " CutScene::create(); ");
setTemplateCommand("CutScene", "Play scene", "Play current cut scene", " askPlayScene(%this); ");
// actions
setTemplateAction("CutScene", "play", " play scene");
setTemplateAction("CutScene", "stop", " stop's scene");
// events
setTemplateEvent("CutScene", "onPlay", "echo(\"onPlay\");"); 
setTemplateEvent("CutScene", "onStop", "echo(\"onStop\");"); 
// param groups
setTemplateParamsGroup("CutScene", "Chunks", "code|Code|Time shift", "chunks");
setTemplateParamsGroup("CutScene", "Sounds", "sound|File path|Time shift", "sounds", $soundFilesMask);
setTemplateParamsGroup("CutScene", "Paths", "objectLink|Paths", "paths", "Path");
DeactivatePackage(TemplateFunctions);