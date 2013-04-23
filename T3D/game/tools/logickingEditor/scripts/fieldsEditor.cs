//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com
//-----------------------------------------------------------------------------

// field name sign size
LogickingEditorFieldEditor.fieldSize = "80 18";
LogickingEditorFieldEditor.actionFieldSize = "235 18";
// field value sign size
LogickingEditorFieldEditor.valueSize = "230 18";
LogickingEditorFieldEditor.smallValueSize = "40 18";
LogickingEditorFieldEditor.valueListSize = "195 18";
// parameter value button size
LogickingEditorFieldEditor.buttonSize = "30 18";
LogickingEditorFieldEditor.actionButtonSize = "90 20";
// checkBox size
LogickingEditorFieldEditor.boolSize = "50 18";

LogickingEditorFieldEditor.smallButtonSize = "18 18";

LogickingEditorFieldEditor.stackSize = "260 18";
LogickingEditorFieldEditor.fullSizeControlSize = "260 18";
// Column 1 size
LogickingEditorFieldEditor.column1size = "185 18";
// Column 2 size
LogickingEditorFieldEditor.column2size = "80 18";

function LogickingEditorFieldEditor::onWake(%this)
{
   echo("On Wake");
    %this.currentObjects = %this.currentObjects $= "" ? getWord(LogickingEditor.currentObjects, 0) : %this.currentObjects;
    %this.createFields();
    
    if(!isObject(%this.soundDescription))
    {
        %this.soundDescription = new SFXDescription(fieldsEditorDescription)
            {
               volume = 1.0;
               isLooping = false;
               is3D = false;
               channel = $SimAudioType;
            };
        MissionCleanup.add(%this.soundDescription);
     }

      //TestCam object is for "Fly Path" button functionality of fly paths
     if(!isObject(%this.testCam))
     {
         %this.testCam = new PathCamera() {
            dataBlock = CutSceneCam;
        };
        MissionCleanup.add( %this.testCam  ); 
     }
}

function LogickingEditorFieldEditor::clearStackList(%this)
{
   %this.stacksListItems[counter] = %this.stacksListItems[counter] $= "" ? 0 : %this.stacksListItems[counter];
   echo("clearStackList ", %this.stacksListItems[counter]);
   for(%i = 0; %i < %this.stacksListItems[counter]; %i++)
   {
      %stack = %this.stacksListItems[%i];
      if(isObject(%stack))
         %stack.clear();
      %this.stacksList[%this.stacksListItemCaptions[%i]] = "";
   }
   %this.stacksListItems[counter] = 0;
}


function LogickingEditorFieldEditor::getStack(%this, %caption)
{
    %stack = %this.stacksList[%caption];
    
    if(!isObject(%stack))
    {
       %stack = %this.createStack(%caption);
       echo("Create Stack Caption", %caption);
        
       %this.stacksListItems[counter] = %this.stacksListItems[counter] $= "" ? 0 : %this.stacksListItems[counter];
       %counter = %this.stacksListItems[counter];
       %this.stacksListItems[%counter] = %stack;
       %this.stacksListItemCaptions[%counter] = %caption;
       %this.stacksListItems[counter]++;
    }
    
    return %stack;
}

function LogickingEditorFieldEditor::createStack(%this, %caption)
{
    %rollOut = createDataControl("rollOut", "0 0", "260 50");
    %rollOut.caption = %caption;
    
    %this.addControl(%rollOut);
    fieldEditorStack.addGuiControl(%rollOut);
    
    %stack = createDataControl("stack", "2 22", %this.stackSize);
    %this.stacksList[%caption] = %stack;
    %this.addControl(%stack);
    %rollOut.addGuiControl(%stack);
    
    %stack.rollOut = %rollOut;
    
    return %stack;
}

// Groups of parameters editing
function LogickingEditorFieldEditor::createGroupEditor(%this, %object, %fieldIndex)
{
    %groupName = getFieldName(%object.templateName, %fieldIndex);		
    %value = getFieldValue(%object.templateName, %fieldIndex);
    %hint = getFieldHint(%object.templateName, %fieldIndex);
    %additional = getFieldAdditional(%object.templateName, %fieldIndex);
    
    breakToWordsA(%value, "|");
    for(%i = 0; %i < $breakToWordsAReturnBuf[counter]; %i++)
    {
        %value[%i] = $breakToWordsAReturnBuf[%i];
    }
    clearBreakToWordsBuf();
    %type = %value[0];
		
    %parentStack = %this.getStack(%groupName);
    %parentStack.setName(%groupName @ "Group");
    %stack = createDataControl("stack", "0 0", %this.stackSize);
    %stack.StackingType = "Horizontal";
    %this.addControl(%stack);
                
    // creation of table's header and separators
    %text = createDataControl("text", "0 0", %this.column1size, "LogicMechanicsTextBoldCenterProfile");
    %text.setText(%value[1]);
    %stack.addGuiControl(%text);
    %this.addControl(%text);
    
    %text = createDataControl("text", "0 0", %this.column2size, "LogicMechanicsTextBoldLeftProfile");
    %text.setText(%value[2]);
    %stack.addGuiControl(%text);
    %this.addControl(%text);    
    %parentStack.addGuiControl(%stack);
    
    %text = createDataControl("text", "0 0", %this.fullSizeControlSize, "LogicMechanicsTextBoldCenterProfile");
    %text.setText("----------------------------------------------------------------------------------");
    %parentStack.addGuiControl(%text);
    %this.addControl(%text);
    
    // panel for adding new field for editing
    %stack = createDataControl("stack", "0 0", %this.stackSize);
    %stack.StackingType = "Horizontal";
    %stack.setName("add" @ %groupName @ "GroupPanel");
    %this.addControl(%stack);
    
    %text = createDataControl("text", "0 0", %this.fullSizeControlSize);
    %text.setText("");
    %stack.addGuiControl(%text);
    %this.addControl(%text);
    
    %button = createDataControl("icon", "0 0", %this.smallButtonSize);    
    %this.reduceGuiControlSize(%text, %button);        
    %button.setBitmap("tools/gui/images/iconAdd.png");
    %button.Command = " LogickingEditorFieldEditor.addClearEditGroupPanel(" @ %object @ ", " @ %groupName @ "); ";
    %stack.addGuiControl(%button);
    %this.addControl(%button);    
    %parentStack.addGuiControl(%stack); 
    
    %this.inspectGroup(%object, %groupName, %type);
    
    %parentStack.rollOut.sizeToContents();   
}

function LogickingEditorFieldEditor::inspectGroup(%this, %object, %groupName)
{
    %stack = %groupName @ "Group";
    %this.clearStack(%stack);              
    %count = %object.getFieldValue( %groupName @ "Count");
    
    if(%count $= "" || %count == 0) return;
    
    for(%i = 0; %i < %count; %i++)
    {
        %param1 = %object.getFieldValue(%groupName @ %i @ "_0");
        %param2 = %object.getFieldValue(%groupName @ %i @ "_1");
        if(%param1 $= "") continue;
        
        %this.addEditGroupPanel(%object, %groupName, %i, %param1, %param2);
    } 
    %stack.rollOut.sizeToContents();  
}

function LogickingEditorFieldEditor::addClearEditGroupPanel(%this, %object, %groupName, %type)
{
    %count = %object.getFieldValue( %groupName @ "Count");
    %this.addEditGroupPanel(%object, %groupName, %count, "", 0);    
    %object.setFieldValue( %groupName @ "Count", %count + 1);
}

function LogickingEditorFieldEditor::addEditGroupPanel(%this, %object, %groupName, %fieldIdx, %textValue, %text2Value)
{
    // this function can be enhanced. Currently it works only with two parameters
    %index = getFieldIndex(%object.templatename, %groupName);
    %value = getFieldValue(%object.templateName, %index);    
    // in the %value field there are type of the main field and headers of the columns, separator is '|' symbol.
    breakToWordsA(%value, "|");
    %counter = $breakToWordsAReturnBuf[counter];
    for(%i = 0; %i < %counter; %i++)
    {
        %value[%i] = $breakToWordsAReturnBuf[%i];
    }
    clearBreakToWordsBuf();
    %type = %value[0];
    %additional = getFieldAdditional(%object.templateName, %index);

    %stack = createDataControl("stack", "0 0", %this.stackSize);
    %stack.StackingType = "Horizontal";
    
    %this.addControlByType(%object, %stack, %groupName @ %fieldIdx @ "_0", %type, %textValue, "", "", %additional);
    
    %text = %stack.getObject(0);
    // adding additional editing field if needed
    if(%counter > 2)
    {
        %text2Value = %text2Value $= "" ? 0 : %text2Value;
        %text2 = createDataControl("editorTextEdit", "0 0", %this.smallValueSize);
        %text2.text = %text2Value;
        %text2.fieldName = %groupName @ %fieldIdx @ "_1";
        %text2.AltCommand = " LogickingEditorFieldEditor.applyFieldValueFromEdit($ThisControl, " @ %groupName @ %fieldIdx @ "_1); ";
        %stack.addGuiControl(%text2);
        %this.addControl(%text2);
        %this.reduceGuiControlSize(%text, %text2);        
    }
    
    // buttons of movement items inside the list
    %button = createDataControl("icon", "0 0", %this.smallButtonSize);    
    %button.setBitmap("tools/LogickingEditor/images/GUI/moveObjectUp.png");
    %button.command = " LogickingEditorFieldEditor.moveFieldInGroup(" @ %object @ ", " @ %groupName @ ", " @ %fieldIdx @ ", \"" @ %textValue @ "\", \"" @ %text2Value @ "\", -1); ";
    %button.ToolTip = "Move object up in list";
    %stack.addGuiControl(%button);
    %this.reduceGuiControlSize(%text, %button);   
    
    %button = createDataControl("icon", "0 0", %this.smallButtonSize);    
    %button.setBitmap("tools/LogickingEditor/images/GUI/moveObjectDown.png");
    %button.command = " LogickingEditorFieldEditor.moveFieldInGroup("  @ %object @ ", " @ %groupName @ ", " @ %fieldIdx @ ", \"" @ %textValue @ "\", \"" @ %text2Value @ "\", 1); ";
    %button.ToolTip = "Move object down in list";
    %stack.addGuiControl(%button);
    %this.reduceGuiControlSize(%text, %button);  
    
    // Remove row button
    %button = createDataControl("icon", "0 0", %this.smallButtonSize);    
    %button.setBitmap("tools/gui/images/iconDelete.png");
    %button.command = " LogickingEditorFieldEditor.removeEditGroup(" @ %object @ ", " @ %groupName @ ", " @ %fieldIdx @ "); ";
    %stack.addGuiControl(%button);
    %this.reduceGuiControlSize(%text, %button);        
    
    %mainStack = %groupName @ "Group";
    %mainStack.addGuiControl(%stack);    
    %addPanel = "add" @ %groupName @ "GroupPanel";
    %mainStack.pushToBack(%addPanel);
    %mainStack.rollOut.sizeToContents();    
}

// Change position inside of a group
function LogickingEditorFieldEditor::moveFieldInGroup(%this, %object, %groupName, %fieldIdx, %value1, %value2, %sign)
{
    if(%fieldIdx == 0 && %sign == -1) return;
    
    %nextIndex = %fieldIdx + %sign;
    
    %param1 = %object.getFieldValue(%groupName @ %nextIndex @ "_0");
    %param2 = %object.getFieldValue(%groupName @ %nextIndex @ "_1");
	
	if(%param1 $= "" && %param2 $= "") return;
    
    %object.setFieldValue(%groupName @ %nextIndex @ "_0", %value1);
    %object.setFieldValue(%groupName @ %nextIndex @ "_1", %value2);
    
    %object.setFieldValue(%groupName @ %fieldIdx @ "_0", %param1);
    %object.setFieldValue(%groupName @ %fieldIdx @ "_1", %param2);
    
    EWorldEditor.isDirty = true;
    
    %this.inspectGroup(%object, %groupName);
}

// Remove field from the list
function LogickingEditorFieldEditor::removeEditGroup(%this, %object, %groupName, %fieldIdx)
{            
    %count = %object.getFieldValue( %groupName @ "Count");
    for(%i = %fieldIdx; %i < %count - 1; %i++)
    {
        %param1 = %object.getFieldValue( %groupName @ %i + 1 @ "_0");
        %object.setFieldValue( %groupName @ %i @ "_0", %param1 );
        %param2 = %object.getFieldValue( %groupName @ %i + 1 @ "_1");
        %object.setFieldValue( %groupName @ %i @ "_1", %param2 );
    }
    %object.setFieldValue( %groupName @ "Count", %count - 1);
    %this.inspectGroup(%object, %groupName);    
}

// Clearance of fields' stack
function LogickingEditorFieldEditor::clearStack(%this, %stackGroup, %startIdx)
{
    %count = %stackGroup.getCount();
    %startIdx = %startIdx $= "" ? 2 : %startIdx;
    
    for(%i = %count - 2; %i >= %startIdx; %i--)
    {
        %stack = %stackGroup.getObject(%i);
        if(isObject(%stack))
        {
           %stackGroup.remove(%stack);
		   // defered delete, because clearStack will try to delete button that evokes itself
           //%stack.schedule(0, "delete");
        }
    }
}

// Creation of child object with predefined code(chunks)
function LogickingEditorFieldEditor::createInternalObjectsEditor(%this, %object, %fieldIndex)
{	
    %field = getFieldName(%object.templateName, %fieldIndex);
    %parentStack = %this.getStack(%field);
    %parentStack.setName(%object.getName() @ "internalObjectsStack");
        
    // panel of new item add 
    %stack = createDataControl("stack", "0 0", %this.stackSize);
    %stack.StackingType = "Horizontal";
    %stack.setName("addInternalObjectPanel");
    %this.addControl(%stack);
    
    %text = createDataControl("text", "0 0", %this.fullSizeControlSize);
    %text.setText("");
    %stack.addGuiControl(%text);
    %this.addControl(%text);
    
    %button = createDataControl("icon", "0 0", %this.smallButtonSize);    
    %this.reduceGuiControlSize(%text, %button);      
    %button.setBitmap("tools/gui/images/iconAdd.png");
    %button.Command = " LogickingEditorFieldEditor.createInternalObject(" @ %object @ ", " @ %fieldIndex @ "); ";
    %button.toolTip = %hint;
    %stack.addGuiControl(%button);
    %this.addControl(%button);    
    %parentStack.addGuiControl(%stack); 
    
    %this.inspectInternalObjects(%object);
    
    %parentStack.rollOut.sizeToContents();   
}

function LogickingEditorFieldEditor::createInternalObject(%this, %parentObject, %fieldIndex)
{        
    %field = getFieldName(%parentObject.templateName, %fieldIndex);    
    %creationChunk = getFieldValue(%parentObject.templateName, %fieldIndex);		
    %hint = getFieldHint(%parentObject.templateName, %fieldIndex);
    %nameMask = getFieldAdditional(%parentObject.templateName, %fieldIndex);
    %nameMask = %nameMask $= "" ? %field : %nameMask;
    %objectName = %parentObject.getName() @ %nameMask;
    
    // child object creation
    %childObject = eval(%creationChunk);    
    %childObject.nameMask = %nameMask;
    if(!isObject(%childObject))
    {
        error("Error!! Can't create object by given chunk: \"", %creationChunk, "\"");
        return;
    }
    // moving new object to parent's namespace
    %parentObject.add(%childObject);
    %childObject.setName(%objectName @ "_" @ %parentObject.getCount());        
    
    LogickingEditor.moveObjectToCamera(%childObject);
    
    LogickingEditor.selectObject(%parentObject);
    
    %this.inspectInternalObjects(%parentObject);
}

function LogickingEditorFieldEditor::inspectInternalObjects(%this, %parentObject)
{
    %count = %parentObject.getCount();
    
    %this.clearStack(%parentObject.getName() @ "internalObjectsStack", 0);
    
    for(%i = 0; %i < %count; %i++)
    {
        %object = %parentObject.getObject(%i);
        if(!isObject(%object)) continue;
        
        %this.addInternalObjectPanel(%parentObject, %object);
    }
}

function LogickingEditorFieldEditor::addInternalObjectPanel(%this, %parentObject, %childObject)
{
    
    %stack = createDataControl("stack", "0 0", %this.stackSize);
    %stack.StackingType = "Horizontal";
    
    %childObjectName = %childObject.getName();
    
    // selection button of an object 
    %text = createDataControl("button", "0 0", %this.valueSize);
    %text.text = %childObjectName;
    %text.Command = " LogickingEditor.selectObject(" @ %childObject @ ");";
    %stack.addGuiControl(%text);
    %this.addControl(%text);    
    
    // buttons of camera movement to object's position and otherwise
    %manipulationButton = createDataControl("button", "0 0", %this.buttonSize);
    %stack.addGuiControl(%manipulationButton);
    %this.addControl(%manipulationButton);
    %manipulationButton.setText("...");
    %this.reduceGuiControlSize(%text, %manipulationButton);   
    %manipulationButton.Command = " LogickingEditorFieldEditor.showInternaiObjectManipulationButtons(" @ %manipulationButton @ "); ";
    %manipulationButton.ToolTip = "Show object manipulation buttons";                    
    
    // moving button to the top of the list
    %button = createDataControl("button", "0 0", %this.buttonSize);
    %stack.addGuiControl(%button);
    %this.addControl(%button);
    %button.setText("Up");
    %button.Command = " LogickingEditorFieldEditor.pushInternalObjectUp(" @ %parentObject @ ", " @ %childObject @ "); ";
    %button.ToolTip = "Bring object to front";                    
    
    // moving camera to the object's position
    %button = createDataControl("icon", "0 0", %this.smallButtonSize);    
    //%button.setBitmap("tools/LogickingEditor/images/GUI/toObjectPos.png");
    %button.commandTemp = " LogickingEditor.moveCameraToObject(" @ %childObject @ "); ";
    %button.ToolTipTemp = "Move camera to objects position";
    %stack.addGuiControl(%button);
    %this.reduceGuiControlSize(%text, %button);   
    %manipulationButton.toObj = %button;
    
    // moving object to camera position
    %button = createDataControl("icon", "0 0", %this.smallButtonSize);    
    //%button.setBitmap("tools/LogickingEditor/images/GUI/toCameraPos.png");
    %button.commandTemp = " LogickingEditor.askMoveObjectToCamera(" @ %childObject @ "); ";
    %button.ToolTipTemp = "Place object to camera position";
    %stack.addGuiControl(%button);    
    %this.reduceGuiControlSize(%text, %button);   
    %manipulationButton.toCam = %button;
        
    // delete of an object
    %button = createDataControl("icon", "0 0", %this.smallButtonSize);        
    %button.setBitmap("tools/gui/images/iconDelete.png");
    %button.command = " LogickingEditorFieldEditor.removeInternalObject(" @ %parentObject @ ", " @ %childObject @ "); ";
    %button.ToolTip = "Delete current object";
    %stack.addGuiControl(%button);
    %this.reduceGuiControlSize(%text, %button);        
    
    %mainStack = %parentObject.getName() @ "internalObjectsStack";
    %mainStack.addGuiControl(%stack);    
    %mainStack.pushToBack(addInternalObjectPanel);
    %mainStack.rollOut.sizeToContents();    
}

function LogickingEditorFieldEditor::showInternaiObjectManipulationButtons(%this, %button)
{
    if(%this.selectedManipulationButton !$= "")
    {
        %toCam = %this.selectedManipulationButton.toCam;
        %toObj = %this.selectedManipulationButton.toObj;
        %toCam.setBitmap("");
        %toObj.setBitmap("");
        %toCam.command = "";
        %toObj.command = "";
        %toCam.ToolTip = "";
        %toObj.ToolTip = "";        
    }
    
    %this.selectedManipulationButton = %button;
    
    %button.toObj.setBitmap("tools/LogickingEditor/images/GUI/toObjectPos.png");
    %button.toCam.setBitmap("tools/LogickingEditor/images/GUI/toCameraPos.png");
    %button.toCam.command = %button.toCam.commandTemp;
    %button.toObj.command = %button.toObj.commandTemp;
    %button.toCam.ToolTip = %button.toCam.ToolTipTemp;
    %button.toObj.ToolTip = %button.toObj.ToolTipTemp;    
}

function LogickingEditorFieldEditor::removeInternalObject(%this, %parentObject, %childObject)
{
    if(!isObject(%parentObject)) return;
    if(!isObject(%childObject) || !%parentObject.isMember(%childObject)) return;
    
    %parentObject.remove(%childObject);
    %childObject.schedule(0, "delete");
    %this.inspectInternalObjects(%parentObject);
}

function LogickingEditorFieldEditor::pushInternalObjectUp(%this, %parentObject, %childObject)
{
    if(!isObject(%parentObject)) return;
    if(!isObject(%childObject) || !%parentObject.isMember(%childObject)) return;
    
    %parentObject.bringToFront(%childObject);
    %this.inspectInternalObjects(%parentObject);
}
///////////////////////////////////////

// reduce of first element's width to second's element width
function LogickingEditorFieldEditor::reduceGuiControlSize(%this, %text, %control)
{
    %textExtent = %text.getExtent();
    %textWidth = getWord(%textExtent, 0);
    %textHeight = getWord(%textExtent, 1); 
    %controlExtent = %control.getExtent();
    %text.setExtent(%textWidth - getWord(%controlExtent, 0), %textHeight);
}

function LogickingEditorFieldEditor::addControl(%this, %control)
{
    %this.guiControls[counter] = %this.guiControls[counter] $= "" ? 0 : %this.guiControls[counter];
    %counter = %this.guiControls[counter];
    %this.guiControls[%counter] = %control;
    %this.guiControls[counter]++;
}

function LogickingEditorFieldEditor::addTextEdit(%this, %stack, %field, %value, %buttonCommand, %hint, %additionalControls)
{
    %obj = getWord(%this.currentObjects, 0);    
    %text = createDataControl("editorTextEdit", "0 0", %this.valueSize);
    
    %prevControl = %stack.getObject(0);
    if(isObject(%prevControl))
        %this.reduceGuiControlSize(%text, %prevControl);
        
    %stack.addGuiControl(%text);
    %this.addControl(%text);
    
    %list = %this.checkFieldEquals(%field);
    if(%list !$= "")
    {
        %value = "!!!!! There is different values in: " @ %list @ " !!!!!!";    
	    %text.skipValueSaving = true;	    
    }
    
    %text.text = %value;
    %text.ToolTip = %hint;
    %text.AltCommand = " LogickingEditorFieldEditor.applyFieldValueFromEdit($ThisControl, " @ %field @ "); ";                        
    %text.validate = " LogickingEditorFieldEditor.applyFieldValueFromEdit($ThisControl, " @ %field @ "); ";                        
    %text.fieldName = %field;        
    
    %count = getWordCount(%additionalControls);
    for(%i = 0; %i < %count; %i++)
    {
        %controlType = getWord(%additionalControls, %i);
        switch$(%controlType)                  
        {
            case "playButton": %button = createDataControl("button", "0 0", %this.smallButtonSize);
                            %stack.addGuiControl(%button);
                            %this.addControl(%button);
                            %button.setText(">");
                            %button.Command = " LogickingEditorFieldEditor.playSound(" @ %text @ "); ";
                            %button.ToolTip = "Play sound";   
                            %this.reduceGuiControlSize(%text, %button);
        }
    }
    
    %buttonCommand = " LogickingEditorFieldEditor.currentControl = " @ %text @ "; " @ %buttonCommand;
    
    %button = createDataControl("button", "0 0", %this.buttonSize);
    %stack.addGuiControl(%button);
    %this.addControl(%button);
    %button.setText("...");
    %button.Command = %buttonCommand;
    %button.ToolTip = " Edit field value";            
}

function LogickingEditorFieldEditor::checkFieldExisting(%this, %fieldIndex)
{
    %selectedAmount = getWordCount(%this.currentObjects);
    if(%selectedAmount < 2 ) return true;
    %object = getWord(%this.currentObjects, 0);
    %object = %object.getId();
    %field = getFieldName(%object.templateName, %fieldIndex);
    
    for(%i = 0; %i < %selectedAmount; %i++)
    {
        %_object = getWord(%this.currentObjects, %i);
        
        if(%object == %_object || %_object.templateName $= "") continue;
        
        if(%field !$= getFieldName(%_object.templateName, %fieldIndex))
            return false;
    }
    
    return true;
}

function LogickingEditorFieldEditor::checkFieldEquals(%this, %fieldName)
{
    %selectedAmount = getWordCount(%this.currentObjects);
    %objectsList = "";
    if(%selectedAmount < 2 ) return %objectsList;
    %object = getWord(%this.currentObjects, 0);
    %value = %object.getFieldValue(%fieldName);
    
    for(%i = 0; %i < %selectedAmount; %i++)
    {
        %_object = getWord(%this.currentObjects, %i);
        
        if(%object == %_object || %_object.templateName $= "") continue;
        
        if(%value !$= %_object.getFieldValue(%fieldName))
        {
            if(%objectsList $= "")
                %objectsList = %object.getId() @ ":" @ %object.getName() @ ";";
                
            %objectsList = %objectsList @ %_object.getId() @ ":" @ %_object.getName() @ "; ";
        }
    }
    
    return %objectsList;
}

function LogickingEditorFieldEditor::createFields(%this)
{
	%this.clearFields();
	%obj = getWord(%this.currentObjects, 0);
	
	if(!isObject(%obj))
	    return;		
	
	%objectsAmount = getWordCount(%this.currentObjects);
	    
    if(%objectsAmount > 1)
    {
        LogickingEditorFieldEditorWindow.text = " ";
        for(%i = 0; %i < %objectsAmount; %i++)
        {
            %_obj = getWord(%this.currentObjects, %i);
            LogickingEditorFieldEditorWindow.text = LogickingEditorFieldEditorWindow.text @ %_obj.getId() @ "; ";
        }
        
        objectNameLabel.setActive(false);
        objectNameEdit.setActive(false);
	    objectNameEdit.setValue("# Group of objects #");
	    
        %_obj = getWord(%this.currentObjects, 0);
        %enabled = %_obj.isEnabled();
        for(%i = 1; %i < %objectsAmount; %i++)
        {
            %_obj = getWord(%this.currentObjects, %i);    
            if(%enabled != %_obj.isEnabled())
            {
                objectEnableCheckBox.useInactiveState = 1;
                %enabled = -1;
                break;
            }
        }
        objectEnableCheckBox.setStateOn(%enabled);
        
        %_obj = getWord(%this.currentObjects, 0);
        %hidden = %_obj.isHidden();
        for(%i = 1; %i < %objectsAmount; %i++)
        {
            %_obj = getWord(%this.currentObjects, %i);    
            if(%_obj.isMethod("isHidden") && %hidden != %_obj.isHidden())
            {
                objectHideCheckBox.useInactiveState = 1;
                %hidden = -1;
                break;
            }
        }
        objectHideCheckBox.setStateOn(%hidden);
        
        objectPositionLabel.setActive(false);
        objectPositionEdit.setActive(false);
	    objectPositionEdit.setValue("# Group of objects #");
	    toObjectPosButton.setVisible(false);
	    toCameraPosButton.setVisible(false);
    }
    else
    {        
        %objName = %obj.getName();
        LogickingEditorFieldEditorWindow.text = %obj.getId() @ " : " @ %objName;
        
        objectNameLabel.setActive(false);
        objectNameEdit.setActive(true);
	    objectNameEdit.text = %objName;
	    
	    objectEnableCheckBox.setValue(%obj.isEnabled());    
	    objectEnableCheckBox.useInactiveState = 0;
	    
	    if(%obj.isMethod(isHidden))
	        objectHideCheckBox.setValue(%obj.isHidden());    
	    objectHideCheckBox.useInactiveState = 0;
	    
	    objectPositionLabel.setActive(true);
	    objectPositionEdit.setActive(true);
	    if(%obj.isMethod(getPosition))
	        objectPositionEdit.text = %obj.getPosition();
        else
            objectPositionEdit.text = "";
            
        if(%obj.isMethod("getPosition"))
        {
            toObjectPosButton.setVisible(true);
	        toCameraPosButton.setVisible(true);
        }
    }
	if(%obj.isMethod(getScale))
        objectScaleEdit.text = %obj.getScale();
    else
        objectScaleEdit.text = "";
    objectScaleEdit.setActive(true);
	
	%fieldsCount = getFieldsCounter(%obj.templateName);	
	
	if(%obj.parentGroup !$= "" && %obj.parentGroup.templateName !$= "")
    {
        %parentStack = %this.getStack("General");
        %stack = createDataControl("stack", "0 0", %this.stackSize);
		%stack.StackingType = "Horizontal";
		%this.addControl(%stack);
		%parentStack.addGuiControl(%stack);
        
        %text = createDataControl("text", "0 0", %this.valueSize);
		%text.setText("Switch to parent:");
		%text.ToolTip = "Switch parent group of deleted object";
		%stack.addGuiControl(%text);
		%this.addControl(%text);
		
		%button = createDataControl("button", "0 0", %this.actionButtonSize);
        %stack.addGuiControl(%button);
        %this.addControl(%button);
        %button.setText(%obj.parentGroup);
        %button.ToolTip = %obj.parentGroup;
        %button.Command = " LogickingEditor.selectObject(" @ %obj.parentGroup @ ");";
        %this.reduceGuiControlSize(%text, %button);
    }
	
	for(%i = 0; %i < %fieldsCount; %i++)
	{
	    
	    if(!%this.checkFieldExisting(%i)) continue;
	    
	    %type = getFieldType(%obj.templateName, %i);
		switch$(%type)		
		{
		    case "action": continue;
		    
		    case "group": %this.createGroupEditor(%obj, %i);
		                continue;
		                
            case "internalObjectsList" : %this.createInternalObjectsEditor(%obj, %i);
                                        continue;
		}
	    
		%field = getFieldName(%obj.templateName, %i);		
		%group = getFieldGroup(%obj.templateName, %i);
		%hint = getFieldHint(%obj.templateName, %i);		
		%additional = getFieldAdditional(%obj.templateName, %i);				
		
		%value = %obj.getFieldValue(%field);
		
		%parentStack = %this.getStack(%group);
		%stack = createDataControl("stack", "0 0", %this.stackSize);
		%stack.StackingType = "Horizontal";
		%this.addControl(%stack);
					
		%text = createDataControl("text", "0 0", %this.fieldSize);
		%text.setText(%field @ " ");
		%text.ToolTip = %field;
		%stack.addGuiControl(%text);
		%this.addControl(%text);
		
		%this.addControlByType(%obj, %stack, %field, %type, %value, %group, %hint, %additional);
		
		
		%parentStack.addGuiControl(%stack);
		
		%parentStack.rollOut.sizeToContents();
		
	}   
}

function LogickingEditorFieldEditor::addControlByType(%this, %obj, %stack, %field, %type, %value, %group, %hint, %additional)
{
    if(%type $= "") return;
    
    switch$(%type)
    {
        case "string": %this.addTextEdit(%stack, %field, %value, 
            " LogickingEditorFieldEditor.editFieldValue(" @ %obj @ ", " @ %field @ ", false);", 
            %hint);
                    
        case "code": %this.addTextEdit(%stack, %field, %value, 
            " LogickingEditorFieldEditor.editFieldValue(" @ %obj @ ", " @ %field @ ", true);", 
            %hint);
            
        case "objectLink": %this.addObjectLink(%stack,  %field, %value, %additional, %hint);                                      
        
        case "file": %this.addTextEdit(%stack, %field, %value,         
            " LogickingEditorFieldEditor.setFilePath(" @ %obj @ ", " @ %field @ ", \"" @ %additional @ "\");", 
            %hint);
            
        case "sound": %this.addTextEdit(%stack, %field, %value, 
            " LogickingEditorFieldEditor.setFilePath(" @ %obj @ ", " @ %field @ ", \"" @ %additional @ "\");", 
            %hint, "playButton");
            
        case "vector": %edit = createDataControl("editorTextEdit", "0 0", %this.valueListSize);
                    %stack.addGuiControl(%edit);
                    %this.addControl(%edit);
                    %list = %this.checkFieldEquals(%field);
                    if(%list !$= "")
                    {
                        %value = "!!!!! There is different values in: " @ %list @ " !!!!!!";    
                        %edit.skipValueSaving = true;	    
                    }
                    %edit.text = %value;
                    %edit.ToolTip = %hint;
                    %edit.AltCommand = " LogickingEditorFieldEditor.setVectorValue($ThisControl, " @ %field @ "); ";                        
                    %edit.validate = " LogickingEditorFieldEditor.setVectorValue($ThisControl, " @ %field @ "); ";                        
                    %edit.fieldName = %field;                        
        
        /*case "action": %text.setExtent(getWord(%this.actionFieldSize, 0), getWord(%this.actionFieldSize, 1));
                        %button = createDataControl("button", "0 0", %this.actionButtonSize);
                        %stack.addGuiControl(%button);
                        %this.addControl(%button);
                        %button.setText("Execute");
                        %button.Command = %obj.getId() @ "." @ %field @ "();";
                        %button.ToolTip = %hint;      */
                    
        case "list": %idx = getFieldIndex(%obj.templateName, %field);
                    %valuesCount = getFieldValuesCount(%obj.templateName, %idx);			
                    %list = createDataControl("list", "0 0", %this.valueListSize);
                    %list.clear();
                    %stack.addGuiControl(%list);
                    %this.addControl(%list);
                    %list.command = " LogickingEditorFieldEditor.applyListFieldValue(" @ %list @ ", " @ %field @ "); ";
                    %list.ToolTip = %hint;                                                
                    
                    for(%i = 0; %i < %valuesCount; %i++)
                    {
                        %templateValue = getFieldValue(%obj.templateName, %idx, %i);
                        %list.add(%templateValue, %i);
                    }
                    
                    %objList = %this.checkFieldEquals(%field);
                    if(%objList !$= "")
                    {
                        %value = "!!!!! There is different values in: " @ %objList @ " !!!!!!";    
                        %list.add(%value, %valuesCount);
                        %list.setSelected(%valuesCount);
                        %list.skipValueSaving = true;	                                
                    }
                    else
                    {
                        %selected = %list.findText(%value);
                        %list.setSelected(%selected);
                    }
                    
        
        case "bool": %checkBox = createDataControl("checkBox", "0 0", %this.boolSize);
                    %stack.addGuiControl(%checkBox);
                    %this.addControl(%checkBox);
                    if(%this.checkFieldEquals(%field) !$= "")
                    {
                        %value = -1;
                        %checkBox.useInactiveState = 1;
                        %checkBox.skipValueSaving = true;
                    }
                        
                    %checkBox.setStateOn(%value);
                    %checkBox.command = " LogickingEditorFieldEditor.applyBoolValue($ThisControl, " @ %field @ "); ";
                    
        case "command": %button = createDataControl("button", "0 0", %this.actionButtonSize);
                    %stack.addGuiControl(%button);
                    %this.addControl(%button);
                    %button.setText(%field);
                    %button.Command = " Helpers::evalWithThisObj(\"" @ %additional @ "\", " @ %obj @ "); ";
                    %button.ToolTip = %hint;
    }
}

function LogickingEditorFieldEditor::clearFields(%this)
{
   %this.clearStackList();
   
   %this.guiControls[counter] = %this.guiControls[counter] $= "" ? 0 : %this.guiControls[counter];
   for(%i = 0; %i < %this.guiControls[counter]; %i++)
   {
      %control = %this.guiControls[%i];
      if(isObject(%control))
         %control.schedule(0, "delete");
      %this.guiControls[%i] = "";
   }
	%this.guiControls[counter] = 0;
	
	objectNameEdit.setText("");
	objectNameEdit.setActive(false);
	objectEnableCheckBox.setValue(false);    
	objectHideCheckBox.setValue(false);    
	
   objectPositionEdit.setText("");
	objectPositionEdit.setActive(false);
   objectScaleEdit.setText("");
   objectScaleEdit.setActive(false);

   toObjectPosButton.setVisible(false);    
   toCameraPosButton.setVisible(false);

   LogickingEditorFieldEditorWindow.text = "Select object to edit...";
} 

function LogickingEditorFieldEditor::editFieldValue(%this, %object, %field, %codeMode)
{	
    if(LogickingEditorFieldInspector.selected) return;
    
    LogickingEditor.showWindow(LogickingEditorFieldInspector);
	
	%this.currentField = %field;
	
	%this.codeMode = %codeMode;
	
	if(%codeMode)
	{
        //evaluateButton.Visible = true;
        LogickingEditor.pickingMode = true;        
        LogickingEditor.selectNames = true;        
        pickObjectModeCheckBox.Visible = true;
        pickObjectModeCheckBox.setValue(LogickingEditor.pickingMode);
        selectNamesCheckBox.Visible = true;
        selectNamesCheckBox.setValue(LogickingEditor.selectNames);        
        LogickingEditorFieldInspectorWindow.Extent = "600 235";
	}
	else
	{
        //evaluateButton.Visible = false;
        LogickingEditor.pickingMode = false;
        LogickingEditor.selectNames = false;
        pickObjectModeCheckBox.Visible = false;
        selectNamesCheckBox.Visible = false;
        LogickingEditorFieldInspectorWindow.Extent = "600 125";
	}
			
	
	LogickingEditorFieldInspector.currentField = %field;
	LogickingEditorFieldInspectorWindow.text = %object.getName() @ " . " @ %field;
	%index = getFieldIndex(%object.templateName, %field);
	defaultValueText.text = getFieldValue(%object.templateName, %index);
	tolltipTextLabel.text = getFieldHint(%object.templateName, %index);
	tolltipTextLabel.ToolTip = getFieldHint(%object.templateName, %index);
	%argsCount = getFieldAdditional(%object.templateName, %index);
	
	argumentsPopUpMenu.clear();
	argumentsPopUpMenu.add("%this", 0);
	for(%i = 0; %i < %argsCount; %i++)
	    argumentsPopUpMenu.add("%arg" @ %i, %i + 1);
	    
    argumentsPopUpMenu.setFirstSelected();
	
	%value = LogickingEditorFieldEditor.currentControl.getValue();//%object.getFieldValue(%field);
	fieldInspectorEditBox.setText(%value);
}

/*function LogickingEditorFieldEditor::askGroupApply(%this, %fieldName, %value)
{
    %msg = "Would you like to apply change for objects: ";
    %objectsAmount = EWorldEditor.getSelectionSize();
    for(%i = 0; %i < %objectsAmount; %i++)
    {
        %object = EWorldEditor.getSelectedObject(%i);            
        %msg = %msg @ "\n" @ %object.getId() @ ":" @ %object.getName() @ ";";
    }
    MessageBoxYesNo( "Apply changes?", %msg, " LogickingEditorFieldEditor.setFieldValue(" @ %fieldName @ ", " @ %value @ ")");
}*/

function LogickingEditorFieldEditor::setFieldValue(%this, %fieldName, %value)
{
    %objectsAmount = getWordCount(%this.currentObjects);
    for(%i = 0; %i < %objectsAmount; %i++)
    {
        %object = getWord(%this.currentObjects, %i);
        if(isObject(%object))
        {            
            %object.setFieldValue(%fieldName, %value);
            LogickingEditor.processLinks(%object);
        }
    }    
    
    EWorldEditor.isDirty = true;
}

function LogickingEditorFieldEditor::setVectorValue(%this, %control, %fieldName)
{
    %value = %control.getText();
    %value = VectorAdd(%value, "0 0 0");    
    %control.setValue(%value);
    %this.setFieldValue(%fieldName, %value);
    %control.skipValueSaving = "";
}

// Calls whenewer value is changed
function LogickingEditorFieldEditor::applyFieldValueFromEdit(%this, %currentTextEdit, %fieldName)
{
    if(LogickingEditorFieldInspector.selected && %fieldName $= %this.currentField)
	    fieldInspectorEditBox.setText(%currentTextEdit.getText());
		
    %this.setFieldValue(%fieldName, %currentTextEdit.getText());
}

function LogickingEditorFieldEditor::applyBoolValue(%this, %control, %fieldName)
{
    %this.setFieldValue(%fieldName, %control.getValue());
    %control.skipValueSaving = "";
    %control.useInactiveState = 0;   
}

// Calls whenewer value is changed from inspector
function LogickingEditorFieldEditor::applyFieldValue(%this)
{
	%objectsAmount = getWordCount(%this.currentObjects);
	%value = fieldInspectorEditBox.getValue();
	for(%i = 0; %i < %objectsAmount; %i++)
	{
	    %object = getWord(%this.currentObjects, %i);
	    if(isObject(%object))
	    {
	        %object.setFieldValue(%this.currentField, %value);
	        LogickingEditor.processLinks(%object);
	    }
	}
	
	//if(%value $= "") %value = " ";
	%this.currentControl.setValue(%value);
	%this.currentControl.skipValueSaving = true;
	%this.currentControl = "";
	
	LogickingEditorFieldInspector.close();
    EWorldEditor.isDirty = true;
}

function LogickingEditorFieldEditor::applyListFieldValue(%this, %listBox, %fieldName)
{
    if(%listBox.skipValueSaving)
    {
        %selected = %listBox.getSelected();
        if(%selected == %listBox.size() - 1)
        {
            return;
        }
        %listBox.skipValueSaving = "";        
        %listBox.clear();
        %obj = getWord(%this.currentObjects, 0);
        %index = getFieldIndex(%obj.templateName, %fieldName);
        %valuesCount = getFieldValuesCount(%obj.templateName, %index);
        for(%i = 0; %i < %valuesCount; %i++)
        {            
            %templateValue = getFieldValue(%obj.templateName, %index, %i);
            %listBox.add(%templateValue, %i);
        }
        %listBox.setSelected(%selected);        
    }
    %this.setFieldValue(%fieldName, %listBox.getText());
}

function LogickingEditorFieldEditor::setFilePath(%this, %object, %field, %filter)
{
    %index = getFieldIndex(%object.templateName, %field);    
    %filter = %filter $= "" ? "*.*" : %filter;    
    %dlg = new OpenFileDialog()
    {
         Filters        = %filter;
         DefaultPath    = $Pref::MissionEditor::LastPath;
         DefaultFile    = "";
         ChangePath     = false;
         MustExist      = true;
    };
            
    %ret = %dlg.Execute();
    if(%ret)
    {         
        
        %path = filePath(%dlg.FileName) @ "/" @ fileBase(%dlg.FileName);
        %path = makeRelativePath(%path, getMainDotCSDir());     
        
        %this.setFieldValue(%field, %path);

        $Pref::MissionEditor::LastPath = filePath( %dlg.FileName );
        
        %this.currentControl.text = %path;
        %this.currentControl = "";      
        
    }
      
      %dlg.schedule(0, "delete");
}

function LogickingEditorFieldEditor::selectLinkedObject(%this, %button)
{
    %text = %button.text;
    if(isObject(%text))
    {
        LogickingEditor.selectObject(%text);
    }
}

function LogickingEditorFieldEditor::addObjectLink(%this, %stack,  %field, %value, %additional, %hint)
{
    %obj = getWord(%this.currentObjects, 0);    
    %button = createDataControl("button", "0 0", %this.valueSize);
    
    %prevControl = %stack.getObject(0);
    if(isObject(%prevControl))
        %this.reduceGuiControlSize(%button, %prevControl);
        
    %stack.addGuiControl(%button);
    %this.addControl(%button);
    
    %list = %this.checkFieldEquals(%field);
    if(%list !$= "")
    {
        %value = "!!!!! There is different values in: " @ %list @ " !!!!!!";    
	    %button.skipValueSaving = true;	    
    }
    
    %button.setText(%value);
    %button.ToolTip = %hint;
    %button.Command = " LogickingEditorFieldEditor.selectLinkedObject(" @ %button @ ");";
    %button.fieldName = %field; 
    
    %button2 = createDataControl("button", "0 0", %this.buttonSize);
    %stack.addGuiControl(%button2);
    %this.addControl(%button2);
    %button2.setText("...");
    %button2.Command = " LogickingEditorFieldEditor.currentControl = " @ %button @ "; LogickingEditorObjectsList.caller = LogickingEditorFieldEditor; LogickingEditorObjectsList.classNameFilter = \"" @ %additional @ "\"; LogickingEditor.toggleWindow(LogickingEditorObjectsList); ";
    %button2.ToolTip = "Select object";
    
    if(%this.checkFieldEquals(%field) $= "")
    {
        %checkBox = createDataControl("checkBox", "0 0", %this.smallButtonSize);
        %this.reduceGuiControlSize(%button, %checkBox);
        %button.checkBox = %checkBox;
        %stack.addGuiControl(%checkBox);
        %this.addControl(%checkBox);    
        %checkBox.ToolTip = "Enable/disable objectLink";
        if(isObject(%value))
        {
            %checkBox.ToolTip = "Enable/disable: \" " @ %value.getId() @ " : " @ %value.getName() @ " \"";
            %checkBox.setStateOn(%value.isEnabled());
            %checkBox.command = " " @ %value @ ".setEnabled($ThisControl.getValue()); ";
        }
    }        
}

function LogickingEditorFieldEditor::setFieldByDeafault(%this)
{
    MessageBoxYesNo( "Set field value by default?", "Do you want to set field \"" @ %this.currentField @"\" to default value \"" @ defaultValueText.text @ "\" ?", " fieldInspectorEditBox.setValue(defaultValueText.text);  ", "");
    //fieldInspectorEditBox.schedule(200, \"onChangeCursorPos\", strlen(defaultValueText.text));
} 

function LogickingEditorFieldEditor::evaluateField(%this)
{
    %retValue = Helpers::evalWithThisObj(fieldInspectorEditBox.getText(), getWord(LogickingEditor.currentObjects, 0), "", true);
    if(%retValue $= "")
        MessageBoxOK("Error!", "Parse error!!!");
    else
        MessageBoxOK("Success!", "Syntax is correct!");
}

function LogickingEditorFieldEditor::acceptPosition(%this)
{
	%object = getWord(%this.currentObjects, 0);
	
	if(!%object.isMethod(setTransform))
            return;
	
	%position = objectPositionEdit.getText();
	%position = VectorAdd(%position, "0 0 0");
	objectPositionEdit.setText(%position);
	%transform = %object.getTransform();
	for(%i = 3; %i < 7; %i++)
		%position = %position @ " " @ getWord(%transform, %i);
	%object.setTransform(%position);
	EWorldEditor.isDirty = true;
}

function LogickingEditorFieldEditor::acceptScale(%this)
{
    %scale = objectScaleEdit.getText();
    %scale = VectorAdd(%scale, "0 0 0");
    objectScaleEdit.setValue(%scale);
    %objectsAmount = getWordCount(%this.currentObjects);
    for(%i = 0; %i < %objectsAmount; %i++)
    {
        %object = getWord(%this.currentObjects, %i);            
        if(%object.isMethod(setScale))
            %object.setScale(%scale);
    }
			
	EWorldEditor.isDirty = true;
}

function LogickingEditorFieldEditor::acceptName(%this)
{
	%object = getWord(LogickingEditor.currentObjects, 0);

    %newName = objectNameEdit.getText();
	%object.setName(%newName);
	
	LogickingEditorFieldEditorWindow.text = "Current object: " @ %object.getId() @ " : " @ %object.getName();
	currentObjectButton.text = %object.getId() @ " : " @ %object.getName();    
	
	%count = %object.getCount();
	if(%count > 0)
	{    
        for(%i = 0; %i < %count; %i++)
        {
            %childObject = %object.getObject(%i);
            %childObject.setName(%newName @ %childObject.nameMask @ "_" @ %i);
        }
        %this.inspectInternalObjects(%object);
	}
	
	EWorldEditor.isDirty = true;
}

function LogickingEditorFieldEditor::acceptEnabled(%this, %value)
{
    %objectsAmount = getWordCount(%this.currentObjects);
    for(%i = 0; %i < %objectsAmount; %i++)
    {
        %object = getWord(%this.currentObjects, %i);            
        if(%object.isMethod("setEnabled"))
            %object.setEnabled(%value);	
    }
    objectEnableCheckBox.useInactiveState = 0;
    EWorldEditor.isDirty = true;
}

function LogickingEditorFieldEditor::acceptHidden(%this, %value)
{
    %objectsAmount = getWordCount(%this.currentObjects);
    for(%i = 0; %i < %objectsAmount; %i++)
    {
        %object = getWord(%this.currentObjects, %i);            
        if(%object.isMethod("setHidden"))
            %object.setHidden(%value);	
    }
    objectHideCheckBox.useInactiveState = 0;
    EWorldEditor.isDirty = true;
}

function LogickingEditorFieldEditor::acceptAllChanges(%this)
{
    if(%this.currentObjects $= "") return;
    // we must save change before focus lost
    for(%i = 0; %i < %this.guiControls[counter]; %i++)
	{
		%control = %this.guiControls[%i];
		if(isObject(%control) && (%control.fieldName !$= "" && %control.skipValueSaving $= ""))
        {
            if(%control.getClassName() $= "GuiButtonCtrl")
                %value = %control.text;
            else
                %value = %control.getValue();
            %this.setFieldValue(%control.fieldName, %value); 
        }    		
	}
}

function LogickingEditorFieldEditor::onPickObject(%this, %object)
{
}

function LogickingEditorFieldEditor::onStartSelection(%this)
{
    if(!LogickingEditor.pickingMode)
        %this.currentObjects = "";
    %this.isListSelected = true;
}

function LogickingEditorFieldEditor::onEndSelection(%this)
{
    %this.isListSelected = false;
    if(!LogickingEditor.pickingMode)
        %this.createFields();
}

function LogickingEditorFieldEditor::selectObject(%this, %object)
{
    if(isObject(%this.currentControl))
    {
        %value = %object.getName() $= "" ? %object.getId() : %object.getName();
        %this.currentControl.setValue(%value);        
        if(%this.currentControl.isMethod("setText"))
            %this.currentControl.setText(%value);            
        if(isObject(%this.currentControl.checkBox))
            %this.currentControl.checkBox.setStateOn(%object.isEnabled());
        %this.setFieldValue(%this.currentControl.fieldName, %value);
        %this.currentControl = ""; 
        LogickingEditorObjectsList.templateNameFilter = "";       
        LogickingEditorObjectsList.classNameFilter = "";       
    }
}

function LogickingEditorFieldEditor::onSelectObject(%this, %object)
{    
    %this.acceptAllChanges();
    %n = EWorldEditor.getSelectionSize();
    if(%this.isListSelected)
        %this.currentObjects = %this.currentObjects @ %object @ " ";
    else if((%this.isListSelected == false || %this.isListSelected $= "") && EWorldEditor.getSelectionSize() >1)
    {
        %this.currentObjects = "";
        %count = EWorldEditor.getSelectionSize();
        for(%i = 0; %i < %count; %i++)
            %this.currentObjects = %this.currentObjects @ EWorldEditor.getSelectedObject(%i) @ " ";        
    }
    else
    {
        %this.currentObjects = %object;    
        %this.createFields();
    }
}

function LogickingEditorFieldEditor::onUnselectObject(%this)
{    
    %this.acceptAllChanges();
    %this.clearFields();
    %this.currentObjects = "";    
}

function LogickingEditorFieldEditor::onSleep(%this)
{
    %this.acceptAllChanges();
    %this.currentObjects = "";
}

function LogickingEditorFieldEditor::insertArgument(%this)
{
    %argument = argumentsPopUpMenu.getText();
    
    %text = fieldInspectorEditBox.getValue();
    %startPos = fieldInspectorEditBox.getCursorPos();
    %endPos = fieldInspectorEditBox.getCursorPos();
    
    if(LogickingEditorFieldEditor.posInText !$= "")
    {
        %startPos = getWord(LogickingEditorFieldEditor.posInText, 0);
        %endPos = getWord(LogickingEditorFieldEditor.posInText, 1);
    }
    %begin = getSubStr(%text, 0, %startPos);
    %end = getSubStr(%text, %endPos, strlen(%text));

    
    %text = %begin @ %argument @ %end;
    fieldInspectorEditBox.text = %text;
    fieldInspectorEditBox.setCursorPos(strlen(%text));
}

function LogickingEditorFieldEditor::insertAction(%this)
{    
    %action = availableActionsPopUp.getText();
    if(%action $= "") return;
    
    %text = fieldInspectorEditBox.getValue();
    
    %start = getWord(LogickingEditorFieldEditor.posInText, 0);
    %end = getWord(LogickingEditorFieldEditor.posInText, 1);        
    
    %str = "()";
    if(isObject(LogickingEditorFieldEditor.highlightedObject))
        %index = getFieldIndex(LogickingEditorFieldEditor.highlightedObject.templateName, %action);    
        if(%index !$= "" && %index != -1)
            %str = "(" @ getFieldAdditional(LogickingEditorFieldEditor.highlightedObject.templateName, %index) @ ")";
        
    if(getSubStr(%text, %end, 1) $= ".")
        %end++;
    else
        %action = "." @ %action;
    
    %beginPart = getSubStr(%text, 0, %end);
    
    %end = getEndPos(%text, %end, " \t;");            
    %endPart = getSubStr(%text, %end, strlen(%text) - %end);        
    
    if(strchr(");,", getSubStr(%endPart, 0, 1)) $= "")
        %str = %str @ ";";
        
    %text = %beginPart @ %action @ %str @ %endPart;
    
    fieldInspectorEditBox.setValue(%text);
    fieldInspectorEditBox.setCursorPos(strlen(%text));
}

function LogickingEditorFieldEditor::highlightObject(%this, %object)
{
    EWorldEditor.highlightObject(%object);
    
    availableActionsLabel.Visible = true;
    availableActionsPopUp.Visible = true;
    insertActionButton.Visible = true;
    actionParametersLabel.setValue("");
    
    availableActionsPopUp.clear();
    
    LogickingEditorFieldEditor.highlightedObject = %object;    
    
    %fieldsCount = getFieldsCounter(%object.templateName);	
    %counter = 0;
    %selectedAction = "";
    for(%i = 0; %i < %fieldsCount; %i++)
	{
		%group = getFieldGroup(%object.templateName, %i);
		
		if(%group $= "Actions")
		{
		    %value = getFieldValue(%object.templateName, %i);
            availableActionsPopUp.add(%value, %counter);	            
            %counter++;
            if(%selectedAction $= "")
                %selectedAction = %i;
		}
	}
	availableActionsPopUp.setFirstSelected();	
	%params = getFieldHint(%object.templateName, %selectedAction);
    actionParametersLabel.text = %params;
    actionParametersLabel.Visible = true;
}

function LogickingEditorFieldEditor::clearHighlighting(%this)
{
    EWorldEditor.clearHighlighting();
    
    LogickingEditorFieldEditor.highlightedObject = "";
    
    availableActionsLabel.Visible = false;
    availableActionsPopUp.Visible = false;
    insertActionButton.Visible = false;
    actionParametersLabel.Visible = false;
    actionParametersLabel.setValue("");
    availableActionsPopUp.clear();            
}

function LogickingEditorFieldEditor::playSound(%this, %text)
{
    if(%text.text $= "") return;
    
    %filePath = %text.text;
    %sfxSource = %this.cachedFiles[%filePath];
    if(!isObject(%sfxSource))
    {
        if(isObject(some))
            some.schedule(0, "delete");
            
        %sfxProfile = new SFXProfile("some") {
                filename = %filePath;
                description = %this.soundDescription;
                preload = true;
            };
        MissionCleanup.add(%sfxProfile);
        if(!isObject(%sfxProfile))
        {
            echo("Warning! ", %filePath, ". Unable to create profile for sound");
            return;
        }
        
        %sfxSource = sfxCreateSource(%sfxProfile, 0, 0, 0);
        %this.cachedFiles[%filePath] = %sfxSource;
    }
    %sfxSource.play();    
    %sfxSource.schedule(5000, "stop");
}

function LogickingEditorFieldEditor::flyPath(%this)
{
    if(!isObject(%this.testCam)) return;
    %this.currentScene = %this.testCam;
    
    %path = getWord(%this.currentObjects, 0);
    
    if(!isObject(%path) || %path.getCount() == 0) return;
    
    %this.acceptAllChanges();
    
    %node = %path.getObject(%i);     
    %this.currentScene.setTransform(%node.getTransform());   
    %this.currentScene.reset(0);   
    %this.currentScene.followPath(%path);  
    
    LogickingEditor.closeAllWindows();
}

function LogickingEditorFieldEditor::stopFly(%this)
{    
    if(%this.currentScene !$= "") 
    { 
        %this.currentScene.stop(); 
        %this.currentScene = ""; 
    }
    
}

function LogickingEditorFieldEditor::selectedToCameraPos(%this)
{
    %objectsAmount = getWordCount(%this.currentObjects);
    for(%i = 0; %i < %objectsAmount; %i++)
    {
        %object = getWord(%this.currentObjects, %i);            
        LogickingEditor.askMoveObjectToCamera(%object);
    }    
}

function LogickingEditorFieldEditor::cameraToSelectedPos(%this)
{
    %objectsAmount = getWordCount(%this.currentObjects);
    for(%i = 0; %i < %objectsAmount; %i++)
    {
        %object = getWord(%this.currentObjects, %i);            
        LogickingEditor.moveCameraToObject(%object);
    }    
}

function LogickingEditorFieldInspector::showActionParams(%this)
{
    %fieldName = availableActionsPopUp.getText();
    %index = getFieldIndex(LogickingEditorFieldEditor.highlightedObject.templateName, %fieldName);
    %params = getFieldAdditional(LogickingEditorFieldEditor.highlightedObject.templateName, %index);
    actionParametersLabel.text = %params;
}

function LogickingEditorFieldInspector::close(%this)
{
    EWorldEditor.blockDelete = "";
    LogickingEditor.toggleWindow(LogickingEditorFieldInspector);    
    
    if(LogickingEditor.pickingMode)
    {
        LogickingEditor.pickingMode = false;            
        if(getWordCount(LogickingEditorFieldEditor.currentObjects) == 1)
            LogickingEditor.selectObject(getWord(LogickingEditorFieldEditor.currentObjects, 0));    
    }
    
    EWorldEditor.clearHighlighting();
}

function LogickingEditorFieldInspector::onWake(%this)
{
    EWorldEditor.blockDelete = true;
}

function LogickingEditorFieldInspector::onPickObject(%this, %object)
{
    %text = fieldInspectorEditBox.getText();    
    
    %startPos = fieldInspectorEditBox.getCursorPos();
    %endPos = fieldInspectorEditBox.getCursorPos();    
    
    %char = getSubStr(%text, %startPos - 1, 1);
    %objectName = %object.getName() $= "" ? %object.getId() : %object.getName();
    if(%char !$= " " && %char !$= "(" && %char !$= "")
        %objectName = " " @ %objectName;            
    
    %begin = getSubStr(%text, 0, %startPos);
    %end = getSubStr(%text, %endPos, strlen(%text));
    %text = %begin @ %objectName @ %end;
    fieldInspectorEditBox.text = %text;
    fieldInspectorEditBox.onChangeCursorPos(strlen(%text));        
}

function LogickingEditorFieldInspector::onSelectObject(%this, %object)
{
}

function LogickingEditorFieldInspector::onUnselectObject(%this)
{
}

function LogickingEditorFieldInspector::onStartSelection(%thist)
{
}

function LogickingEditorFieldInspector::onEndSelection(%thist)
{
}

function fieldInspectorEditBox::onChangeCursorPos(%this, %cursorPos)
{
    if(!LogickingEditorFieldEditor.codeMode || LogickingEditorFieldEditor.codeMode $= "") return;
    %text = %this.getValue();
    %start = 0;
    %end = strlen(%text);    
    
    %start = getBeginPos(%text, %cursorPos, " \t.(;");    
    %end = getEndPos(%text, %cursorPos, " \t.();");
    
    %text = getSubStr(%text, %start, %end - %start);        
    
    if(isObject(%text))
    {
        LogickingEditorFieldEditor.posInText = %start @ " " @ %end;
        LogickingEditorFieldEditor.highlightObject(%text);
        if(LogickingEditor.selectNames)
            fieldInspectorEditBox.selectText(%start, %end);
        return;
    }    
    else
    {
        LogickingEditorFieldEditor.posInText = "";
        LogickingEditorFieldEditor.clearHighlighting();
    }
        
    if(getSubStr(%text, 0, 1) $= "%")
    {
        LogickingEditorFieldEditor.posInText = %start @ " " @ %end;
        if(LogickingEditor.selectNames)
            fieldInspectorEditBox.selectText(%start, %end);
        return;
    }
    else
    {
        LogickingEditorFieldEditor.posInText = "";
        return;
    }
    
}

function getBeginPos(%text, %pos, %separators)
{
    for(%i = %pos-1; %i >= 0; %i--)
    {
        %char = getSubStr(%text, %i, 1);
        if(strchr(%separators, %char) !$= "")
        {
            return %i + 1;
        }
    }    
    return 0;
}

function getEndPos(%text, %pos, %separators)
{
    if(strlen(%text) == 0) return 0;
    for(%i = %pos-1; %i < strlen(%text); %i++)
    {
        %char = getSubStr(%text, %i, 1);
        if(strchr(%separators, %char) !$= "")
        {
            return %i;
        }
    }
    return strlen(%text);
}

function breakToWords(%text, %separators)
{
    if(strlen(%text) == 0) return "";
    
    %tempBuf = "";
    %returnBuf = "";
    for(%i = 0; %i < strlen(%text); %i++)
    {        
        %char = getSubStr(%text, %i, 1);
        if(strchr(%separators, %char) !$= "")
        {
            %returnBuf = %returnBuf @ %tempBuf @ " ";
            %tempBuf = "";
        }
        else
            %tempBuf = %tempBuf @ %char;
    }
    %returnBuf = %returnBuf @ %tempBuf;
    return %returnBuf;
}

function breakToWordsA(%text, %separators)
{
    if(strlen(%text) == 0) return "";
    %counter = 0;
    %tempBuf = "";
    for(%i = 0; %i < strlen(%text); %i++)
    {        
        %char = getSubStr(%text, %i, 1);
        if(strchr(%separators, %char) !$= "")
        {
            $breakToWordsAReturnBuf[%counter] = %tempBuf;
            %tempBuf = "";
            %counter++;
        }
        else
            %tempBuf = %tempBuf @ %char;
    }
    $breakToWordsAReturnBuf[%counter] = %tempBuf;
    %counter++;
    $breakToWordsAReturnBuf[counter] = %counter;
}

function clearBreakToWordsBuf()
{
    for(%i = 0; %i < $breakToWordsAReturnBuf[counter]; %i++)
    {
        $breakToWordsAReturnBuf[%i] = "";
    }
    $breakToWordsAReturnBuf[counter] = "";
}