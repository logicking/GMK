singleton GuiControlProfile (LogicMechanicsGuiRollOutProfile)
{
   fontType    = "Arial";
   fontSize    = "14";
   
   fontColor = "0 0 0 150";
   fontColorHL = "25 25 25 220";
   fontColorNA = "128 128 128";
   
   justify = "left";
   opaque = true;
   border = 1;
   cankeyfocus=true;
   tab = true;
  
   //bitmap = "tools/editorclasses/gui/images/rollout";
   bitmap = "tools/editorClasses/gui/panels/inspector-stlyle-rollout";   
   
   textOffset = "30 0";

};

singleton GuiControlProfile (LogicMechanicsAboutTextProfile22)
{
   fontColor = "0 0 0";
   fontSize = 20;
};
singleton GuiControlProfile (LogicMechanicsAboutTextProfile18)
{
   fontColor = "0 0 0";
   fontSize = 18;
};

singleton GuiControlProfile (LogicMechanicsTreeProfile : GuiTreeViewProfile)
{
    autoSizeHeight    = false;
    fontType = "Arial";
    fontSize = 16;
};

singleton GuiControlProfile (LogicMechanicsTextBoldCenterProfile)
{
   fontType = "Arial Bold";
   fontColor = "0 0 0";
   justify = "center";
};

singleton GuiControlProfile (LogicMechanicsTextBoldLeftProfile)
{
   fontType = "Arial Bold";
   fontColor = "0 0 0";
};

singleton GuiControlProfile( LogicMechanicsProgressProfile )
{
   opaque = false;
   fillColor = "255 0 0 200";
   border = true;
   borderColor   = "0 0 0 200";
   justify = "center";
   fontSize = "14";
};