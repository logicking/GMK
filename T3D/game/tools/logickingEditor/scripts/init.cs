//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com, Inc.
//-----------------------------------------------------------------------------

function WorldEditor::onEndSelection(%this)
{
}
    
function WorldEditor::onStartSelection(%this)
{
}

package logickingEditorFunctions{
   
   //World editor hooks
    function WorldEditor::onClick(%this,%obj)
    {        
        parent::onSelect(%this,%obj);        
        
        LogickingEditor.setCurrentObject(%obj.getId());
    }
   
    function WorldEditor::onEndSelection(%this)
    {
        parent::onEndSelection(%this);
        LogickingEditor.onEndSelection();
    }

    function WorldEditor::onStartSelection(%this)
    {
        parent::onStartSelection(%this);
        LogickingEditor.onStartSelection();
    }
   
    function WorldEditor::onClearSelection(%this)
    {
        parent::onClearSelection(%this);

        LogickingEditor.unselectObject();
    }
    
    function EditorTree::onObjectDeleteCompleted(%this)
    {
        parent::onObjectDeleteCompleted(%this);

        LogickingEditor.deleteObject();
    }
   
    function Editor::open(%this)
    {
        parent::open(%this);
        
        GameMechanics::hookToMissionEditorStart();
    }
    
    function Editor::close(%this, %gui)
    {
        parent::close(%this, %gui);
        
        GameMechanics::hookToMissionEditorStop();
    }
    
    function Editor::checkActiveLoadDone()
    {
         if(parent::checkActiveLoadDone())
         {
            GameMechanics::hookToMissionEditorStart();
            return true;
         }
         return false;
    }  
    
    function EditorGui::onSleep(%this)
    {    
        parent::onSleep(%this);
        
        //LogickingEditor.onDeactivated();
    }       
    
    function EditorGui::setEditor( %this, %newEditor)
    {
        parent::setEditor( %this, %newEditor);
        
        LogickingEditor.onDeactivated();
    }
   
    //Menus hooks
    function EditorGui::buildMenus(%this)
    {
        parent::buildMenus(%this);


        // GameLogic menu
        if(!isObject(%this.gmkMenu))
        {
            %this.gmkMenu = new PopupMenu()
            {
                superClass = "MenuBuilder";
                class = "EditorGameLogicMenu";

                barTitle = "Game Mechanics Kit";

                item[0] = "Game Mechanics Editor Toggle" TAB "Ctrl E" TAB " GameMechanics::toggleEditor(); ";
                item[1] = "-";
                item[2] = "Reload Original and Continue Edit" TAB "" TAB " GameMechanics::editorMissionReloadQuestion(true); ";
                item[3] = "Reload Original and Play" TAB "" TAB " GameMechanics::editorMissionReloadQuestion(true, true); ";
                item[4] = "Save, Restart and Play Mission" TAB "" TAB " GameMechanics::saveAndReload(); ";
                item[5] = "-";
                item[6] = "Settings" TAB "" TAB " canvas.pushDialog(GameMechanicsSettings); ";
                item[7] = "About" TAB "" TAB " canvas.pushDialog(AboutLogicMechanics); ";
            };      
            %this.menuBar.add(%this.gmkMenu);
        }
    }
   
};


//-----------------------------------------------------------------------------
// Activate Package.
//-----------------------------------------------------------------------------
activatePackage(logickingEditorFunctions);