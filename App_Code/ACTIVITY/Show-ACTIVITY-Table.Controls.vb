﻿
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' Show_ACTIVITY_Table.aspx page.  The Row or RecordControl classes are the 
' ideal place to add code customizations. For example, you can override the LoadData, 
' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#Region "Imports statements"

Option Strict On
Imports Microsoft.VisualBasic
Imports BaseClasses.Web.UI.WebControls
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Web.Script.Serialization
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Utils
Imports ReportTools.ReportCreator
Imports ReportTools.Shared

  
        
Imports ePortalWFApproval.Business
Imports ePortalWFApproval.Data
Imports ePortalWFApproval.UI
        

#End Region

  
Namespace ePortalWFApproval.UI.Controls.Show_ACTIVITY_Table

#Region "Section 1: Place your customizations here."

    
Public Class ACTIVITYTableControlRow
        Inherits BaseACTIVITYTableControlRow
        ' The BaseACTIVITYTableControlRow implements code for a ROW within the
        ' the ACTIVITYTableControl table.  The BaseACTIVITYTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of ACTIVITYTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class ACTIVITYTableControl
        Inherits BaseACTIVITYTableControl

    ' The BaseACTIVITYTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The ACTIVITYTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the ACTIVITYTableControlRow control on the Show_ACTIVITY_Table page.
' Do not modify this class. Instead override any method in ACTIVITYTableControlRow.
Public Class BaseACTIVITYTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in ACTIVITYTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in ACTIVITYTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Show confirmation message on Click
              Me.DeleteRowButton.Attributes.Add("onClick", "return (confirm(""" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ePortalWFApproval") & """));")
                  
        
              ' Register the event handlers.
          
              AddHandler Me.DeleteRowButton.Click, AddressOf DeleteRowButton_Click
                        
              AddHandler Me.EditRowButton.Click, AddressOf EditRowButton_Click
                        
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseDYNAMICS%dbo.ACTIVITY record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = ACTIVITYTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseACTIVITYTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New ACTIVITYRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in ACTIVITYTableControlRow.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.
            
            MyBase.DataBind()
            Me.ClearControlsFromSession()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
              
                Return
            End If
             
   
            'LoadData for DataSource for chart and report if they exist
          
            ' Store the checksum. The checksum is used to
            ' ensure the record was not changed by another user.
            If Not Me.DataSource.GetCheckSumValue() Is Nothing
                Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
            End If
            
      
      
            ' Call the Set methods for each controls on the panel
        
                SetCMPNYNAM()
                SetCMPNYNAMLabel()
                
                
                SetIsOffline()
                SetIsOfflineLabel()
                SetIsWebClient()
                SetIsWebClientLabel()
                SetLanguage_ID()
                SetLanguage_IDLabel()
                SetLOGINDAT()
                SetLOGINDATLabel()
                SetLOGINTIM()
                SetLOGINTIMLabel()
                SetSQLSESID()
                SetSQLSESIDLabel()
                SetUserId0()
                SetUSERIDLabel()
                SetDeleteRowButton()
              
                SetEditRowButton()
              
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                If Me.DataSource.GetID IsNot Nothing Then
                    Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
                End If
                
            End If
            
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
            
        End Sub
        
        
        Public Overridable Sub SetCMPNYNAM()

                  
            
        
            ' Set the CMPNYNAM Literal on the webpage with value from the
            ' DatabaseDYNAMICS%dbo.ACTIVITY database record.

            ' Me.DataSource is the DatabaseDYNAMICS%dbo.ACTIVITY record retrieved from the database.
            ' Me.CMPNYNAM is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCMPNYNAM()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CMPNYNAMSpecified Then
                				
                ' If the CMPNYNAM is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(ACTIVITYTable.CMPNYNAM)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CMPNYNAM.Text = formattedValue
                
            Else 
            
                ' CMPNYNAM is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.CMPNYNAM.Text = ACTIVITYTable.CMPNYNAM.Format(ACTIVITYTable.CMPNYNAM.DefaultValue)
                        		
                End If
                 
            ' If the CMPNYNAM is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CMPNYNAM.Text Is Nothing _
                OrElse Me.CMPNYNAM.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CMPNYNAM.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetIsOffline()

                  
            
        
            ' Set the IsOffline Literal on the webpage with value from the
            ' DatabaseDYNAMICS%dbo.ACTIVITY database record.

            ' Me.DataSource is the DatabaseDYNAMICS%dbo.ACTIVITY record retrieved from the database.
            ' Me.IsOffline is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetIsOffline()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsOfflineSpecified Then
                				
                ' If the IsOffline is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(ACTIVITYTable.IsOffline)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.IsOffline.Text = formattedValue
                
            Else 
            
                ' IsOffline is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.IsOffline.Text = ACTIVITYTable.IsOffline.Format(ACTIVITYTable.IsOffline.DefaultValue)
                        		
                End If
                 
            ' If the IsOffline is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.IsOffline.Text Is Nothing _
                OrElse Me.IsOffline.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.IsOffline.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetIsWebClient()

                  
            
        
            ' Set the IsWebClient Literal on the webpage with value from the
            ' DatabaseDYNAMICS%dbo.ACTIVITY database record.

            ' Me.DataSource is the DatabaseDYNAMICS%dbo.ACTIVITY record retrieved from the database.
            ' Me.IsWebClient is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetIsWebClient()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsWebClientSpecified Then
                				
                ' If the IsWebClient is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(ACTIVITYTable.IsWebClient)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.IsWebClient.Text = formattedValue
                
            Else 
            
                ' IsWebClient is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.IsWebClient.Text = ACTIVITYTable.IsWebClient.Format(ACTIVITYTable.IsWebClient.DefaultValue)
                        		
                End If
                 
            ' If the IsWebClient is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.IsWebClient.Text Is Nothing _
                OrElse Me.IsWebClient.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.IsWebClient.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetLanguage_ID()

                  
            
        
            ' Set the Language_ID Literal on the webpage with value from the
            ' DatabaseDYNAMICS%dbo.ACTIVITY database record.

            ' Me.DataSource is the DatabaseDYNAMICS%dbo.ACTIVITY record retrieved from the database.
            ' Me.Language_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetLanguage_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Language_IDSpecified Then
                				
                ' If the Language_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(ACTIVITYTable.Language_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Language_ID.Text = formattedValue
                
            Else 
            
                ' Language_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Language_ID.Text = ACTIVITYTable.Language_ID.Format(ACTIVITYTable.Language_ID.DefaultValue)
                        		
                End If
                 
            ' If the Language_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Language_ID.Text Is Nothing _
                OrElse Me.Language_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Language_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetLOGINDAT()

                  
            
        
            ' Set the LOGINDAT Literal on the webpage with value from the
            ' DatabaseDYNAMICS%dbo.ACTIVITY database record.

            ' Me.DataSource is the DatabaseDYNAMICS%dbo.ACTIVITY record retrieved from the database.
            ' Me.LOGINDAT is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetLOGINDAT()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.LOGINDATSpecified Then
                				
                ' If the LOGINDAT is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(ACTIVITYTable.LOGINDAT, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.LOGINDAT.Text = formattedValue
                
            Else 
            
                ' LOGINDAT is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.LOGINDAT.Text = ACTIVITYTable.LOGINDAT.Format(ACTIVITYTable.LOGINDAT.DefaultValue, "g")
                        		
                End If
                 
            ' If the LOGINDAT is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.LOGINDAT.Text Is Nothing _
                OrElse Me.LOGINDAT.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.LOGINDAT.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetLOGINTIM()

                  
            
        
            ' Set the LOGINTIM Literal on the webpage with value from the
            ' DatabaseDYNAMICS%dbo.ACTIVITY database record.

            ' Me.DataSource is the DatabaseDYNAMICS%dbo.ACTIVITY record retrieved from the database.
            ' Me.LOGINTIM is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetLOGINTIM()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.LOGINTIMSpecified Then
                				
                ' If the LOGINTIM is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(ACTIVITYTable.LOGINTIM, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.LOGINTIM.Text = formattedValue
                
            Else 
            
                ' LOGINTIM is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.LOGINTIM.Text = ACTIVITYTable.LOGINTIM.Format(ACTIVITYTable.LOGINTIM.DefaultValue, "g")
                        		
                End If
                 
            ' If the LOGINTIM is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.LOGINTIM.Text Is Nothing _
                OrElse Me.LOGINTIM.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.LOGINTIM.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetSQLSESID()

                  
            
        
            ' Set the SQLSESID Literal on the webpage with value from the
            ' DatabaseDYNAMICS%dbo.ACTIVITY database record.

            ' Me.DataSource is the DatabaseDYNAMICS%dbo.ACTIVITY record retrieved from the database.
            ' Me.SQLSESID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSQLSESID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SQLSESIDSpecified Then
                				
                ' If the SQLSESID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(ACTIVITYTable.SQLSESID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SQLSESID.Text = formattedValue
                
            Else 
            
                ' SQLSESID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.SQLSESID.Text = ACTIVITYTable.SQLSESID.Format(ACTIVITYTable.SQLSESID.DefaultValue)
                        		
                End If
                 
            ' If the SQLSESID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SQLSESID.Text Is Nothing _
                OrElse Me.SQLSESID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SQLSESID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetUserId0()

                  
            
        
            ' Set the USERID Literal on the webpage with value from the
            ' DatabaseDYNAMICS%dbo.ACTIVITY database record.

            ' Me.DataSource is the DatabaseDYNAMICS%dbo.ACTIVITY record retrieved from the database.
            ' Me.UserId0 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetUserId0()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.UserId0Specified Then
                				
                ' If the USERID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(ACTIVITYTable.UserId0)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.UserId0.Text = formattedValue
                
            Else 
            
                ' USERID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.UserId0.Text = ACTIVITYTable.UserId0.Format(ACTIVITYTable.UserId0.DefaultValue)
                        		
                End If
                 
            ' If the USERID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.UserId0.Text Is Nothing _
                OrElse Me.UserId0.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.UserId0.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetCMPNYNAMLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetIsOfflineLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetIsWebClientLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLanguage_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLOGINDATLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLOGINTIMLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSQLSESIDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetUSERIDLabel()

                  
                  
                  End Sub
                

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e As FormulaEvaluator) As String
            If e Is Nothing Then
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()

            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If

            If includeDS
                
            End IF
            
            
            ' Other variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            If dataSourceForEvaluate Is Nothing Then

                e.DataSource = Me.DataSource

            Else
                e.DataSource = dataSourceForEvaluate
            End If

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If

            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function      
        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function


        Public Overridable Sub RegisterPostback()       
        
        
        End Sub

      
        
        ' To customize, override this method in ACTIVITYTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
            ' The checksum is used to ensure the record was not changed by another user.
            If (Not Me.DataSource Is Nothing) AndAlso (Not Me.DataSource.GetCheckSumValue Is Nothing) Then
                If Not Me.CheckSum Is Nothing AndAlso Me.CheckSum <> Me.DataSource.GetCheckSumValue.Value Then
                    Throw New Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "ePortalWFApproval"))
                End If
            End If
        
              
            ' 2. Perform any custom validation.
            Me.Validate()

            ' 3. Set the values in the record with data from UI controls.
            ' This calls the Get() method for each of the user interface controls.
            Me.GetUIData()

            ' 4. Save in the database.
            ' We should not save the record if the data did not change. This
            ' will save a database hit and avoid triggering any database triggers.
             
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                Me.DataSource.Save()
              
                DirectCast(GetParentControlObject(Me, "ACTIVITYTableControl"), ACTIVITYTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "ACTIVITYTableControl"), ACTIVITYTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in ACTIVITYTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetCMPNYNAM()
            GetIsOffline()
            GetIsWebClient()
            GetLanguage_ID()
            GetLOGINDAT()
            GetLOGINTIM()
            GetSQLSESID()
            GetUserId0()
        End Sub
        
        
        Public Overridable Sub GetCMPNYNAM()
            
        End Sub
                
        Public Overridable Sub GetIsOffline()
            
        End Sub
                
        Public Overridable Sub GetIsWebClient()
            
        End Sub
                
        Public Overridable Sub GetLanguage_ID()
            
        End Sub
                
        Public Overridable Sub GetLOGINDAT()
            
        End Sub
                
        Public Overridable Sub GetLOGINTIM()
            
        End Sub
                
        Public Overridable Sub GetSQLSESID()
            
        End Sub
                
        Public Overridable Sub GetUserId0()
            
        End Sub
                
      
        ' To customize, override this method in ACTIVITYTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersACTIVITYTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in ACTIVITYTableControlRow.
        Public Overridable Sub Validate() 
            ' Add custom validation for any control within this panel.
            ' Example.  If you have a State ASP:Textbox control
            ' If Me.State.Text <> "CA" Then
            '    Throw New Exception("State must be CA (California).")
            ' End If

            ' The Validate method is common across all controls within
            ' this panel so you can validate multiple fields, but report
            ' one error message.
            
                
        End Sub

        Public Overridable Sub Delete()
        
            If Me.IsNewRecord() Then
                Return
            End If

            Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
          ACTIVITYTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "ACTIVITYTableControl"), ACTIVITYTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "ACTIVITYTableControl"), ACTIVITYTableControl).ResetData = True
        End Sub

        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction()
                Me.RegisterPostback()

                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Me.LoadData()
                    Me.DataBind()			
                End If
                                
                						
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub
        
            
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()
        
    
            'Save pagination state to session.
          
        End Sub
        
        
    
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

        

            ' Clear pagination state from session.
        
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
            Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
            If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                Me.IsNewRecord = Boolean.Parse(isNewRecord)
            End If
            
            Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
            If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                Me.CheckSum = myCheckSum
            End If
            
    
            ' Load view state for pagination control.
                 
        End Sub

        Protected Overrides Function SaveViewState() As Object
            ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
            ViewState("CheckSum") = Me.CheckSum
            
    
            ' Load view state for pagination control.
                  
            Return MyBase.SaveViewState()
        End Function
        
        
    
        ' Generate set method for buttons
        
        Public Overridable Sub SetDeleteRowButton()                
              
   
        End Sub
            
        Public Overridable Sub SetEditRowButton()                
              
   
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub DeleteRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                  Me.Delete()
              
            End If
      Me.Page.CommitTransaction(sender)
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub EditRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Shared/ConfigureEditRecord.aspx"
                  
                  If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")
                  
        Dim shouldRedirect As Boolean = True
        Dim target As String = ""
      
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",True)
            url = Me.Page.ModifyRedirectUrl(url, "",True)
          
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
      Me.Page.Response.Redirect(url)
        
            End If
        End Sub
        
   
        Private _PreviousUIData As New Hashtable
        Public Overridable Property PreviousUIData() As Hashtable
            Get
                Return _PreviousUIData
            End Get
            Set(ByVal value As Hashtable)
                _PreviousUIData = value
            End Set
        End Property   

        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BaseACTIVITYTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseACTIVITYTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As ACTIVITYRecord
            Get
                Return DirectCast(MyBase._DataSource, ACTIVITYRecord)
            End Get
            Set(ByVal value As ACTIVITYRecord)
                Me._DataSource = value
            End Set
        End Property

        
        Private _checkSum As String
        Public Overridable Property CheckSum() As String
            Get
                Return Me._checkSum
            End Get
            Set(ByVal value As String)
                Me._checkSum = value
            End Set
        End Property
        
        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property
        
        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property
    
        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property
        
        

#Region "Helper Properties"
        
        Public ReadOnly Property CMPNYNAM() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CMPNYNAM"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CMPNYNAMLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CMPNYNAMLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DeleteRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DeleteRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property EditRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EditRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property IsOffline() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "IsOffline"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property IsOfflineLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "IsOfflineLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property IsWebClient() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "IsWebClient"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property IsWebClientLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "IsWebClientLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Language_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Language_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property Language_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Language_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property LOGINDAT() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LOGINDAT"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property LOGINDATLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LOGINDATLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property LOGINTIM() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LOGINTIM"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property LOGINTIMLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LOGINTIMLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SQLSESID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SQLSESID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SQLSESIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SQLSESIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property UserId0() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UserId0"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property USERIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "USERIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
        
        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As ACTIVITYRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            Return EvaluateExpressions(url, arg, rec, bEncrypt)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean,ByVal includeSession as Boolean) As String
            
            Dim rec As ACTIVITYRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            If includeSession  Then
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            Else
                Return EvaluateExpressions(url, arg, rec, bEncrypt,False)  
            End If
        End Function

         
        Public Overridable Function GetRecord() As ACTIVITYRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return ACTIVITYTable.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Throw New Exception(Page.GetResourceValue("Err:RetrieveRec", "ePortalWFApproval"))
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the ACTIVITYTableControl control on the Show_ACTIVITY_Table page.
' Do not modify this class. Instead override any method in ACTIVITYTableControl.
Public Class BaseACTIVITYTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.SortControl) 				
                    initialVal = Me.GetFromSession(Me.SortControl)
                   
              
              End If

              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                initialVal = ""
                End If
              
              If initialVal <> ""				
                        
                        Me.SortControl.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.SortControl.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.LOGINDATFromFilter) 				
                    initialVal = Me.GetFromSession(Me.LOGINDATFromFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""LOGINDATFrom"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.LOGINDATFromFilter.Text = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.LOGINDATToFilter) 				
                    initialVal = Me.GetFromSession(Me.LOGINDATToFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""LOGINDATTo"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.LOGINDATToFilter.Text = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.SearchText) 				
                    initialVal = Me.GetFromSession(Me.SearchText)
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.SearchText.Text = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.USERIDFilter) 				
                    initialVal = Me.GetFromSession(Me.USERIDFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""UserId"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Dim USERIDFilteritemListFromSession() As String = initialVal.Split(","c)
                        Dim index As Integer = 0
                        For Each item As String In USERIDFilteritemListFromSession
                            If index = 0 AndAlso _
                               item.ToString.Equals("") Then
                            Else
                                Me.USERIDFilter.Items.Add(item)
                                Me.USERIDFilter.Items.Item(index).Selected = True
                                index += 1
                            End If
                        Next
                        Dim listItem As ListItem
                        For Each listItem In Me.USERIDFilter.Items
                            listItem.Selected = True
                        Next
                            
                    End If
                
            End If

      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
         
            Else
                   
                Me.CurrentSortOrder = New OrderBy(True, False)
            
        End If

    

    ' Setup default pagination settings.
    
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
        
            
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
              AddHandler Me.Pagination.FirstPage.Click, AddressOf Pagination_FirstPage_Click
                        
              AddHandler Me.Pagination.LastPage.Click, AddressOf Pagination_LastPage_Click
                        
              AddHandler Me.Pagination.NextPage.Click, AddressOf Pagination_NextPage_Click
                        
              AddHandler Me.Pagination.PageSizeButton.Click, AddressOf Pagination_PageSizeButton_Click
                        
              AddHandler Me.Pagination.PreviousPage.Click, AddressOf Pagination_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.ExcelButton.Click, AddressOf ExcelButton_Click
                        
              AddHandler Me.ImportButton.Click, AddressOf ImportButton_Click
                        
              AddHandler Me.NewButton.Click, AddressOf NewButton_Click
                        
              AddHandler Me.PDFButton.Click, AddressOf PDFButton_Click
                        
              AddHandler Me.ResetButton.Click, AddressOf ResetButton_Click
                        
              AddHandler Me.SearchButton.Click, AddressOf SearchButton_Click
                        
              AddHandler Me.WordButton.Click, AddressOf WordButton_Click
                        
              AddHandler Me.ActionsButton.Button.Click, AddressOf ActionsButton_Click
                        
              AddHandler Me.FilterButton.Button.Click, AddressOf FilterButton_Click
                        
              AddHandler Me.FiltersButton.Button.Click, AddressOf FiltersButton_Click
                        
            AddHandler Me.SortControl.SelectedIndexChanged, AddressOf SortControl_SelectedIndexChanged
              AddHandler Me.USERIDFilter.SelectedIndexChanged, AddressOf USERIDFilter_SelectedIndexChanged                  
                        
        
          ' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "SearchTextSearchBoxText", "setSearchBoxText(""" & BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) & """, """ & SearchText.ClientID & """);", True)                  
            
        End Sub
        
        
        Public Overridable Sub LoadData()        
        
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                Dim joinFilter As CompoundFilter = CreateCompoundJoinFilter()
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(ACTIVITYRecord)), ACTIVITYRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Me._TotalRecords = 0
                    Me._TotalPages = 0
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                               
                If Me.DisplayLastPage Then
                    Dim totalRecords As Integer = If(Me._TotalRecords < 0, GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()), Me._TotalRecords)
                     
                      Dim totalPages As Integer = CInt(Math.Ceiling(totalRecords / Me.PageSize))
                    
                    Me.PageIndex = totalPages - 1
                End If                               
                
                ' Make sure PageIndex (current page) and PageSize are within bounds.
                If Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                End If
                If Me.PageSize < 1 Then
                    Me.PageSize = 1
                End If
                
                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                    Dim postdata As New ArrayList
                    For Each rc As ACTIVITYTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(ACTIVITYRecord)), ACTIVITYRecord())
                Else  ' Get the records from the database	
                      
                        Me.DataSource = GetRecords(joinFilter, wc, orderBy, Me.PageIndex, Me.PageSize)
                      
                End If
                
                ' if the datasource contains no records contained in database, then load the last page.
                If (DbUtils.GetCreatedRecords(Me.DataSource).Length = 0 AndAlso Not Me.DisplayLastPage) Then
                      Me.DisplayLastPage = True
                      LoadData()
                Else
                
                    ' Add any new rows desired by the user.
                    Me.AddNewRecords()
                       

                    ' Initialize the page and grand totals. now
                
                End If
    
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        Public Overridable Function GetRecords( _
            ByVal join As BaseFilter, _
            ByVal where As WhereClause, _
            ByVal orderBy As OrderBy, _
            ByVal pageIndex As Integer, _
            ByVal pageSize As Integer) As ACTIVITYRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(ACTIVITYTable.Column1, True)         
            ' selCols.Add(ACTIVITYTable.Column2, True)          
            ' selCols.Add(ACTIVITYTable.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return ACTIVITYTable.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New ACTIVITYTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(ACTIVITYRecord)), ACTIVITYRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(ACTIVITYTable.Column1, True)         
            ' selCols.Add(ACTIVITYTable.Column2, True)          
            ' selCols.Add(ACTIVITYTable.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return ACTIVITYTable.GetRecordCount(join, where)

            Else
                Dim databaseTable As New ACTIVITYTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)           
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
                
                Return CInt(databaseTable.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
            End If

        End Function        
        
      
    
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            
              MyBase.DataBind()
            
    
            Me.ClearControlsFromSession()    

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
            
            'LoadData for DataSource for chart and report if they exist
               
            ' Setup the pagination controls.
            BindPaginationControls()

      

    
        
          ' Bind the repeater with the list of records to expand the UI.
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ACTIVITYTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As ACTIVITYTableControlRow = DirectCast(repItem.FindControl("ACTIVITYTableControlRow"), ACTIVITYTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                
                
                
                
                
                SetLOGINDATLabel1()
                
                
                
                
                
                
                
                SetSearchText()
                SetSortByLabel()
                SetSortControl()
                
                SetUSERIDFilter()
                SetUSERIDLabel1()
                
                SetExcelButton()
              
                SetImportButton()
              
                SetNewButton()
              
                SetPDFButton()
              
                SetResetButton()
              
                SetSearchButton()
              
                SetWordButton()
              
                SetActionsButton()
              
                SetFilterButton()
              
                SetFiltersButton()
              
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
             
              SetFiltersButton()
                     
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
      
        Public Overridable Sub RegisterPostback()
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"ExcelButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"PDFButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"WordButton"))
                        
        
        End Sub

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e as FormulaEvaluator) As String
            If e Is Nothing
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()
            
            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If
            
            If includeDS
                
            End If
            
            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
            
            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function			

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function




        Public Overridable Sub ResetControl()

            
            Me.USERIDFilter.ClearSelection()
            
            Me.SortControl.ClearSelection()
            
            Me.LOGINDATFromFilter.Text = ""
            
            Me.LOGINDATToFilter.Text = ""
            
            Me.SearchText.Text = ""
            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
                
            End If
                
            Me.PageIndex = 0
        End Sub

        Public Overridable Sub ResetPageControl()
            Me.PageIndex = 0
        End Sub
        
        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the pagination labels.
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.Pagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination.CurrentPage.Text = "0"
            End If
            Me.Pagination.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for ACTIVITYTableControl pagination.
        
            Me.Pagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.Pagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As ACTIVITYTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            
          
    
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        Public Overridable Function CreateCompoundJoinFilter() As CompoundFilter
            Dim jFilter As CompoundFilter = New CompoundFilter()
         
            Return jFilter
        End Function

      
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            ACTIVITYTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersACTIVITYTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.LOGINDATFromFilter) Then
    
                hasFiltersACTIVITYTableControl = True            
    
                Dim val As String = MiscUtils.GetSelectedValue(Me.LOGINDATFromFilter, "")
                Dim d As DateTime = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT)
                    
                val = d.ToShortDateString & " " & "00:00:00"
                wc.iAND(ACTIVITYTable.LOGINDAT, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, val, False, False)
                    
            End If    
            If IsValueSelected(Me.LOGINDATToFilter) Then
    
                hasFiltersACTIVITYTableControl = True            
    
                Dim val As String = MiscUtils.GetSelectedValue(Me.LOGINDATToFilter, "")
                Dim d As DateTime = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT)
                    
                val = d.ToShortDateString & " " & "23:59:59"
                wc.iAND(ACTIVITYTable.LOGINDAT, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, val, False, False)
                    
            End If    
            If IsValueSelected(Me.SearchText) Then
              If Me.SearchText.Text = BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) Then
                 Me.SearchText.Text = ""
              Else
              ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
              
                If Me.SearchText.Text.StartsWith(BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing)) Then
                Me.SearchText.Text = ""
                Else
              
                    If Me.SearchText.Text.StartsWith("...") Then
                        Me.SearchText.Text = Me.SearchText.Text.SubString(3,Me.SearchText.Text.Length-3)
                    End If
                    If Me.SearchText.Text.EndsWith("...") then
                        Me.SearchText.Text = Me.SearchText.Text.SubString(0,Me.SearchText.Text.Length-3)
                        ' Strip the last word as well as it is likely only a partial word
                        Dim endindex As Integer = SearchText.Text.Length - 1
                        While (Not Char.IsWhiteSpace(SearchText.Text(endindex)) AndAlso endindex > 0)
                            endindex -= 1
                        End While
                        If endindex > 0 Then
                            SearchText.Text = SearchText.Text.Substring(0, endindex)
                        End If
              End If
            End If
            
              End If
            
              Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.SearchText, Me.GetFromSession(Me.SearchText))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.SearchText) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    Dim search As WhereClause = New WhereClause()
                    
      Dim cols As New ColumnList    
        
      cols.Add(ACTIVITYTable.UserId0, True)
      
      cols.Add(ACTIVITYTable.CMPNYNAM, True)
      
      For Each col As BaseColumn in cols
      
                    search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.SearchText, Me.GetFromSession(Me.SearchText)), True, False)
        
      Next
    
                    wc.iAND(search)
                End If
            End If
                  

                  Dim totalSelectedItemCount as Integer = 0
                  
            If IsValueSelected(Me.USERIDFilter) Then
    
              hasFiltersACTIVITYTableControl = True            
    
                Dim item As ListItem
                Dim selectedItemCount As Integer = 0
                For Each item In Me.USERIDFilter.Items
                    If item.Selected Then
                        selectedItemCount += 1
                        
                          totalSelectedItemCount += 1
                        
                    End If
                Next
                
                Dim filter As WhereClause = New WhereClause
                For Each item In Me.USERIDFilter.Items
                    If item.Selected AndAlso (item.Value = "--ANY--" OrElse item.Value = "--PLEASE_SELECT--") AndAlso selectedItemCount > 1 Then
                        item.Selected = False
                    End If
                    If item.Selected Then
                        filter.iOR(ACTIVITYTable.UserId0, BaseFilter.ComparisonOperator.EqualsTo, item.Value, False, False)
                    End If
                Next
                wc.iAND(filter)
                
            End If
                  
                
                       
      If (totalSelectedItemCount > 50) Then
          Throw new Exception(Page.GetResourceValue("Err:SelectedItemOverLimit", "ePortalWFApproval").Replace("{Limit}", "50").Replace("{SelectedCount}", totalSelectedItemCount.ToString()))
      End If
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            ACTIVITYTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersACTIVITYTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim LOGINDATFromFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "LOGINDATFromFilter_Ajax"), String)
            If IsValueSelected(LOGINDATFromFilterSelectedValue) Then
    
                hasFiltersACTIVITYTableControl = True            
    
                Dim d as DateTime = DateParser.ParseDate(LOGINDATFromFilterSelectedValue, DateColumn.DEFAULT_FORMAT)
                LOGINDATFromFilterSelectedValue = d.ToShortDateString & " " & "00:00:00"
                wc.iAND(ACTIVITYTable.LOGINDAT, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, LOGINDATFromFilterSelectedValue, False, False)
                    
            End If    
            Dim LOGINDATToFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "LOGINDATToFilter_Ajax"), String)
            If IsValueSelected(LOGINDATToFilterSelectedValue) Then
    
                hasFiltersACTIVITYTableControl = True            
    
                Dim d as DateTime = DateParser.ParseDate(LOGINDATToFilterSelectedValue, DateColumn.DEFAULT_FORMAT)
                LOGINDATToFilterSelectedValue = d.ToShortDateString & " " & "23:59:59"
                wc.iAND(ACTIVITYTable.LOGINDAT, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, LOGINDATToFilterSelectedValue, False, False)
                    
            End If    
            If IsValueSelected(searchText) and fromSearchControl = "SearchText" Then
                Dim formatedSearchText as String = searchText
                ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                If searchText.StartsWith("...") Then
                    formatedSearchText = searchText.SubString(3,searchText.Length-3)
                End If
                If searchText.EndsWith("...") Then
                    formatedSearchText = searchText.SubString(0,searchText.Length-3)
                    ' Strip the last word as well as it is likely only a partial word
                    Dim endindex As Integer = searchText.Length - 1
                    While (Not Char.IsWhiteSpace(searchText(endindex)) AndAlso endindex > 0)
                        endindex -= 1
                    End While
                    If endindex > 0 Then
                        searchText = searchText.Substring(0, endindex)
                    End If
                End If
                'After stripping "...", trim any leading and trailing whitespaces 
                formatedSearchText = formatedSearchText.Trim()
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(formatedSearchText) Then
                      ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    Dim search As WhereClause = New WhereClause()
                    
                    If InvariantLCase(AutoTypeAheadSearch).equals("wordsstartingwithsearchstring") Then
                
      Dim cols As New ColumnList    
        
      cols.Add(ACTIVITYTable.UserId0, True)
      
      cols.Add(ACTIVITYTable.CMPNYNAM, True)
      
      For Each col As BaseColumn in cols
      
                        search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
      Next
    
                    Else
                        
      Dim cols As New ColumnList    
        
      cols.Add(ACTIVITYTable.UserId0, True)
      
      cols.Add(ACTIVITYTable.CMPNYNAM, True)
      
      For Each col As BaseColumn in cols
      
                        search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
      Next
    
                    End If
                    wc.iAND(search)
                End If
            End If
                  
            Dim USERIDFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "USERIDFilter_Ajax"), String)
            If IsValueSelected(USERIDFilterSelectedValue) Then
    
              hasFiltersACTIVITYTableControl = True            
    
            If Not isNothing(USERIDFilterSelectedValue) Then
                Dim USERIDFilteritemListFromSession() As String = USERIDFilterSelectedValue.Split(","c)
                Dim index As Integer = 0
                  
                Dim filter As WhereClause = New WhereClause
                For Each item As String In USERIDFilteritemListFromSession
                    If index = 0 AndAlso item.ToString.Equals("") Then
                    Else
                        filter.iOR(ACTIVITYTable.UserId0, BaseFilter.ComparisonOperator.EqualsTo, item, False, False)
                        index += 1
                    End If
                Next
                wc.iAND(filter)
                
             End If
                
             End If
                      
      
      
            Return wc
        End Function

      
        Public Overridable Function GetAutoCompletionList_SearchText(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            
            Dim filterJoin As CompoundFilter = CreateCompoundJoinFilter()
            If count = 0 Then count = 10
            Dim wc As WhereClause = CreateWhereClause(prefixText,"SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            Dim recordList () As ePortalWFApproval.Business.ACTIVITYRecord = ACTIVITYTable.GetRecords(filterJoin, wc, Nothing, 0, count,count)
            Dim rec As ACTIVITYRecord = Nothing
            Dim resultItem As String = ""
            For Each rec In recordList 
                ' Exit the loop if recordList count has reached AutoTypeAheadListSize.
                If resultList.Count >= count then
                    Exit For
                End If
                ' If the field is configured to Display as Foreign key, Format() method returns the 
                ' Display as Forien Key value instead of original field value.
                ' Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                ' We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(ACTIVITYTable.UserId0)
                If resultItem IsNot Nothing Then
                    Dim prText As String = prefixText
                    If ACTIVITYTable.UserId0.IsFullTextSearchable Then
                         Dim ft As FullTextExpression = New FullTextExpression()
                         prText = ft.GetFirstNonExcludedTerm(prText)
                    End If
                    If Not String.IsNullOrEmpty(prText) AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
  
                        Dim isAdded As Boolean = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, ACTIVITYTable.UserId0.IsFullTextSearchable)
                        If isAdded Then
                            Continue For
                        End If
                    End If
                End If
      
                resultItem = rec.Format(ACTIVITYTable.CMPNYNAM)
                If resultItem IsNot Nothing Then
                    Dim prText As String = prefixText
                    If ACTIVITYTable.CMPNYNAM.IsFullTextSearchable Then
                         Dim ft As FullTextExpression = New FullTextExpression()
                         prText = ft.GetFirstNonExcludedTerm(prText)
                    End If
                    If Not String.IsNullOrEmpty(prText) AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
  
                        Dim isAdded As Boolean = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, ACTIVITYTable.CMPNYNAM.IsFullTextSearchable)
                        If isAdded Then
                            Continue For
                        End If
                    End If
                End If
      
            Next                
             
            resultList.Sort()
            Dim result() As String = New String(resultList.Count - 1) {}
            Array.Copy(resultList.ToArray, result, resultList.Count)
            Return result
        End Function
          

         Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                         ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                         ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                         ByVal resultList As ArrayList) As Boolean
              Return FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText, _
                                       autoTypeAheadSearch, AutoTypeAheadWordSeparators, _
                                       resultList, False)
         End Function

        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                               ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                               ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                               ByVal resultList As ArrayList, ByVal stripHTML As Boolean) As Boolean
            If stripHTML Then
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText)
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem)
            End If
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If Not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                End If
            End If

            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") Then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    '  Find the beginning of the word which contains prefexText
                    If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                    If Len(resultItem) - index <= columnLength Then
                        If index = 0 Then
                            itemToAdd = resultItem
                        Else                            
                            itemToAdd = resultItem.Substring(index)
                        End If
                    Else                       
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward)
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength / 2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) >= Len(resultItem) - 1 OrElse _
                        Len(resultItem) - index < subStringBeginIndex Then                           
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, Len(resultItem) - 1 - columnLength, Len(resultItem) - 1, StringUtils.Direction.backward)
                        ElseIf index <= subStringBeginIndex Then
                            ' Sanity check at beginning of the string                          
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward)
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText                         
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both)
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                    ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    ' Find the ending of the word which contains prefexText
                    If regex1.IsMatch(resultItem, index + 1) Then
                        index = regex1.Match(resultItem, index + 1).Index
                    Else
                        ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length
                    End If
                    If index > Len(resultItem) Then
                        index = Len(resultItem)
                    End If
                    ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    If index <= columnLength Then
                        itemToAdd = resultItem.Substring(0, index)
                    Else
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward)
                    End If
                End If

                ' Remove newline character from itemToAdd
                Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                If prefixTextIndex < 0 Then Return False
                ' If itemToAdd contains any newline after the search text then show text only till newline
                Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                Dim newLineIndexAfterPrefix As Integer = -1
                If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexAfterPrefix > -1) Then
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                End If
                ' If itemToAdd contains any newline before search text then show text which comes after newline
                Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                Dim newLineIndexBeforePrefix As Integer = -1
                If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexBeforePrefix > -1) Then
                    itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                End If

                If Not String.IsNullOrEmpty(itemToAdd) AndAlso Not resultList.Contains(itemToAdd) Then
                   
                    resultList.Add(itemToAdd)
          				
                    isAdded = True
                End If
            End If
            Return isAdded
        End Function
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.Pagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pagination.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
          
            Dim newRecordList As ArrayList = New ArrayList()
          
    Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()

    ' Loop though all the record controls and if the record control
    ' does not have a unique record id set, then create a record
    ' and add to the list.
    If Not Me.ResetData Then
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ACTIVITYTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As ACTIVITYTableControlRow = DirectCast(repItem.FindControl("ACTIVITYTableControlRow"), ACTIVITYTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As ACTIVITYRecord = New ACTIVITYRecord()
        
                        If recControl.CMPNYNAM.Text <> "" Then
                            rec.Parse(recControl.CMPNYNAM.Text, ACTIVITYTable.CMPNYNAM)
                        End If
                        If recControl.IsOffline.Text <> "" Then
                            rec.Parse(recControl.IsOffline.Text, ACTIVITYTable.IsOffline)
                        End If
                        If recControl.IsWebClient.Text <> "" Then
                            rec.Parse(recControl.IsWebClient.Text, ACTIVITYTable.IsWebClient)
                        End If
                        If recControl.Language_ID.Text <> "" Then
                            rec.Parse(recControl.Language_ID.Text, ACTIVITYTable.Language_ID)
                        End If
                        If recControl.LOGINDAT.Text <> "" Then
                            rec.Parse(recControl.LOGINDAT.Text, ACTIVITYTable.LOGINDAT)
                        End If
                        If recControl.LOGINTIM.Text <> "" Then
                            rec.Parse(recControl.LOGINTIM.Text, ACTIVITYTable.LOGINTIM)
                        End If
                        If recControl.SQLSESID.Text <> "" Then
                            rec.Parse(recControl.SQLSESID.Text, ACTIVITYTable.SQLSESID)
                        End If
                        If recControl.UserId0.Text <> "" Then
                            rec.Parse(recControl.UserId0.Text, ACTIVITYTable.UserId0)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New ACTIVITYRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(ACTIVITYRecord)), ACTIVITYRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As ACTIVITYTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As ACTIVITYTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetLOGINDATLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSortByLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SortByLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetUSERIDLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSortControl()

              
            
                Me.PopulateSortControl(GetSelectedValue(Me.SortControl,  GetFromSession(Me.SortControl)), 500)					
                    
        End Sub
            
        Public Overridable Sub SetSearchText()

              
                                            
          Me.SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "') {this.value='';this.className='Search_Input';}")
          Me.SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "';this.className='Search_InputHint';}")
                                   
              End Sub	
            
        Public Overridable Sub SetUSERIDFilter()

              
            
            Dim USERIDFilterselectedFilterItemList As New ArrayList()
            Dim USERIDFilteritemsString As String = Nothing
            If (Me.InSession(Me.USERIDFilter)) Then
                USERIDFilteritemsString = Me.GetFromSession(Me.USERIDFilter)
            End If
            
            If (USERIDFilteritemsString IsNot Nothing) Then
                Dim USERIDFilteritemListFromSession() As String = USERIDFilteritemsString.Split(","c)
                For Each item as String In USERIDFilteritemListFromSession
                    USERIDFilterselectedFilterItemList.Add(item)
                Next
            End If
              
            		
            Me.PopulateUSERIDFilter(GetSelectedValueList(Me.USERIDFilter, USERIDFilterselectedFilterItemList), 500)
                    
              Dim url as String = Me.ModifyRedirectUrl("../ACTIVITY/ACTIVITY-QuickSelector.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.USERIDFilter.ClientID & "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("USERID")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--ANY--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:All")) & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.USERIDFilter.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(USERIDFilter.AutoPostBack).ToLower() & ", event); return false;"        
                  
                                 
              End Sub	
            
        ' Get the filters' data for SortControl
        Protected Overridable Sub PopulateSortControl(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
                Me.SortControl.Items.Clear()

                ' 1. Setup the static list items
                							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Cmpnynam {Txt:Ascending}"), "CMPNYNAM Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Cmpnynam {Txt:Descending}"), "CMPNYNAM Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Is Offline {Txt:Ascending}"), "IsOffline Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Is Offline {Txt:Descending}"), "IsOffline Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Is Web Client {Txt:Ascending}"), "IsWebClient Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Is Web Client {Txt:Descending}"), "IsWebClient Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Language {Txt:Ascending}"), "Language_ID Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Language {Txt:Descending}"), "Language_ID Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Logindat {Txt:Ascending}"), "LOGINDAT Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Logindat {Txt:Descending}"), "LOGINDAT Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Logintim {Txt:Ascending}"), "LOGINTIM Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Logintim {Txt:Descending}"), "LOGINTIM Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Sqlses {Txt:Ascending}"), "SQLSESID Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Sqlses {Txt:Descending}"), "SQLSESID Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("User {Txt:Ascending}"), "USERID Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("User {Txt:Descending}"), "USERID Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl.SelectedValue IsNot Nothing AndAlso Me.SortControl.Items.FindByValue(Me.SortControl.SelectedValue) Is Nothing
                Me.SortControl.SelectedValue = Nothing
            End If

              End Sub
            
        ' Get the filters' data for USERIDFilter
        Protected Overridable Sub PopulateUSERIDFilter(ByVal selectedValue As ArrayList, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Dim wc As WhereClause = Me.CreateWhereClause_USERIDFilter()
            Me.USERIDFilter.Items.Clear()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_USERIDFilter function.
            ' It is better to customize the where clause there.
            
            
            
            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(ACTIVITYTable.UserId0, OrderByItem.OrderDir.Asc)                
            
            	

            Dim values(-1) As String
            If wc.RunQuery Then
            
                values = ACTIVITYTable.GetValues(ACTIVITYTable.UserId0, wc, orderBy, maxItems)
            
            End If
            
                  
            Dim cvalue As String
            
            Dim listDuplicates As New ArrayList()
            For Each cvalue In values
                ' Create the item and add to the list.
                Dim fvalue As String
                If ( ACTIVITYTable.UserId0.IsColumnValueTypeBoolean()) Then
                    fvalue = cvalue
                Else
                    fvalue = ACTIVITYTable.UserId0.Format(cvalue)
                End If

                If (IsNothing(fvalue)) Then
                    fvalue = ""
                End If

                fvalue = fvalue.Trim()

                If ( fvalue.Length > 50 ) Then
                    fvalue = fvalue.Substring(0, 50) & "..."
                End If

                Dim dupItem As ListItem = Me.USERIDFilter.Items.FindByText(fvalue)
                
                If Not IsNothing(dupItem) Then
                    listDuplicates.Add(fvalue)
                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                    End If
                End If

                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                Me.USERIDFilter.Items.Add(newItem)

                If listDuplicates.Contains(fvalue)  AndAlso Not String.IsNullOrEmpty(cvalue) Then
                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                End If
            Next
                                  

            Try    
                
            Catch
            End Try
            
            
            Me.USERIDFilter.SetFieldMaxLength(50)
                                 
                  
            ' Add the selected value.
            If Me.USERIDFilter.Items.Count = 0 Then
                Me.USERIDFilter.Items.Add(New ListItem(Page.GetResourceValue("Txt:All", "ePortalWFApproval"), "--ANY--"))
            End If
            
            ' Mark all items to be selected.
            For Each item As ListItem in Me.USERIDFilter.Items
                item.Selected = True
            Next
                              
        End Sub
            
              

        Public Overridable Function CreateWhereClause_USERIDFilter() As WhereClause
          
              Dim hasFiltersACTIVITYTableControl As Boolean = False
            
            ' Create a where clause for the filter USERIDFilter.
            ' This function is called by the Populate method to load the items 
            ' in the USERIDFilterQuickSelector
            
            Dim USERIDFilterselectedFilterItemList As New ArrayList()
            Dim USERIDFilteritemsString As String = Nothing
            If (Me.InSession(Me.USERIDFilter)) Then
                USERIDFilteritemsString = Me.GetFromSession(Me.USERIDFilter)
            End If
            
            If (USERIDFilteritemsString IsNot Nothing) Then
                Dim USERIDFilteritemListFromSession() As String = USERIDFilteritemsString.Split(","c)
                For Each item as String In USERIDFilteritemListFromSession
                    USERIDFilterselectedFilterItemList.Add(item)
                Next
            End If
              
            USERIDFilterselectedFilterItemList = GetSelectedValueList(Me.USERIDFilter, USERIDFilterselectedFilterItemList) 
            Dim wc As New WhereClause
            If USERIDFilterselectedFilterItemList Is Nothing OrElse USERIDFilterselectedFilterItemList.Count = 0 Then
                wc.RunQuery = False
            Else            
                For Each item As String In USERIDFilterselectedFilterItemList
              
            
      
   
                    wc.iOR(ACTIVITYTable.UserId0, BaseFilter.ComparisonOperator.EqualsTo, item)

                                
                Next
            End If
            Return wc
        
        End Function			
            

    
    
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
                Me.RegisterPostback()
                
                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    Me.LoadData()
                    Me.DataBind()
                    
                End If
                
               
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
            Me.SaveToSession(Me.SortControl, Me.SortControl.SelectedValue)
                  
            Me.SaveToSession(Me.LOGINDATFromFilter, Me.LOGINDATFromFilter.Text)
                  
            Me.SaveToSession(Me.LOGINDATToFilter, Me.LOGINDATToFilter.Text)
                  
            Me.SaveToSession(Me.SearchText, Me.SearchText.Text)
                  
            Dim USERIDFilterselectedFilterItemList As ArrayList = GetSelectedValueList(Me.USERIDFilter, Nothing)
            Dim USERIDFilterSessionString As String = ""
            If Not USERIDFilterselectedFilterItemList is Nothing Then
            For Each item As String In USERIDFilterselectedFilterItemList
                USERIDFilterSessionstring = USERIDFilterSessionstring & "," & item
            Next
            End If
            Me.SaveToSession(Me.USERIDFilter, USERIDFilterSessionstring)
                  
        
            'Save pagination state to session.
         
            
            ' Save table control properties to the session.
            
 If Not Me.CurrentSortOrder Is Nothing Then
                If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then
                    Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
                End If
            End If            
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            Me.SaveToSession(Me.SortControl, Me.SortControl.SelectedValue)
                  
      Me.SaveToSession("LOGINDATFromFilter_Ajax", Me.LOGINDATFromFilter.Text)
              
      Me.SaveToSession("LOGINDATToFilter_Ajax", Me.LOGINDATToFilter.Text)
              
      Me.SaveToSession("SearchText_Ajax", Me.SearchText.Text)
              
            Dim USERIDFilterselectedFilterItemList As ArrayList = GetSelectedValueList(Me.USERIDFilter, Nothing)
            Dim USERIDFilterSessionString As String = ""
            If Not USERIDFilterselectedFilterItemList is Nothing Then
            For Each item As String In USERIDFilterselectedFilterItemList
                USERIDFilterSessionstring = USERIDFilterSessionstring & "," & item
            Next
            End If
            Me.SaveToSession("USERIDFilter_Ajax", USERIDFilterSessionString)
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl)
            Me.RemoveFromSession(Me.LOGINDATFromFilter)
            Me.RemoveFromSession(Me.LOGINDATToFilter)
            Me.RemoveFromSession(Me.SearchText)
            Me.RemoveFromSession(Me.USERIDFilter)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("ACTIVITYTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("Pagination")
             Dim PaginationType As String = ""
             If Not (Pagination Is Nothing) Then
                Dim Summary As Control = Pagination.FindControl("_Summary")
                If Not (Summary Is Nothing) Then
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination")) Then
                        PaginationType = "Infinite Pagination"
                    End If
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination Mobile")) Then
                        PaginationType = "Infinite Pagination Mobile"
                End If
             End If
             End If

            If Not (PaginationType.Equals("Infinite Pagination")) Then 
              If Not Me.Page.ClientQueryString.Contains("InfiIframe") AndAlso PaginationType.Equals("Infinite Pagination Mobile") Then
                    Me.ViewState("Page_Index") = 0
                End If
              Dim pageIndex As String = CType(ViewState("Page_Index"), String)
              If pageIndex IsNot Nothing Then
                Me.PageIndex = CInt(pageIndex)
              End If
            End If

            Dim pageSize As String = CType(ViewState("Page_Size"), String)
            If Not pageSize Is Nothing Then
              Me.PageSize = CInt(pageSize)
            End If

            
    
            ' Load view state for pagination control.
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
          
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("ACTIVITYTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetExcelButton()                
              
   
        End Sub
            
        Public Overridable Sub SetImportButton()                
              							
                    Me.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=ACTIVITY" 
                    Me.ImportButton.Attributes.Item("onClick") = "window.open('" & Me.Page.EncryptUrlParameter(Me.ImportButton.PostBackUrl) & "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;"
                        
   
        End Sub
            
        Public Overridable Sub SetNewButton()                
              
              Try        
                    Dim url as String = "../Shared/ConfigureAddRecord.aspx?TabVisible=False&SaveAndNewVisible=False"
              
                      
                    url = Me.ModifyRedirectUrl(url, "", True)
                    
                    url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
                    
                    url = url & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup") & "&Target=" & CType(Me.Page, BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(Me, "ACTIVITYTableControl_PostbackTracker").ClientID)                           
                                
                Dim javascriptCall as String = ""
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" & MiscUtils.FindControlRecursively(Me, "ACTIVITYTableControl_PostbackTracker").ClientID & "'), '" & url & "', true, event);"                                      
                       
                    Me.NewButton.Attributes.Item("onClick") = javascriptCall & "return false;"                  
                Catch
                    ' do nothing.  If the code above fails, server side click event, NewButton_ClickNewButton_Click will be trigger when user click the button.
                End Try
                  
   
        End Sub
            
        Public Overridable Sub SetPDFButton()                
              
   
        End Sub
            
        Public Overridable Sub SetResetButton()                
              
   
        End Sub
            
        Public Overridable Sub SetSearchButton()                
              
   
        End Sub
            
        Public Overridable Sub SetWordButton()                
              
   
        End Sub
            
        Public Overridable Sub SetActionsButton()                
              
   
        End Sub
            
        Public Overridable Sub SetFilterButton()                
              
   
        End Sub
            
        Public Overridable Sub SetFiltersButton()                
                      
         Dim themeButtonFiltersButton As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "FiltersButton"), IThemeButtonWithArrow)
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
    
      
            If (IsValueSelected(USERIDFilter)) Then
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png"
            End If
        
   
        End Sub
                    

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub Pagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.Pagination.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.Pagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub ExcelButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            ' To customize the columns or the format, override this function in Section 1 of the page 
            ' and modify it to your liking.
            ' Build the where clause based on the current filter and search criteria
            ' Create the Order By clause based on the user's current sorting preference.
          
              Dim wc As WhereClause = CreateWhereClause
              Dim orderBy As OrderBy = Nothing
              
              orderBy = CreateOrderBy
              
              Dim done As Boolean = False
              Dim val As Object = ""
              ' Read pageSize records at a time and write out the Excel file.
              Dim totalRowsReturned As Integer = 0
          
              Dim join As CompoundFilter = CreateCompoundJoinFilter()
              Me.TotalRecords = ACTIVITYTable.GetRecordCount(join, wc)
              If Me.TotalRecords > 10000 Then
          
              ' Add each of the columns in order of export.
              Dim columns() as BaseColumn = New BaseColumn() { _
                         ACTIVITYTable.UserId0, _ 
             ACTIVITYTable.CMPNYNAM, _ 
             ACTIVITYTable.LOGINDAT, _ 
             ACTIVITYTable.LOGINTIM, _ 
             ACTIVITYTable.SQLSESID, _ 
             ACTIVITYTable.Language_ID, _ 
             ACTIVITYTable.IsWebClient, _ 
             ACTIVITYTable.IsOffline, _ 
             Nothing}
              Dim  exportData as ExportDataToCSV = New ExportDataToCSV(ACTIVITYTable.Instance, wc, orderBy, columns)
              exportData.StartExport(Me.Page.Response, True)

              Dim dataForCSV As DataForExport = New DataForExport(ACTIVITYTable.Instance, wc, orderBy, columns, join)

              '  Read pageSize records at a time and write out the CSV file.
              While (Not done)
                  Dim recList As ArrayList = dataForCSV.GetRows(exportData.pageSize)
                  If recList Is Nothing Then
                      Exit While 'no more records we are done
                  End If

                  totalRowsReturned = recList.Count
                  For Each rec As BaseRecord In recList
                      For Each col As BaseColumn In dataForCSV.ColumnList
                          If col Is Nothing Then
                              Continue For
                          End If

                          If Not dataForCSV.IncludeInExport(col) Then
                              Continue For
                          End If

                          val = rec.GetValue(col).ToString()
                          exportData.WriteColumnData(val, dataForCSV.IsString(col))

                      Next col
                      exportData.WriteNewRow()
                  Next rec

                  '  If we already are below the pageSize, then we are done.
                  If totalRowsReturned < exportData.pageSize Then
                      done = True
                  End If
              End While
              exportData.FinishExport(Me.Page.Response)
          Else
          
              ' Create an instance of the Excel report class with the table class, where clause and order by.
              Dim excelReport As ExportDataToExcel = New ExportDataToExcel(ACTIVITYTable.Instance, wc, orderBy)
              ' Add each of the columns in order of export.
              ' To customize the data type, change the second parameter of the new ExcelColumn to be
              ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              If Me.Page.Response Is Nothing Then
                Return
              End If

              excelReport.CreateExcelBook()

              Dim width As Integer = 0
              Dim columnCounter As Integer = 0
              Dim data As DataForExport = New DataForExport(ACTIVITYTable.Instance, wc, orderBy, Nothing, join)
                       data.ColumnList.Add(New ExcelColumn(ACTIVITYTable.UserId0, "Default"))
             data.ColumnList.Add(New ExcelColumn(ACTIVITYTable.CMPNYNAM, "Default"))
             data.ColumnList.Add(New ExcelColumn(ACTIVITYTable.LOGINDAT, "Short Date"))
             data.ColumnList.Add(New ExcelColumn(ACTIVITYTable.LOGINTIM, "Short Date"))
             data.ColumnList.Add(New ExcelColumn(ACTIVITYTable.SQLSESID, "0"))
             data.ColumnList.Add(New ExcelColumn(ACTIVITYTable.Language_ID, "0"))
             data.ColumnList.Add(New ExcelColumn(ACTIVITYTable.IsWebClient, "0"))
             data.ColumnList.Add(New ExcelColumn(ACTIVITYTable.IsOffline, "0"))


              For Each col As ExcelColumn In data.ColumnList
                  width = excelReport.GetExcelCellWidth(col)
                  If data.IncludeInExport(col) Then
                      excelReport.AddColumnToExcelBook(columnCounter, col.ToString(), excelReport.GetExcelDataType(col), width, excelReport.GetDisplayFormat(col))
                      columnCounter = columnCounter + 1
                  End If
              Next col
              
              While (Not done)
                  Dim recList As ArrayList = data.GetRows(excelReport.pageSize)

                  If recList Is Nothing Then
                      Exit While 'no more records we are done
                  End If

                  totalRowsReturned = recList.Count

                  For Each rec As BaseRecord In recList
                      excelReport.AddRowToExcelBook()
                      columnCounter = 0

                      For Each col As ExcelColumn In data.ColumnList
                          If Not data.IncludeInExport(col) Then
                              Continue For
                          End If

                          Dim _isExpandableNonCompositeForeignKey As Boolean = col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn)
                          If _isExpandableNonCompositeForeignKey AndAlso col.DisplayColumn.IsApplyDisplayAs Then
                              val = ACTIVITYTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, Nothing)
                              If val Is Nothing Then
                                  val = rec.Format(col.DisplayColumn)
                              End If
                          Else
                              val = excelReport.GetValueForExcelExport(col, rec)
                          End If
                          excelReport.AddCellToExcelRow(columnCounter, excelReport.GetExcelDataType(col), val, col.DisplayFormat)

                          columnCounter = columnCounter + 1
                      Next col
                  Next rec

                  ' If we already are below the pageSize, then we are done.
                  If totalRowsReturned < excelReport.pageSize Then
                      done = True
                  End If
              End While

              excelReport.SaveExcelBook(Me.Page.Response)
          End If
        
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub ImportButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub NewButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Shared/ConfigureAddRecord.aspx?TabVisible=False&SaveAndNewVisible=False"
                  
                  If Me.Page.Request("RedirectStyle") <> "" Then url &= "&RedirectStyle=" & Me.Page.Request("RedirectStyle")
                  
        Dim shouldRedirect As Boolean = True
        Dim target As String = ""
      
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",True)
            url = Me.Page.ModifyRedirectUrl(url, "",True)
          
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
      
                    url = url & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup") & "&Target=" & CType(Me.Page, BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(Me, "ACTIVITYTableControl_PostbackTracker").ClientID)                           
                                
                Dim javascriptCall as String = ""
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" & MiscUtils.FindControlRecursively(Me, "ACTIVITYTableControl_PostbackTracker").ClientID & "'), '" & url & "', true, event);"                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "NewButton_Click", javascriptCall, True)
        
            End If
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub PDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("Show-ACTIVITY-Table.PDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "ACTIVITY"
                ' If Show-ACTIVITY-Table.PDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(ACTIVITYTable.UserId0.Name, ReportEnum.Align.Left, "${UserId0}", ReportEnum.Align.Left, 15)
                 report.AddColumn(ACTIVITYTable.CMPNYNAM.Name, ReportEnum.Align.Left, "${CMPNYNAM}", ReportEnum.Align.Left, 28)
                 report.AddColumn(ACTIVITYTable.LOGINDAT.Name, ReportEnum.Align.Left, "${LOGINDAT}", ReportEnum.Align.Left, 20)
                 report.AddColumn(ACTIVITYTable.LOGINTIM.Name, ReportEnum.Align.Left, "${LOGINTIM}", ReportEnum.Align.Left, 20)
                 report.AddColumn(ACTIVITYTable.SQLSESID.Name, ReportEnum.Align.Right, "${SQLSESID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(ACTIVITYTable.Language_ID.Name, ReportEnum.Align.Right, "${Language_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(ACTIVITYTable.IsWebClient.Name, ReportEnum.Align.Right, "${IsWebClient}", ReportEnum.Align.Right, 15)
                 report.AddColumn(ACTIVITYTable.IsOffline.Name, ReportEnum.Align.Right, "${IsOffline}", ReportEnum.Align.Right, 15)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
                
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = ACTIVITYTable.GetRecordCount(joinFilter,whereClause)
                Dim columns As ColumnList = ACTIVITYTable.GetColumnList()
                Dim records As ACTIVITYRecord() = Nothing
            
                Do 
                    
                    records = ACTIVITYTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As ACTIVITYRecord In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${UserId0}", record.Format(ACTIVITYTable.UserId0), ReportEnum.Align.Left, 300)
                             report.AddData("${CMPNYNAM}", record.Format(ACTIVITYTable.CMPNYNAM), ReportEnum.Align.Left, 300)
                             report.AddData("${LOGINDAT}", record.Format(ACTIVITYTable.LOGINDAT), ReportEnum.Align.Left, 300)
                             report.AddData("${LOGINTIM}", record.Format(ACTIVITYTable.LOGINTIM), ReportEnum.Align.Left, 300)
                             report.AddData("${SQLSESID}", record.Format(ACTIVITYTable.SQLSESID), ReportEnum.Align.Right, 300)
                             report.AddData("${Language_ID}", record.Format(ACTIVITYTable.Language_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${IsWebClient}", record.Format(ACTIVITYTable.IsWebClient), ReportEnum.Align.Right, 300)
                             report.AddData("${IsOffline}", record.Format(ACTIVITYTable.IsOffline), ReportEnum.Align.Right, 300)

                            report.WriteRow 
                        Next 
                        pageNum = pageNum + 1
                        recordCount += records.Length 
                    End If 
                Loop While Not (records Is Nothing) AndAlso recordCount < totalRows  AndAlso whereClause.RunQuery 
                
                report.Close 
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(Me.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, true)
          
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub ResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
              Me.USERIDFilter.ClearSelection()
            Me.SortControl.ClearSelection()
              Me.LOGINDATFromFilter.Text = ""
              Me.LOGINDATToFilter.Text = ""
              Me.SearchText.Text = ""
              Me.CurrentSortOrder.Reset()
              If Me.InSession(Me, "Order_By") Then
                  Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
              Else
                  Me.CurrentSortOrder = New OrderBy(True, False)
                  

              End If
              

        ' Setting the DataChanged to True results in the page being refreshed with
        ' the most recent data from the database.  This happens in PreRender event
        ' based on the current sort, search and filter criteria.
        Me.DataChanged = True
            
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub SearchButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
          Me.DataChanged = True
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub WordButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("Show-ACTIVITY-Table.WordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "ACTIVITY"
                ' If Show-ACTIVITY-Table.WordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(ACTIVITYTable.UserId0.Name, ReportEnum.Align.Left, "${UserId0}", ReportEnum.Align.Left, 15)
                 report.AddColumn(ACTIVITYTable.CMPNYNAM.Name, ReportEnum.Align.Left, "${CMPNYNAM}", ReportEnum.Align.Left, 28)
                 report.AddColumn(ACTIVITYTable.LOGINDAT.Name, ReportEnum.Align.Left, "${LOGINDAT}", ReportEnum.Align.Left, 20)
                 report.AddColumn(ACTIVITYTable.LOGINTIM.Name, ReportEnum.Align.Left, "${LOGINTIM}", ReportEnum.Align.Left, 20)
                 report.AddColumn(ACTIVITYTable.SQLSESID.Name, ReportEnum.Align.Right, "${SQLSESID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(ACTIVITYTable.Language_ID.Name, ReportEnum.Align.Right, "${Language_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(ACTIVITYTable.IsWebClient.Name, ReportEnum.Align.Right, "${IsWebClient}", ReportEnum.Align.Right, 15)
                 report.AddColumn(ACTIVITYTable.IsOffline.Name, ReportEnum.Align.Right, "${IsOffline}", ReportEnum.Align.Right, 15)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = ACTIVITYTable.GetRecordCount(joinFilter,whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = ACTIVITYTable.GetColumnList()
                Dim records As ACTIVITYRecord() = Nothing
                Do
                    records = ACTIVITYTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As ACTIVITYRecord In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${UserId0}", record.Format(ACTIVITYTable.UserId0), ReportEnum.Align.Left, 300)
                             report.AddData("${CMPNYNAM}", record.Format(ACTIVITYTable.CMPNYNAM), ReportEnum.Align.Left, 300)
                             report.AddData("${LOGINDAT}", record.Format(ACTIVITYTable.LOGINDAT), ReportEnum.Align.Left, 300)
                             report.AddData("${LOGINTIM}", record.Format(ACTIVITYTable.LOGINTIM), ReportEnum.Align.Left, 300)
                             report.AddData("${SQLSESID}", record.Format(ACTIVITYTable.SQLSESID), ReportEnum.Align.Right, 300)
                             report.AddData("${Language_ID}", record.Format(ACTIVITYTable.Language_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${IsWebClient}", record.Format(ACTIVITYTable.IsWebClient), ReportEnum.Align.Right, 300)
                             report.AddData("${IsOffline}", record.Format(ACTIVITYTable.IsOffline), ReportEnum.Align.Right, 300)

                            report.WriteRow
                        Next
                        pageNum = pageNum + 1
                        recordCount += records.Length
                    End If
                Loop While Not (records Is Nothing) AndAlso recordCount < totalRows AndAlso whereClause.RunQuery 
                report.save
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(Me.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, true)
          
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub ActionsButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            'This method is initially empty to implement custom click handler.
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub FilterButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
          Me.DataChanged = True
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub FiltersButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            'This method is initially empty to implement custom click handler.
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
      

        ' Generate the event handling functions for filter and search events.
        
        ' event handler for OrderSort
        Protected Overridable Sub SortControl_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
        
                Dim SelVal1 As String = Me.SortControl.SelectedValue.ToUpper()
                Dim words1() As String = Split(SelVal1)
                If SelVal1 <> "" Then
                SelVal1 = SelVal1.Replace(words1(words1.Length() - 1), "").TrimEnd()
                For Each ColumnNam As BaseClasses.Data.BaseColumn In ACTIVITYTable.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(ACTIVITYTable.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not ACTIVITYTable.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not ACTIVITYTable.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(ACTIVITYTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(ACTIVITYTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub USERIDFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = ACTIVITYTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
                End If
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                  
                End If
                Me._TotalRecords = value
            End Set
        End Property

        
    
        Protected _TotalPages As Integer = -1
        Public Property TotalPages() As Integer
            Get
                If _TotalPages < 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(TotalRecords / Me.PageSize))
                  
                End If                
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Protected _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property


          
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Public Property DataSource() As ACTIVITYRecord ()
            Get
                Return DirectCast(MyBase._DataSource, ACTIVITYRecord())
            End Get
            Set(ByVal value() As ACTIVITYRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property ActionsButton() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ActionsButton"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property ExcelButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExcelButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property FilterButton() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FilterButton"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property FiltersButton() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FiltersButton"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property ImportButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ImportButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property LOGINDATFromFilter() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LOGINDATFromFilter"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property LOGINDATLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LOGINDATLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property LOGINDATToFilter() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LOGINDATToFilter"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property NewButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NewButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pagination() As ePortalWFApproval.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination"), ePortalWFApproval.UI.IPaginationModern)
          End Get
          End Property
        
        Public ReadOnly Property PDFButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PDFButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property ResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SearchButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SearchButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SearchText() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SearchText"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property SortByLabel() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortByLabel"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
          Public ReadOnly Property SortControl() As System.Web.UI.WebControls.DropDownList
          Get
          Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortControl"), System.Web.UI.WebControls.DropDownList)
          End Get
          End Property
        
        Public ReadOnly Property Title0() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Title0"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property USERIDFilter() As BaseClasses.Web.UI.WebControls.QuickSelector
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "USERIDFilter"), BaseClasses.Web.UI.WebControls.QuickSelector)
            End Get
        End Property
        
        Public ReadOnly Property USERIDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "USERIDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WordButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WordButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
      
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me,includeSession)
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As ACTIVITYTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As ACTIVITYRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As ACTIVITYTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As ACTIVITYRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                If includeSession then
                    Return EvaluateExpressions(url, arg, rec, bEncrypt)
                Else
                    Return EvaluateExpressions(url, arg, rec, bEncrypt,False)
                End If
            End If
            Return url
        End Function
        
          
        Public Overridable Function GetSelectedRecordControl() As ACTIVITYTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As ACTIVITYTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(ACTIVITYTableControlRow)), ACTIVITYTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As ACTIVITYTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As ACTIVITYTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Overridable Function GetRecordControls() As ACTIVITYTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "ACTIVITYTableControlRow")
            Dim list As New List(Of ACTIVITYTableControlRow)
            For Each recCtrl As ACTIVITYTableControlRow In recCtrls
                list.Add(recCtrl)
            Next
            Return list.ToArray()
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property
                


#End Region



End Class

  

#End Region
    
  
End Namespace

  