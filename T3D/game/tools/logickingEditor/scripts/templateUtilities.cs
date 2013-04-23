//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com
//-----------------------------------------------------------------------------
//
// Templates are used for describing certain type of game object
// 
//List of available types of template's  variables. Type of variable will
//define 
// 
// string - simple editbox
// bool - will be shown as a checkBox
// list - drop window
//
// file - a filepath, can be specified with an edit box or calling 'openFileDialog'
// vector - a sting with three numeric values. Empty vector string will be treat as "0 0 0"
// code - a stirng with TorqueScript code. Code edit window allow made reference to other object with "pick mode"
//
// action - describes an action that can be select for drop list of code edit window
//
// group - describes array of one type params that contains one main string (can be "code" or "file" type) and one additional (optional)
// sound - variant of "file"-type includes button for playing selected sound file
// command - add button that evaluates chunk stored in field value
// objectLink - 
//-----------------------------------------------------------------------------

function assertBis( %value, %message )
{
	if(%value $= "")
	{
		error(%message);
	}
}

package TemplateFunctions
{
	//set template field values
	function setTemplateField(%templateName, %fieldName, %value, %type, %group, %hint, %additional, %skipSaving)
	{
		assertBis(%templateName, "Wrong templateName while set field " @ %fieldName @ " with value = " @ %value @ "!!!!!");
		assertBis(%fieldName, "Wrong fieldName in template " @ %templateName @ "!!!!!");
		%index = checkField(%templateName, %fieldName);
		
		$Templates[%templateName, %index, fieldName] = %fieldName;		
		
		//defult type is string
		%type = %type $= "" ? "string" : %type;
		$Templates[%templateName, %index, type] = %type;
		
		// list represented as an array of elements
		if(%type $= "list")
		{
            %count = getWordCount(%value);
            for(%i = 0; %i < %count; %i++)
            {
                $Templates[%templateName, %index, values, %i] = getWord(%value, %i);			
            }
            
            $Templates[%templateName, %index, valuesCount] = %count;
		}
		else
		    $Templates[%templateName, %index, value] = %value;
		
		// an object without specified group will be place in "default" group
		%group = %group $= "" ? getFieldGroup(%templateName, %index) : %group;
		%group = %group $= "" ? "Default" : %group;		
		$Templates[%templateName, %index, group] = %group;		
		$Templates[%templateName, %index, hint] = getFieldHint(%templateName, %index) $= "" ? %hint : getFieldHint(%templateName, %index);
		$Templates[%templateName, %index, additional] = %additional;				
		$Templates[%templateName, %index, skipSaving] = %skipSaving;				
	}
	
	// helper functions
	// define event  field for a template
	function setTemplateEvent(%templateName, %fieldName, %value, %hint, %additional)
	{
	    setTemplateField(%templateName, %fieldName, %value, "code", "Events", %hint, %additional);
	}
	// define action field for a template
	function setTemplateAction(%templateName, %actionName, %hint, %additional)
	{
	    setTemplateField(%templateName, %actionName, %actionName, "action", "Actions", %hint, %additional, true);
	}
	// Define params group for a template.
	// This function adds to prototype a parameters' list - similirar to list of dynamic fields . 
	// Params are represented as a sting, wich has following format: main_field_type|main_field_caption|secondary_01_field_caption|secondary_02_field_caption...
	// '|' symbol used as separator. Only main field can have type, secondary fields treated as text field.
	function setTemplateParamsGroup(%templateName, %groupName, %mainParamType, %hint, %additional)
	{
	    setTemplateField(%templateName, %groupName, %mainParamType, "group", "", %hint, %additional, true);
	}		
	// define command field for a template
	// Adds a button wich executes code %command for selected object
	function setTemplateCommand(%templateName, %buttonText, %hint, %command)
	{
	    setTemplateField(%templateName, %buttonText, %command, "command", "", %hint, %command, true);
	}
	// define sound file field for a template
	// adding a path to sound file
	function setTemplateSoundField(%templateName, %fieldName, %value, %group, %hint)
	{
	    setTemplateField(%templateName, %fieldName, %value, "sound", %group, %hint, $soundFilesMask);
	}
	// Add template for adding 'internal' objects, like markets in paths
	function setTemplateInternalObjects(%templateName, %fieldName, %value, %hint, %namesMask)
	{
	    setTemplateField(%templateName, %fieldName, %value, "internalObjectsList", "", %hint, %namesMask, true);
	}

    // Checks whether  field with a certain name exist in a template.
    // Returns an index of the field.
	// If the field is abscent it will increase field counter and 
	// returns the last available index.
	function checkField(%templateName, %fieldName)
	{
		%index = getFieldIndex(%templateName, %fieldName);
		if(%index == -1)
		{
			%index = getFieldsCounter(%templateName);
			increaseFieldsCounter(%templateName);
		}
			
		return %index;
	}
	
	// return an index of the template field by field name.
	// if there's no such field returns -1
	function getFieldIndex(%templateName, %fieldName)
	{
		assertBis(%templateName, "Wrong templateName while get field " @ %fieldName @ " index!!!!!");
		assertBis(%fieldName, "Wrong fieldName to get it's index in  template " @ %templateName @ "!!!!!");
		%index = -1;
		%counter = getFieldsCounter(%templateName);
		for(%i = 0; %i < %counter; %i++)
		{
			if($Templates[%templateName, %i, fieldName] $= %fieldName)
			{
				%index = %i;
				break;
			}
		}
		
		return %index;
	}

	// returns a name by index
	function getFieldName(%templateName, %index)
	{	
		assertBis(%templateName, "Wrong templateName while get field " @ %index @ "!!!!!");
		assertBis(%index, "Wrong index in template " @ %templateName @ "!!!!!");
		return $Templates[%templateName, %index, fieldName];
	}

	// increments count of the fields
	function increaseFieldsCounter(%templateName)
	{
		$Templates[%templateName, fieldsCounter]++;	
	}

	// field counter
	function getFieldsCounter(%templateName)
	{
		return $Templates[%templateName, fieldsCounter] ? $Templates[%templateName, fieldsCounter] : 0;	
	}

	// Returns a field value by index.
	// If there's a complex field , than usign second %valueIndex to get value
	function getFieldValue(%templateName, %index, %valueIndex)
	{
		assertBis(%templateName, "Wrong templateName while get field " @ %index @ "!!!!!");
		assertBis(%index, "Wrong index in template " @ %templateName @ "!!!!!");
		if($Templates[%templateName, %index, valuesCount] > 0)
		{	
			return $Templates[%templateName, %index, values, %valueIndex];
		}
		else
			return $Templates[%templateName, %index, value];
	}
	
	// returns a category of given field
	function getFieldGroup(%templateName, %index)
	{
		assertBis(%templateName, "Wrong templateName while get field " @ %index @ "!!!!!");
		assertBis(%index, "Wrong index in template " @ %templateName @ "!!!!!");
        return $Templates[%templateName, %index, group];
	}
	
	// returns a hint for a field
	function getFieldHint(%templateName, %index)
	{
		assertBis(%templateName, "Wrong templateName while get field " @ %index @ "!!!!!");
		assertBis(%index, "Wrong index in template " @ %templateName @ "!!!!!");
        return $Templates[%templateName, %index, hint];
	}
	
	
	// returns a type of a field
	function getFieldType(%templateName, %index)
	{
		assertBis(%templateName, "Wrong templateName while get field " @ %index @ "!!!!!");
		assertBis(%index, "Wrong index in template " @ %templateName @ "!!!!!");
        return $Templates[%templateName, %index, type];
	}
	
	
	// returns a field's additional param
	function getFieldAdditional(%templateName, %index)
	{
		assertBis(%templateName, "Wrong templateName while get field " @ %index @ "!!!!!");
		assertBis(%index, "Wrong index in template " @ %templateName @ "!!!!!");
        return $Templates[%templateName, %index, additional];
	}	
	
	// returns a field's additional param
	function skipFieldSaving(%templateName, %index)
	{
		assertBis(%templateName, "Wrong templateName while get field " @ %index @ "!!!!!");
		assertBis(%index, "Wrong index in template " @ %templateName @ "!!!!!");
        return $Templates[%templateName, %index, skipSaving];
	}	

	// returns a field's values count
	function getFieldValuesCount(%templateName, %index)
	{
		return $Templates[%templateName, %index, valuesCount];
	}

	// register a new template with(%templateName) within a specified categor(%categoryName). 
	// %creationChunk is piece of TorqueScript code that returns a newly created object by the template
	function registerTemplate(%templateName, %categoryName, %creationChunk)
	{
		assertBis(%templateName, "Wrong templateName for register!!!!!");
		assertBis(%categoryName, "Wrong category name in template " @ %templateName @ "!!!!!");
		%index = getTemplateIndex(%templateName);
		if(%index == -1)
		{
			%index = getTemplatesAmount();
			$Templates[templatesCounter]++;
		}
		$Templates[%index, templateName] = %templateName;
		$Templates[%index, creationChunk] = %creationChunk;
		$Templates[%index, categoryName] = %categoryName;
	}
	
	// Inherits one template from another. Actualy copies fields of %templateParent to %templateName. 
	function inheritTemplate(%templateName, %templateParent)
	{
		%count = getFieldsCounter(%templateParent);
		%parentIndex = getTemplateIndex(%templateParent);
		registerTemplate(%templateName, getTemplateCategory(%parentIndex), getTemplateCreationChunk(%parentIndex));
		for(%i = 0; %i < %count; %i++)
		{
			%fieldName = getFieldName(%templateParent, %i);
			%count2 = getFieldValuesCount(%templateParent, %i);
			%type = getFieldType(%templateParent, %i);
            %group = getFieldGroup(%templateParent, %i);
            %hint = getFieldHint(%templateParent, %i);
            %additional = getFieldAdditional(%templateParent, %i);
            %skipSaving = skipFieldSaving(%templateParent, %i);
            %value = "";
			if(%type $= "list")
			{				
				for(%j = 0; %j < %count2; %j++)
				{
					%value = %value @ getFieldValue(%templateParent, %i, %j) @ " ";
				}
			}
			else
				%value = getFieldValue(%templateParent, %i);				
				
			setTemplateField(%templateName, %fieldName, %value, %type, %group, %hint, %additional, %skipSaving);
		}
	}

	// returns amount of registered prototypes.
	function getTemplatesAmount()
	{
		return $Templates[templatesCounter] ? $Templates[templatesCounter] : 0;
	}
	
	// returns a template index from its name
	function getTemplateIndex(%templateName)
	{
		assertBis(%templateName, "Wrong templateName to get it's index!!!!!");
		%index = -1;
		%counter = getTemplatesAmount();
		for(%i = 0; %i < %counter; %i++)
		{
			if($Templates[%i, templateName] $= %templateName)
			{
				%index = %i;
				break;
			}	
		}
		return %index;
	}

	// returns a template name from its index
	function getTemplateName(%index)
	{
		return $Templates[%index, templateName];
	}
	
	// returns a template creation code
	function getTemplateCreationChunk(%index)
	{
		return $Templates[%index, creationChunk];
	}	
	
	// returns a template category by its index
	function getTemplateCategory(%index)
	{
		return $Templates[%index, categoryName];
	}	
	
	
	// a function creates and returns an object from template.
	function createObject(%templateName, %objectName)
	{
	    if(%templateName $= "")
	    {
	        error("Wrong templateName to create new object!!!!");
	        return -1;
	    }
	    
	    %index = getTemplateIndex(%templateName);
	    if(%index == -1)
        {
            error("Error!!! No such template - " @ %templateName);
            return;
        }
	    %chunk = getTemplateCreationChunk(%index);
        %object = eval(%chunk);	
        
        assertBis(%object, "Error!!! Can't create object " @ %objectName @ " by template " @ %templateName);
        
        MissionGroup.add(%object);
	    
	    %object.templateName = %templateName;
	    %templateIndex = getTemplateIndex(%templateName);
	    %object.category = getTemplateCategory(%templateIndex);
	    %categoryIndex =  getCategoryIndex(%object.category);
        %object.editorIcon = getCategoryIcon(%categoryIndex);
        %object.setName(%objectName);
        
        %fieldsCount = getFieldsCounter(%templateName);	
        for(%i = 0; %i < %fieldsCount; %i++)
        {
            if(getFieldValuesCount(%object.templateName, %i) $= "")
            {
                %skipSaving = skipFieldSaving(%object.templateName, %i);
                if(%skipSaving) continue;
                %fieldName = getFieldName(%object.templateName, %i);
                %value = getFieldValue(%object.templateName, %i);
                %object.setFieldValue(%fieldName, %value);
            }
        }
        return %object;
	}
	
	
	function addCategory(%categoryName, %icon)
	{
        assertBis(%categoryName, "Wrong category name to add. Icon is " @ %icon @"!!!!");
        assertBis(%icon, "Wrong icon to add for category - " @ %categoryName @ "!!!!!");
        %index = getCategoryIndex(%categoryName);
        // add new category only when category with same name doesn't exists
		if(%index == -1)
		{
            %index = getCategoriesAmount();
            $Categories[counter]++;
		}
        $Categories[%index, name] = %categoryName;
		$Categories[%index, icon] = %icon;
	}
	
	function getCategoriesAmount()
    {
        $Categories[counter] = $Categories[counter] ? $Categories[counter] : 0;
        return $Categories[counter];
	}
	
	function getCategoryIndex(%categoryName)
	{
        assertBis(%categoryName, "Wrong categoryName to get it's index!!!!!");
		%index = -1;
		%counter = getCategoriesAmount();
		for(%i = 0; %i < %counter; %i++)
		{
			if($Categories[%i, name] $= %categoryName)
			{
				%index = %i;
				break;
			}	
		}
		return %index;
	}
	
	function getCategoryName(%index)
	{
        assertBis(%index, "Wrong index to get category name!!!!!");
        %categoryName = $Categories[%index, name];
        assertBis(%categoryName, "Wrong index to get category name!!!!!");        
        
        return %categoryName;
	}
	
	function getCategoryIcon(%index)
	{
        assertBis(%index, "Wrong index to get category icon!!!!!");
        %icon = $Categories[%index, icon];
        assertBis(%icon, "Wrong index to get category icon!!!!!");        
        
        return %icon;
	}
	function getCategoryIconByName(%name)
	{
        assertBis(%name, "Wrong name to get category icon!!!!!");
        %index = getCategoryIndex(%name);
        %icon = $Categories[%index, icon];
        assertBis(%icon, "Wrong index to get category icon!!!!!");        
        
        return %icon;
	}
};