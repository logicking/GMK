//-----------------------------------------------------------------------------
// Copyright (C) LogicKing.com
//-----------------------------------------------------------------------------

function createDataControl(%type, %position, %extent, %profile)
{
	%guiElement = "";
	switch$(%type)
	{
		case "text": %guiElement = new GuiTextCtrl() {
				canSaveDynamicFields = "0";
				Enabled = "1";
				isContainer = "0";
				HorizSizing = "right";
				VertSizing = "bottom";
				position = "15 45";
				Extent = "64 18";
				MinExtent = "8 2";
				canSave = "1";			
				Visible = "1";
				hovertime = "1000";
				Margin = "0 0 0 0";
				Padding = "0 0 0 0";
				AnchorTop = "1";
				AnchorBottom = "0";
				AnchorLeft = "1";
				AnchorRight = "0";
				maxLength = "1024";
				Profile = %profile;
			};
		case "textEdit": %guiElement = new GuiTextEditCtrl() {
				canSaveDynamicFields = "0";
				Enabled = "1";
				isContainer = "0";
				HorizSizing = "right";
				VertSizing = "bottom";
				position = "10 20";
				Extent = "70 18";
				MinExtent = "8 2";
				canSave = "1";
				Visible = "1";
				hovertime = "1000";
				Margin = "0 0 0 0";
				Padding = "0 0 0 0";
				AnchorTop = "1";
				AnchorBottom = "0";
				AnchorLeft = "1";
				AnchorRight = "0";
				maxLength = "1024";
				historySize = "0";
				password = "0";
				tabComplete = "0";
				sinkAllKeyEvents = "0";
				password = "0";
				passwordMask = "*";
			};
		case "button": %guiElement = new GuiButtonCtrl() {
				canSaveDynamicFields = "0";
				Enabled = "1";
				isContainer = "0";
				HorizSizing = "right";
				VertSizing = "bottom";
				position = "10 20";
				Extent = "40 18";
				MinExtent = "8 2";
				canSave = "1";
				Visible = "1";
				hovertime = "1000";
				text = "";
				groupNum = "-1";
				buttonType = "PushButton";
				useMouseEvents = "0";
			};
		case "list": %guiElement = new GuiPopUpMenuCtrl() {
	            canSaveDynamicFields = "0";
	            Enabled = "1";
	            isContainer = "0";
	            HorizSizing = "right";
	            VertSizing = "bottom";
	            position = "83 149";
	            Extent = "64 20";
	            MinExtent = "8 2";
	            canSave = "1";
	            Visible = "1";
	            hovertime = "1000";
	            Margin = "0 0 0 0";
	            Padding = "0 0 0 0";
	            AnchorTop = "1";
	            AnchorBottom = "0";
	            AnchorLeft = "1";
	            AnchorRight = "0";
	            maxLength = "1024";
	            maxPopupHeight = "200";
	            sbUsesNAColor = "0";
	            reverseTextList = "0";
	            bitmapBounds = "16 16";
			};
			case "icon": %guiElement = new GuiBitmapButtonCtrl() {
                canSaveDynamicFields = "0";
                Enabled = "1";
                isContainer = "0";
                HorizSizing = "right";
                VertSizing = "bottom";
                position = "10 10";
                Extent = "48 48";
                MinExtent = "8 2";
                canSave = "1";
                Visible = "1";
                hovertime = "1000";
                groupNum = "-1";
                buttonType = "PushButton";
                useMouseEvents = "0";
             };

             case "iconButton": %guiElement = new GuiIconButtonCtrl() {
                canSaveDynamicFields = "0";
                Enabled = "1";
                isContainer = "0";
                HorizSizing = "right";
                VertSizing = "bottom";
                position = "447 4";
                Extent = "140 30";
                MinExtent = "8 2";
                canSave = "1";
                Visible = "1";
                hovertime = "1000";
                text = "";
                groupNum = "-1";
                buttonType = "PushButton";
                useMouseEvents = "0";
                buttonMargin = "4 4";
                iconBitmap = "";
                iconLocation = "Left";
                sizeIconToButton = "0";
                textLocation = "Right";
                textMargin = "10";
            };
            case "rollOut": %guiElement =  new GuiRolloutCtrl() {
                canSaveDynamicFields = "0";
                Enabled = "1";
                isContainer = "1";
                Profile = "LogicMechanicsGuiRollOutProfile";
                HorizSizing = "right";
                VertSizing = "bottom";
                position = "86 52";
                Extent = "132 40";
                MinExtent = "8 2";
                canSave = "0";
                Visible = "1";
                hovertime = "1000";
                Caption = "";
                Margin = "2 2";
                DefaultHeight = "40";
                Collapsed = "1";
                ClickCollapse = "1";
            };
            case "stack": %guiElement =  new GuiStackControl() {
                StackingType = "Vertical";
                HorizStacking = "Left to Right";
                VertStacking = "Top to Bottom";
                Padding = "0";
                canSaveDynamicFields = "0";
                Enabled = "1";
                isContainer = "1";
                HorizSizing = "right";
                VertSizing = "bottom";
                position = "16 38";
                Extent = "204 16";
                MinExtent = "16 16";
                canSave = "1";
                Visible = "1";
                hovertime = "1000";
            };
            case "editorTextEdit": %guiElement = new GuiTextEditCtrl() {
                        canSaveDynamicFields = "0";
                        Enabled = "1";
                        isContainer = "0";
                        Profile = "GuiInspectorTextEditProfile";
                        HorizSizing = "right";
                        VertSizing = "bottom";
                        position = "0 0";
                        Extent = "245 18";
                        MinExtent = "8 2";
                        canSave = "1";
                        Visible = "1";
                        hovertime = "1000";
                        Margin = "0 0 0 0";
                        Padding = "0 0 0 0";
                        AnchorTop = "1";
                        AnchorBottom = "0";
                        AnchorLeft = "1";
                        AnchorRight = "0";
                        maxLength = "1024";
                        historySize = "0";
                        password = "0";
                        tabComplete = "0";
                        sinkAllKeyEvents = "0";
                        password = "0";
                        passwordMask = "*";
                     };
            case "checkBox": %guiElement = new GuiCheckBoxCtrl() {
                        canSaveDynamicFields = "0";
                        Enabled = "1";
                        isContainer = "0";
                        HorizSizing = "right";
                        VertSizing = "bottom";
                        position = "0 0";
                        Extent = "50 18";
                        MinExtent = "8 2";
                        canSave = "1";
                        Visible = "1";
                        Command = " ";
                        hovertime = "1000";
                        text = "";
                        groupNum = "-1";
                        buttonType = "ToggleButton";
                        useMouseEvents = "0";
                        useInactiveState = "0";
                  };                  
            case "progress": %guiElement = new GuiProgressCtrl() {
                         canSaveDynamicFields = "0";
                         Enabled = "1";
                         isContainer = "0";
                         Profile = "LogicMechanicsProgressProfile";
                         HorizSizing = "right";
                         VertSizing = "bottom";
                         Position = "0 0";
                         Extent = "64 21";
                         MinExtent = "8 2";
                         canSave = "1";
                         Visible = "1";
                         tooltipprofile = "GuiToolTipProfile";
                         hovertime = "1000";
                         Margin = "0 0 0 0";
                         Padding = "0 0 0 0";
                         AnchorTop = "1";
                         AnchorBottom = "0";
                         AnchorLeft = "1";
                         AnchorRight = "0";
                         maxLength = "1024";
                      };
	}
	
	%guiElement.setPosition(getWord(%position, 0), getWord(%position, 1));
	%guiElement.setExtent(getWord(%extent, 0), getWord(%extent, 1));
	
	return %guiElement;
}