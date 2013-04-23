//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// SoundPlayer is an object, that plays random sound
//-----------------------------------------------------------------------------
datablock MissionMarkerData(SoundPlayerData)
{
   category = "Misc";
   shapeFile = "core/art/shapes/octahedron.dts";
};
   
function SoundPlayerData::create()
{
	%obj = new MissionMarker()
	{
		dataBlock = SoundPlayerData;
		class = "SoundPlayer";
	};
	return %obj;
}

function SoundPlayerData::onAdd(%this, %obj)
{
	%obj.prepareSound();
	%obj.signal("onSpawn");
}

function SoundPlayerData::onRemove(%this, %obj)
{
	%obj.clearSound();
}

function SoundPlayer::prepareSound(%this)
{
	%this.descriptionWork = %this.description;
	if(!isObject(%this.descriptionWork))
	{
		%this.descriptionWork = new SFXDescription() {
			volume   = %this.volume;
			isLooping= %this.loop;
			is3D     = %this.is3d;
			ReferenceDistance= %this.refDist;
			MaxDistance= %this.maxDist;
			channel = $SimAudioType;
		};
		echo("DescCreated ", %this.descriptionWork);
		if(isObject(MissionCleanup))
		    MissionCleanup.add(%this.descriptionWork);
	}

	%this.sfxProfileWork = %this.sfxProfile;
	if(!isObject(%this.sfxProfileWork))
	{
		%this.sfxProfileWork = new SFXProfile() {
			filename = %this.filename;
			description = %this.descriptionWork;
			preload = %this.preload;
		};
		echo("ProfileCreated ", %this.sfxProfileWork);
		if(isObject(MissionCleanup))
		    MissionCleanup.add(%this.sfxProfileWork);		
	}


	if(isObject(%this.sfxProfileWork))
	{
		%pos = %this.getPosition();		
		%this.sfxSource = sfxCreateSource(%this.sfxProfileWork, getWord(%pos, 0), getWord(%pos, 1), getWord(%pos, 2));
	}
	else
		echo("Warning! ", %this.getName(), ". Unable to create profile for sound");
}

function SoundPlayer::clearSound(%this)
{
	if(isObject(%this.sfxSource))
	{
		%this.stop();
		%this.sfxSource.delete();
	}
	
	if(isObject(%this.descriptionWork))
		%this.descriptionWork.delete();
	
	if(isObject(%this.sfxProfileWork))
		%this.sfxProfileWork.delete();

	%this.sfxProfileWork = "";
	%this.sfxSource = "";
	%this.descriptionWork = "";
}

function SoundPlayer::play(%this)
{
	if(isObject(%this.sfxSource))
	{
		if(%this.volume !$= "")
			%this.sfxSource.setVolume(%this.volume);
		%this.sfxSource.play();
		
	}
}

function SoundPlayer::stop(%this)
{
	if(isObject(%this.sfxSource))
	{
		%this.sfxSource.stop();
	}
}

function SoundPlayer::pause(%this)
{
	if(isObject(%this.sfxSource))
	{
		%this.sfxSource.pause();
	}
}

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------

activatePackage(TemplateFunctions);
registerTemplate("SoundPlayer", "Misc", "  SoundPlayerData::create(); ");
//setTemplateField("SoundPlayer", "filename", "", "file", "", "", $soundFilesMask);
setTemplateSoundField("SoundPlayer", "filename", "", "", "");
setTemplateField("SoundPlayer", "volume", "1.0");
setTemplateField("SoundPlayer", "loop", "false");
setTemplateField("SoundPlayer", "is3d", "true");
setTemplateField("SoundPlayer", "refDist", "20");
setTemplateField("SoundPlayer", "maxDist", "100");
setTemplateField("SoundPlayer", "preload", "true");
setTemplateField("SoundPlayer", "description", "");
setTemplateField("SoundPlayer", "sfxProfile", "");

// actions
setTemplateAction("SoundPlayer", "prepareSound");
setTemplateAction("SoundPlayer", "clearSound");
setTemplateAction("SoundPlayer", "play");
setTemplateAction("SoundPlayer", "stop");
setTemplateAction("SoundPlayer", "pause");

deactivatePackage(TemplateFunctions);