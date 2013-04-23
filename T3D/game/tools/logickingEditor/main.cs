//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

function initializeLogickingEditor()
{
    exec("./scripts/init.cs");
    exec("./scripts/logickingEditor.bind.cs");
    
    exec("./scripts/templateUtilities.cs");
	exec("./scripts/controls.cs");
	exec("./gui/profiles.cs");
	exec("./gui/logickingEditor.ed.gui");
	exec("./gui/logickingEditorFieldEditor.ed.gui");
	exec("./gui/logickingEditorFieldInspector.ed.gui");
	exec("./gui/logickingEditorObjectsList.ed.gui");
	exec("./gui/logickingEditorTemplatesList.ed.gui");	
	exec("./scripts/logickingEditor.ed.cs");
	exec("./scripts/objectsList.ed.cs");
	exec("./scripts/fieldsEditor.cs");
	exec("./scripts/templatesList.cs");
	exec("./gui/about.ed.gui");
	exec("./gui/settings.ed.gui");
}