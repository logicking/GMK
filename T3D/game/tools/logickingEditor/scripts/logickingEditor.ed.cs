//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com
//-----------------------------------------------------------------------------
// Game MechanicsKit Editor
// Written by Dmitry Shevchenko
//-----------------------------------------------------------------------------

//default setting
$pref::GameMechaniksKit::startStopGmkWithMissionEditor = getPrefSetting($pref::GameMechaniksKit::startStopGmkWithMissionEditor, false);
$pref::GameMechaniksKit::askAboutReloadMission = getPrefSetting($pref::GameMechaniksKit::askAboutReloadMission, false);
$pref::GameMechaniksKit::drawLinksMode = getPrefSetting($pref::GameMechaniksKit::drawLinksMode, 1);

function LogickingEditor::onWake(%this)
{
	echo("Waiking GameMechanicksKit editor!!!!!!");
	
	%icons = "noLinksIcon selectedLinksIcon allLinksIcon";    
    %fieldName = getWord(%icons, $pref::GameMechaniksKit::drawLinksMode);
    linksSwitchButton.setBitmap(linksSwitchButton.getFieldValue(%fieldName));
		
	logickingEditorMap.push();
	
	// creating list of available panels
	LogickingEditor.windowsList[0] = LogickingEditorTemplatesList;
	LogickingEditor.windowsList[1] = LogickingEditorFieldEditor;
	LogickingEditor.windowsList[2] = LogickingEditorObjectsList;
	LogickingEditor.windowsList[3] = LogickingEditorFieldInspector;
	
	LogickingEditor.panelsAmount = 4;
	
	$linksList = "";
	%count = MissionGroup.getCount();
	for(%i = 0; %i < %count; %i++)
	{
		%obj = MissionGroup.getObject(%i);
		if(%obj.templateName !$= "")
		    %this.processLinks(%obj);
	}		
	
	if(%this.currentObjects !$= "")
	{
        if(getWordCount(%this.currentObjects) > 1)
        {            
            currentObjectButton.text = "## Group selected ##";    
            currentObjectButton.textLocation = "Center";    
            currentObjectButton.setBitmap("");
        }
        else
        {
            %object = %this.currentObjects;
            if(isObject(%object))
            {
                currentObjectButton.text = %object.getId() @ " : " @ %object.getName();    
                currentObjectButton.textLocation = "Right";    
                currentObjectButton.setBitmap(getCategoryIconByName(%object.getFieldValue(category)) @ "_ico");
            }
            else
                %this.clearCurrentObject();
        }
	}
	else
	    %this.clearCurrentObject();
	
	
	if(currentObjectButton.getText() $= "")
		currentObjectButton.setActive(false);
	
	if(currentTemplateButton.getText() $= "")
		createObjectButton.setActive(false);		
}

function LogickingEditor::clearCurrentObject(%this)
{
    currentObjectButton.setActive(false);
        
    currentObjectButton.text = "";
    currentObjectButton.setBitmap("");    
    %this.currentObjects = "";
}

function LogickingEditor::update(%this)
{
    %delay = 100;
    %this.moveObject(%delay / 1000);
    
    if(%this.active)
    {
        %this.schedule(%delay, update);
    }    
}

// initialization of the editor
function LogickingEditor::onActivated(%this)
{
    if(%this.isActive)
        return;
        
    EditorGui.setEditor(WorldEditorInspectorPlugin);
    EWInspectorWindow.setVisible(0);
    EWTreeWindow.setVisible(0);
        
    %this.isActive = true;
	
	// freeze all simulation running, so we can edit objects while they static
	$freezeSim = true;
	
    EWorldEditor.gameMechanicsMode = true;
    EWorldEditor.showIcons = true;
	ActivatePackage(TemplateFunctions); // package of function for working with game object template
	
	//canvas.pushdialog(LogickingEditor); // editor starting
	EditorGui.add( logicMechanicsEditorPanel );
	//EditorGui.bringToFront( logicMechanicsEditorPanel );    
	logicMechanicsEditorPanel.setVisible(1);
    //logicMechanicsEditorPanel.makeFirstResponder(true);
    
    /*EditorGui.add( LogickingEditor );
	EditorGui.bringToFront( LogickingEditor );    
    logicMechanicsEditorPanel.makeFirstResponder(true);    
	logicMechanicsEditorPanel.setVisible(true);*/
	
	%this.active = true;
	LogickingEditor.update();
	
	%this.initialized = true;
	
	GameMechanics::prepareEditor();
	LogickingEditor.onWake();
}

function LogickingEditor::onDeactivated(%this)
{
    if(!%this.initialized)
        return;
        
    %this.initialized = "";
	//Canvas.popDialog(LogickingEditor);	
	
	EditorGui.remove(logicMechanicsEditorPanel);
	//EditorGui.remove(LogickingEditor);
	
	%this.active = "";
	
	DeactivatePackage(TemplateFunctions);
	
	logickingEditorMap.pop();
	EWorldEditor.gameMechanicsMode = false;
	EWorldEditor.showIcons = false;	
	$scaleState = false;
	$rotateState = false;
	
	%this.isActive = "";
	
	%this.closeAllWindows();
	%this.clearCurrentObject();

	GameMechanics::closeEditor();
}

function LogickingEditor::toggleWindow(%this, %panel)
{
	if(%panel.selected $= "")
	{
	   %panel.selected = true; 
	   canvas.pushdialog(%panel);
	}
	else
	{
	   %panel.selected = ""; 
	   canvas.popdialog(%panel);
	}
}

function LogickingEditor::closeWindow(%this, %panel)
{
    %panel.selected = ""; 
    canvas.popDialog(%panel);
}

function LogickingEditor::closeAllWindows(%this)
{
    for(%i = 0; %i < %this.panelsAmount; %i++)
    {
        if(%this.windowsList[%i].selected)
            %this.closeWindow(%this.windowsList[%i]);
    }
}

function LogickingEditor::showWindow(%this, %panel)
{
    %panel.selected = true; 
    canvas.pushDialog(%panel);
}

function LogickingEditor::selectObject(%this, %object)
{
	EWorldEditor.clearSelection();
	EWorldEditor.selectObject(%object.getId());
	
	%this.setCurrentObject(%object);
}  

function LogickingEditor::deleteObject(%this)
{
    if(!%this.isActive) return;
    
    %this.currentObjects = "";
	//update ObjectList window
	LogickingEditorObjectsList.deleteObjectsFromList();

    if(%this.currentObjects $= "") return;
		
	currentObjectButton.setActive(false);
		
	currentObjectButton.text = "";
	currentObjectButton.setBitmap("");
}  

function LogickingEditor::unselectObject(%this)
{
    if(!%this.pickingMode)
    {
        %this.clearCurrentObject();

        %this.onUnselectObject();
    }
}  

function LogickingEditor::onUnselectObject(%this)
{
    for(%i = 0; %i < %this.panelsAmount; %i++)
    {
        %this.windowsList[%i].onUnselectObject();
    }
}

function LogickingEditor::onStartSelection(%this)
{
    for(%i = 0; %i < %this.panelsAmount; %i++)
    {
        %this.windowsList[%i].onStartSelection();
    }    
    %this.isListSelected = true;
    if(!%this.pickingMode)
        %this.currentObjects = "";
}

function LogickingEditor::onEndSelection(%this)
{
    for(%i = 0; %i < %this.panelsAmount; %i++)
    {
        %this.windowsList[%i].onEndSelection();
    }
    %this.isListSelected = "";
}

function LogickingEditor::setCurrentObject(%this, %object)
{	
	if(!%this.isActive) return;
    
    %object = %object.getId();
    
    if(%this.pickingMode)
    {
        for(%i = 0; %i < %this.panelsAmount; %i++)
        {
            if(%this.windowsList[%i].selected)
                %this.windowsList[%i].onPickObject(%object);
        }
        return;
    }
    else
    {
        %currentObject = getWord(%this.currentObjects, 0);
        if(isObject(%currentObject) && %currentObject == %object)
            return;
         
        currentObjectButton.setActive(true);			        
                
        if(%this.isListSelected !$= "")
        {            
            %this.currentObjects = %this.currentObjects @ %object.getId() @ " ";            
        }
        else
        {
            %this.currentObjects = %object.getId();
            currentObjectButton.text = %object.getId() @ " : " @ %object.getName();    
            currentObjectButton.textLocation = "Right";    
            currentObjectButton.setBitmap(getCategoryIconByName(%object.category) @ "_ico");
        }
        
        if(getWordCount(%this.currentObjects) > 1)
        {
            currentObjectButton.text = "## Group selected ##";    
            currentObjectButton.textLocation = "Center";    
            currentObjectButton.setBitmap("");
        }
        
        for(%i = 0; %i < %this.panelsAmount; %i++)
        {
            %this.windowsList[%i].onSelectObject(%object);
        }
    }	
}  

function LogickingEditor::createObject(%this, %tag)
{
	%object = createObject(%this.currentTemplate, %tag);
	
    EWorldEditor.clearSelection();
	EWorldEditor.selectObject(%object.getId());
	EWorldEditor.dropSelection();
	
	if(%object !$= getWord(%this.currentObjects, 0)) // это я делаю потому, что при выделении некоторых типов объектов (пути, скрипт группы) не вызывается callback onSelect 
	{
	    %this.setCurrentObject(%object);
	}
	
	LogickingEditorFieldEditor.selected = true; 
    canvas.pushdialog(LogickingEditorFieldEditor);
    EWorldEditor.isDirty = true;
}

function LogickingEditor::selectTag(%this)
{    
    if(%this.currentTemplate $= "")
        return;
        
    %n = 0;
    for(%i = 1; true; %i++)
    {
        %n = %i < 10 ? "0" @ %i : %i;
        if(!isObject(%this.currentTemplate @ %n))
            break;
    }
    LogickingEditor.createObject(%this.currentTemplate @ %n);
}

function selectTag()
{
    LogickingEditor.selectTag();
}

function LogickingEditor::processLinks(%this, %object)
{
    %fieldsCount = getFieldsCounter(%object.templateName);	
	
	$linksList = $linksList $= "" ? "" : $linksList;
	%id = %object.getId();
	$linksList[%id] = "";
	
	for(%i = 0; %i < %fieldsCount; %i++)
	{
	    %type = getFieldType(%object.templateName, %i);
	    if(%type $= "code" || %type $= "objectLink")
	    {
	        %field = getFieldName(%object.templateName, %i);
	        %value = %object.getFieldValue(%field);
	        %str = breakToWords(%value, " _.,();");
	        
	        %wordsCount = getWordCount(%str);
	        for(%j = 0; %j < %wordsCount; %j++)
	        {
	            %word = getWord(%str, %j);
	            if(isObject(%word))
	                $linksList[%id] = $linksList[%id] @ %word @ " ";            
	        }
	    }
	}
}

function LogickingEditor::switchDrawLinksMode(%this)
{
    %icons = "noLinksIcon selectedLinksIcon allLinksIcon";    
    $pref::GameMechaniksKit::drawLinksMode++;
    if($pref::GameMechaniksKit::drawLinksMode > 2)
        $pref::GameMechaniksKit::drawLinksMode = 0;
    %fieldName = getWord(%icons, $pref::GameMechaniksKit::drawLinksMode);
    linksSwitchButton.setBitmap(linksSwitchButton.getFieldValue(%fieldName));
}

function LogickingEditor::castRay(%this)
{
    %objectsAmount = EWorldEditor.getSelectionSize();
    if(%objectsAmount == 0)
        return;    
    for(%i = 0; %i < %objectsAmount; %i++)
    {
        %obj = EWorldEditor.getSelectedObject(%i);
        %pos = %obj.getPosition();
        %transform = %obj.getTransform();
        %end = VectorAdd(%pos, "0 0 -20");
        
        %target = ContainerRayCast(%pos, %end, $TypeMasks::InteriorObjectType | $TypeMasks::TerrainObjectType);
        
        if(%target != 0) 
        {
            for(%j = 0; %j < 3; %j++)
            {
                %transform = setWord(%transform, %j, getWord(%target, %j + 1));
            }
            %obj.setTransform(%transform);
			EWorldEditor.updateClientTransforms(%obj);
        }
        else
            EWorldEditor.dropSelection();
    }
}

function LogickingEditor::onKeyboardEvent(%this, %key, %state)
{
    %this.keys[%key] = %state;
}

function LogickingEditor::moveObject(%this, %time)
{
    if(getWord(LogickingEditor.currentObjects, 0) $= "")
        return;
        
    %anglesByButton[forward] = 0;
    %anglesByButton[backward] = 3.1415;
    %anglesByButton[left] = 1.57075;
    %anglesByButton[right] = 4.71225;
			
    %anglesByButton[forwardleft] = 0.785375;
    %anglesByButton[forwardright] = 5.497625;
			
    %anglesByButton[backwardleft] = 2.356125;			
    %anglesByButton[rightbackward] = 3.926875;
    
    %coefByButton[pageup] = getWord(EWorldEditor.GridSize, 2) * 10;
    %coefByButton[pagedown] = -(getWord(EWorldEditor.GridSize, 2) * 10);
    
    %buttons = "";
    for(%i = 0; %i < 4; %i++)
    {
        %buttons = %buttons @ %this.keys[%i];
    }
    %angle = %anglesByButton[%buttons];
    
    %climb = 0;
    for(%i = 4; %i < 6; %i++)
    {
            %climb = %climb + %coefByButton[%this.keys[%i]];
    }
    
    if(%angle $= "" && %climb == 0)
        return;        
        
    %dir = LocalClientConnection.camera.getEyeVector();
    %dir = setWord(%dir, 2, 0); 
    
    %dir = VectorRot(%dir, %angle);
    %speed = getWord(EWorldEditor.GridSize, 0) * 10;
    %speed = %speed * %time;
    %dir = VectorScale(%dir, %speed);
        
    %count = getWordCount(%this.currentObjects);
    for(%i = 0; %i < %count; %i++)
    {
        %currentObject = getWord(%this.currentObjects, %i);
        %pos = %currentObject.getPosition();
        %transform = %currentObject.getTransform();                        
        %pos = VectorAdd(%pos, %dir);
        
        if(%climb != 0)
        {
            %climb = "0 0 " @ %climb;
            %pos = VectorAdd(%pos, %climb);
        }
        
        for(%j = 0; %j < 3; %j++)
        {
            %transform = setWord(%transform, %j, getWord(%pos, %j ));
        }
        
        %currentObject.setTransform(%transform);
    }
}

function LogickingEditor::rotateState(%this)
{
    if(rotateStateButton.state $= "")
    {
        rotateStateButton.state = true;
        $rotateState = true;
        if($scaleState)
        {
            scaleStateButton.state = true;
            scaleStateButton.performClick();
        }
    }    
    else
    {
        rotateStateButton.state = "";
        $rotateState = false;
    }
}

function LogickingEditor::scaleState(%this)
{
    if(scaleStateButton.state $= "")
    {
        scaleStateButton.state = true;
        $scaleState = true;
        if($rotateState)
        {
            rotateStateButton.state = true;
            rotateStateButton.performClick();        
        }
    }
    else
    {
        scaleStateButton.state = "";
        $scaleState = false;
    }
}

function LogickingEditor::switchIcons(%this)
{
    if(EWorldEditor.showIcons)    
    {
        EWorldEditor.showIcons = false;
        iconsButton.setBitmap(iconsButton.switchedOn);
        iconsButton.ToolTip = "Show icons";
    }
    else
    {
        EWorldEditor.showIcons = true;
        iconsButton.setBitmap(iconsButton.switchedOff);
        iconsButton.ToolTip = "Hide icons";
    }
}

function LogickingEditor::moveCameraToObject(%this, %object)
{
    %transform = %object.getTransform();
    LocalClientConnection.camera.setTransform(%transform);    
}

function LogickingEditor::askMoveObjectToCamera(%this, %object)
{
    MessageBoxYesNo( "Change position?", "Do you really want to move object to camera position?", " LogickingEditor.moveObjectToCamera(" @ %object @ "); ");
}

function LogickingEditor::moveObjectToCamera(%this, %object)
{
    %transform = LocalClientConnection.camera.getTransform();
    %object.setTransform(%transform);
    EWorldEditor.updateClientTransforms(%object);
}

function getEditorIcon(%this)
{
    if(%this.category $= "")
        return "";
    %iconPath = getCategoryIconByName(%this.category);
    if(%iconPath $= "")
        error("Wrong icon for category \" " @ %this.category @ " \" object - " @ %this.getId());
    return %iconPath;
}


//----------------------------------------------------------------------------------------------------
function GameMechanics::toggleEditor()
{
 	if(EWorldEditor.gameMechanicsMode == true)
	{
		//LogickingEditor.onClose();
		LogickingEditor.onDeactivated();
	}
	else
	{        
	   LogickingEditor.onActivated();
	}
}

function GameMechanics::hookToMissionEditorStart()
{
	echo("hookToMissionEditorStart");
	if(GameMechanics::startWithMissionEditor())
	{
		GameMechanics::prepareEditor();
		LogickingEditor.onActivated();
	}
}

function GameMechanics::hookToMissionEditorStop()
{
	GameMechanics::closeEditor();
	$GameMechanics::missionReloaded = false;
}

function GameMechanics::hookMissionLoaded()
{
	if(!$GameMechanics::editorPrepared) return;

	// set free camera mode
	commandToServer('AttachCamera', false);
}

//----------------------------------------------------------------------------------------------------
function GameMechanics::prepareEditor()
{
	if($GameMechanics::editorPrepared) return;
	
	if($pref::GameMechaniksKit::askAboutReloadMission)
		GameMechanics::editorMissionReloadQuestion();

	$GameMechanics::editorPrepared = true;
	
	// freeze all simulation running, so we can edit objects while they static
	$freezeSim = true;

	// set free camera mode
	commandToServer('AttachCamera', false);
}

function GameMechanics::closeEditor()
{
	if(!$GameMechanics::editorPrepared) return;
    $GameMechanics::editorPrepared = false;
	$freezeSim = "";
	
	// to make sure that we attached to player
	commandToServer('AttachCamera', true);
}


function GameMechanics::editorMissionReloadQuestion(%dontCheckReloaded, %dontReloadEditor)
{
	if(%dontCheckReloaded != true && $GameMechanics::missionReloaded) return;
	$GameMechanics::missionReloaded = true;
	
	
	%msgText = "Reload mission  \"" @ $Server::MissionFile;
	if(%dontReloadEditor)
	{
		%msgText = %msgText @ "\" and play it?";
		$GameMechanics::editorPrepared = false;
	}
	else
		%msgText = %msgText @ "\" and continue editing it?";
	
	
	if(MessageBox("Reload Mission", %msgText, SaveDontSave, Question) == $MROk)
	{
		if (isObject(Editor)) Editor.close();
		loadMission( $Server::MissionFile, false);

		$GameMechanics::missionReloaded = true;
		
		// recreate and open the editor
		if(%dontReloadEditor != true)
		{
			Editor::create();
			MissionCleanup.add(Editor);
			EditorGui.loadingMission = true;
			Editor.open();
		}
	}
}

//----------------------------------------------------------------------------------------------------		 
function GameMechanics::saveAndReload()
{
	//delete client info first
	if( isObject(ClientMissionCleanup) )
	{
		ClientMissionCleanup.delete();
	}
	clearClientPaths();

	EditorSaveMission();

	if (isObject(Editor)) Editor.close();
	reloadMission();
	MissionCleanup.add(Editor);
}


function GameMechanics::startWithMissionEditor()
{
	return $pref::GameMechaniksKit::startStopGmkWithMissionEditor;
}

function getWinPos()
{
    for(%i = 0; %i < 4; %i++)    
    {
        %window = LogickingEditor.windowsList[%i] @ "Window";
        echo(%window.getName() @ " : " @ %window.getPosition());
    }
}

// For debug purposes. Will list all templates into the console
function listGmkTemplates()
{
	activatePackage(TemplateFunctions);
    %count = getTemplatesAmount();
    for(%i = 0; %i < %count; %i++)
    {
        %templateName = getTemplateName(%i);
        echo("%templateName = ", %templateName);
        %fieldsCount = getFieldsCounter(%templateName);     
        
        for(%j = 0; %j < %fieldsCount; %j++)
        {
            %field = getFieldName(%templateName, %j);
            %group = getFieldGroup(%templateName, %j);
            %hint = getFieldHint(%templateName, %j);
            %type = getFieldType(%templateName, %j);
            %value = getFieldValue(%templateName, %j);
            %additional = getFieldAdditional(%templateName, %j);
            echo("\t ", %field);
            if(%hint !$= "")
                echo("\t\t %hint = ", %hint);
            echo("\t\t %group = ", %group);
            echo("\t\t %type = ", %type);
            echo("\t\t %value = ", %value);
            if(%additional !$= "")
                echo("\t\t %additional = ", %additional);
        }
        echo("------------------------------------------");
    }
	deactivatePackage(TemplateFunctions);
}

function addLE()
{
    EditorGui.add( logicMechanicsEditorPanel );    
    EditorGui.bringToFront( logicMechanicsEditorPanel );    
    logicMechanicsEditorPanel.makeFirstResponder(true);
    //LogickingEditor
}

function LES(%flg)
{
    EditorGui.add( logicMechanicsEditorPanel );
	//EditorGui.bringToFront( logicMechanicsEditorPanel );    
	logicMechanicsEditorPanel.setVisible(1);
}

function LEPS(%flg)
{
    logicMechanicsEditorPanel.setVisible(%flg);
}