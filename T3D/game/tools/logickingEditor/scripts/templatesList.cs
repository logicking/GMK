//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com
//-----------------------------------------------------------------------------

function LogickingEditorTemplatesList::onWake(%this)
{
    %this.fillTree();
	%this.validSelection = false;
}

function LogickingEditorTemplatesList::fillTree(%this)
{
    templatesListTree.removeAllChildren(0);
	templatesListTree.clear();
	templatesListTree.clearSelection();
    
    %icons = "empty:";
	%count = getCategoriesAmount();
	for(%i = 0; %i < %count; %i++)
	{
	    %icons = %icons @ getCategoryIcon(%i) @ "_ico:";
	}
    templatesListTree.buildIconTable(%icons);	

	// add categories
	%count = getCategoriesAmount();
    for(%i = 0; %i < %count; %i++)
    {
        %category = getCategoryName(%i);
		%iconIndex = %i + 1;
		templatesListTree.insertItem( 0, %category, "", "", %iconIndex, %iconIndex);
	}

    %count = getTemplatesAmount();
    for(%i = 0; %i < %count; %i++)
    {
        %parent = 0;        
        %category = getTemplateCategory(%i);
		%categoryIndex = getCategoryIndex(%category);
		// if the object category is not registered then don't add such object
		if(%categoryIndex == -1) continue;
        %parent = templatesListTree.findItemByName(%category);
		%templateName = getTemplateName(%i);
		templatesListTree.insertItem(%parent, %templateName, %templateName);
    }
}

function LogickingEditorTemplatesList::onPickObject(%this, %object)
{
}

function LogickingEditorTemplatesList::onStartSelection(%thist)
{
}

function LogickingEditorTemplatesList::onEndSelection(%thist)
{
}

function LogickingEditorTemplatesList::onSelectObject(%this, %object)
{
}

function LogickingEditorTemplatesList::onUnselectObject(%this)
{
}


function templatesListTree::onSelect(%this, %id)
{
    %value = %this.getItemValue(%id);
    if(%value !$= "")
    {
        LogickingEditorTemplatesList.currentTemplate = %value;
        acceptTemplateButton.setActive(true);
		LogickingEditorTemplatesList.validSelection = true;
    }
    else
	{
        acceptTemplateButton.setActive(false);
		LogickingEditorTemplatesList.validSelection = false;
	}
}

function LogickingEditorTemplatesList::selectTemplate(%this)
{    
    if(LogickingEditorTemplatesList.currentTemplate $= "" ||
		!LogickingEditorTemplatesList.validSelection) return;

    currentTemplateButton.setText(%this.currentTemplate);
    %index = getTemplateIndex(%this.currentTemplate);
    %category = getTemplateCategory(%index);
    currentTemplateButton.setBitmap(getCategoryIconByName(%category) @ "_ico");
    LogickingEditor.currentTemplate = %this.currentTemplate;
    
    createObjectButton.setActive(true);
	
	// add a little pause to give engine time to close the windown correctly when double click selection appears
	//%this.setActive(false);
	LogickingEditor.schedule(100, "toggleWindow", LogickingEditorTemplatesList);
}