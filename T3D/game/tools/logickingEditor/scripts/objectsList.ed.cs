//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com
//-----------------------------------------------------------------------------

function LogickingEditorObjectsList::onWake(%this)
{
	%this.fillTree();
	
	if(%this.templateNameFilter !$= "")
	    LogickingEditorObjectsListWindow.text = "Select " @ %this.templateNameFilter;
    else if(%this.classNameFilter !$= "")
	    LogickingEditorObjectsListWindow.text = "Select " @ %this.classNameFilter;
    else
        LogickingEditorObjectsListWindow.text = "Game Objects List";	
	
	currentSelectionCriteriaPopUp.clear();
	currentSelectionCriteriaPopUp.add("none", 0);	
	currentSelectionCriteriaPopUp.add("category", 1);	
	currentSelectionCriteriaPopUp.add("template", 2);	
	currentSelectionCriteriaPopUp.setSelected(0);
}

function LogickingEditorObjectsList::deleteObjectsFromList(%this)
{
	// Not very fast to rebuild list every time we delete object
	// It would be nice to write more optimal code.
	%this.fillTree();
}

function LogickingEditorObjectsList::fillTree(%this)
{
	objectsListTree.clear();
	%this.currentObject = getWord(LogickingEditor.currentObjects, 0);
	
	%icons = "empty:";
	%count = getCategoriesAmount();
	for(%i = 0; %i < %count; %i++)
	{
	    %icons = %icons @ getCategoryIcon(%i) @ "_ico:";
	}
    objectsListTree.buildIconTable(%icons);
	
	if(%this.classNameFilter !$= "")
	{
	    currentSelectionCriteriaPopUp.setVisible(false);
	}
	else
	    currentSelectionCriteriaPopUp.setVisible(true);

	%count = MissionGroup.getCount();
	for(%i = 0; %i < %count; %i++)
	{
		%obj = MissionGroup.getObject(%i);
        if(%obj.templateName !$= "")
        {
            if(%this.templateNameFilter !$= "" && %this.templateNameFilter !$= %obj.templateName) continue;
            if(%this.classNameFilter !$= "" && %this.classNameFilter !$= %obj.getClassName()) continue;
			if(objectsListTree.findItemByName(%obj.getName())) continue;

            %parent = 0;
            %iconIndex = getCategoryIndex(%obj.category) + 1;
            if(%this.sortCriteria !$= "")
            {
                %parentId = %obj.getFieldValue(%this.sortCriteria);
                %parent = objectsListTree.findItemByName(%parentId);
                if(%parent == 0)
                    %parent = objectsListTree.insertItem( 0, %parentId, %parentId, "", %iconIndex, %iconIndex);
                %iconIndex = 0;
            }
			//treat SimSet as a group of objects only when sorting is 'none'
			else
			{
				if(%obj.isMemberOfClass("SimSet"))
				{
					%parent = objectsListTree.insertItem(0, "  " @ %obj.getId() @ " : " @ %obj.getName(), %obj.getName(), "", %iconIndex);
					for(%j = 0; %j < %obj.getCount(); %j++)
					{
						%child = %obj.getObject(%j);
						%iconIndex = getCategoryIndex(%child.category) + 1;
						%id = objectsListTree.insertItem(%parent, "  " @ %child.getId() @ " : " @ 
							%child.getName(), %child.getName(), "", %iconIndex);
					}
					continue;
				}
			}
			%id = objectsListTree.insertItem(%parent, "  " @ %obj.getId() @ " : " @ %obj.getName(), %obj.getName(), "", %iconIndex);
        }
	}
	if(LogickingEditor.currentObjects !$= "")
    {
        %currentaObject = getWord(LogickingEditor.currentObjects, 0);
        %index = objectsListTree.findItemByName(%currentaObject.getId() @ " : " @ %currentaObject.getName());
        objectsListTree.addSelection(%index);
    }
}

function LogickingEditorObjectsList::switchSort(%this)
{
    %id = currentSelectionCriteriaPopUp.getSelected();
    %value = currentSelectionCriteriaPopUp.getText();
    switch$(%value)
    {
        case "none": %this.sortCriteria = "";
        case "category": %this.sortCriteria = "category";
        case "template": %this.sortCriteria = "templateName";
    }
		
	%this.fillTree();
}

function LogickingEditorObjectsList::cancelButtonOnPush(%this)
{
	LogickingEditor.toggleWindow(LogickingEditorObjectsList);	
}

function LogickingEditorObjectsList::selectButtonOnPush(%this)
{
	%this.caller.selectObject(%this.selectedObject);

	// add a little pause to give engine time to close the windown correctly when double click selection appears
	//%this.setActive(false);
	LogickingEditor.schedule(100, "toggleWindow", LogickingEditorObjectsList);
	EWorldEditor.clearHighlighting();
	if(LogickingEditor.currentObjects !$= "") 
		LogickingEditor.showWindow(LogickingEditorFieldEditor);
}

function objectsListTree::onSelect(%this, %id)
{
	%object = %this.getItemValue(%id);
	if(!(isObject(%object)))
		return;
	LogickingEditorObjectsList.selectedObject = %object.getName();	
	EWorldEditor.highlightObject(%object); 
	
	if(LogickingEditor.pickingMode)
	    LogickingEditor.selectObject(%object);
}

function LogickingEditorObjectsList::onPickObject(%this, %object)
{
}

function LogickingEditorObjectsList::onStartSelection(%thist)
{
}

function LogickingEditorObjectsList::onEndSelection(%thist)
{
}

function LogickingEditorObjectsList::onSelectObject(%this, %object)
{
    %index = objectsListTree.findItemByName(%object.getId() @ " : " @ %object.getName());
    objectsListTree.addSelection(%index);
}

function LogickingEditorObjectsList::onUnselectObject(%this)
{
    objectsListTree.clearSelection();
}
