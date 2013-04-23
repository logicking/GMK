//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// for Game Mechanics Editor
//-----------------------------------------------------------------------------

function Path::create()
{
    %path = new Path()
    {
    };
    
    return %path;
}

ActivatePackage(TemplateFunctions);	// opening package with template functions
registerTemplate("Path", "Paths", " Path::create(); ");
setTemplateField("Path", "isLooping", "0", "bool", "", "");
setTemplateField("Path", "speed", "20", "string", "Misc", "");
/////
setTemplateCommand("Path", "Fly path", "Fly current path", " LogickingEditorFieldEditor.flyPath(); ");

setTemplateInternalObjects("Path", "Markers", " return createObject(Marker, \"name\"); ", "Markers", "Marker");
DeactivatePackage(TemplateFunctions); // close package with template functions

function GmkMarker::create()
{
    %marker = new Marker()
    {
		gmkEditorVisible = true;
		dataBlock = WayPointMarker;
    };
    
    return %marker;
}

ActivatePackage(TemplateFunctions);	// opening package with template functions
registerTemplate("Marker", "Paths", " GmkMarker::create();");
setTemplateField("Marker", "pauseTime", "0", "string", "", "");
setTemplateField("Marker", "speed", "", "string", "", "");
setTemplateField("Marker", "lookDir", "0 0 0", "vector", "", "");
setTemplateField("Marker", "offset", "0 0 0", "vector", "", "");
setTemplateField("Marker", "targetObject", "", "objectLink", "", "", "");

setTemplateEvent("Marker", "onEnter", "echo(\"onEnter\");"); 

DeactivatePackage(TemplateFunctions); // close package with template functions