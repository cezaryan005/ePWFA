﻿
Imports Microsoft.VisualBasic
Imports BaseClasses.Utils.DbUtils
  
Namespace ePortalWFApproval.UI

  

    Public Interface IMenu_Item_HighlightedVertical

#Region "Interface Properties"
        
        ReadOnly Property Button() As System.Web.UI.WebControls.LinkButton
      Property Visible() as Boolean
         

#End Region

    End Interface

  
End Namespace
  