//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com
//-----------------------------------------------------------------------------

new ActionMap(LogickingEditorMap);

LogickingEditorMap.bindCmd(keyboard, "n", " schedule(0.5, 0, selectTag); ", "");
LogickingEditorMap.bindCmd(keyboard, "numpadadd", " schedule(0.5, 0, selectTag); ", "");

LogickingEditorMap.bindCmd(keyboard, "enter", " if(LogickingEditor.currentObjects !$= \"\") LogickingEditor.showWindow(LogickingEditorFieldEditor); ", "");
LogickingEditorMap.bindCmd(keyboard, "numpadenter", " if(LogickingEditor.currentObjects !$= \"\") LogickingEditor.showWindow(LogickingEditorFieldEditor); ", "");

LogickingEditorMap.bindCmd(keyboard, "t", " LogickingEditor.toggleWindow(LogickingEditorTemplatesList); ", "");
LogickingEditorMap.bindCmd(keyboard, "numpadminus", " LogickingEditor.toggleWindow(LogickingEditorTemplatesList); ", "");

LogickingEditorMap.bindCmd(keyboard, "l", " LogickingEditorObjectsList.caller = LogickingEditor; LogickingEditorObjectsList.classNameFilter = \"\"; LogickingEditor.toggleWindow(LogickingEditorObjectsList); ", "");
LogickingEditorMap.bindCmd(keyboard, "numpadmult", " LogickingEditorObjectsList.caller = LogickingEditor; LogickingEditorObjectsList.classNameFilter = \"\"; LogickingEditor.toggleWindow(LogickingEditorObjectsList); ", "");

LogickingEditorMap.bindCmd(keyboard, "c", " LogickingEditor.castRay(); ", "");


LogickingEditorMap.bindCmd(keyboard, "up", " LogickingEditor.onKeyboardEvent(0, \"forward\"); ", " LogickingEditor.onKeyboardEvent(0, \"\"); ");
LogickingEditorMap.bindCmd(keyboard, "right", " LogickingEditor.onKeyboardEvent(1, \"right\"); ", " LogickingEditor.onKeyboardEvent(1, \"\"); ");
LogickingEditorMap.bindCmd(keyboard, "down", " LogickingEditor.onKeyboardEvent(2, \"backward\"); ", " LogickingEditor.onKeyboardEvent(2, \"\"); ");
LogickingEditorMap.bindCmd(keyboard, "left", " LogickingEditor.onKeyboardEvent(3, \"left\"); ", " LogickingEditor.onKeyboardEvent(3, \"\"); ");

LogickingEditorMap.bindCmd(keyboard, "pageup", " LogickingEditor.onKeyboardEvent(4, \"pageup\"); ", " LogickingEditor.onKeyboardEvent(4, \"\"); ");
LogickingEditorMap.bindCmd(keyboard, "pagedown", " LogickingEditor.onKeyboardEvent(5, \"pagedown\"); ", " LogickingEditor.onKeyboardEvent(5, \"\"); ");

LogickingEditorMap.bindCmd(keyboard, "space", " LogickingEditorFieldEditor.stopFly(); ", "");

