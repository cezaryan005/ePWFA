﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WPO_ActivityRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPO_ActivityRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPO_ActivityTable"></see> class.
''' </remarks>
''' <seealso cref="WPO_ActivityTable"></seealso>
''' <seealso cref="WPO_ActivityRecord"></seealso>

<Serializable()> Public Class BaseWPO_ActivityRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WPO_ActivityTable = WPO_ActivityTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WPO_ActivityRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WPO_ActivityRec As WPO_ActivityRecord = CType(sender,WPO_ActivityRecord)
        Validate_Inserting()
        If Not WPO_ActivityRec Is Nothing AndAlso Not WPO_ActivityRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WPO_ActivityRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WPO_ActivityRec As WPO_ActivityRecord = CType(sender,WPO_ActivityRecord)
        Validate_Updating()
        If Not WPO_ActivityRec Is Nothing AndAlso Not WPO_ActivityRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WPO_ActivityRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WPO_ActivityRec As WPO_ActivityRecord = CType(sender,WPO_ActivityRecord)
        If Not WPO_ActivityRec Is Nothing AndAlso Not WPO_ActivityRec.IsReadOnly Then
                End If
    End Sub
    
   'Evaluates Validate when->Inserting formulas specified at the data access layer
   Public Overridable Sub Validate_Inserting ()
		Dim fullValidationMessage As String = ""
		Dim validationMessage As String = ""

		dim formula as String = ""


		If validationMessage <> "" AndAlso validationMessage.ToLower() <> "true" Then
			fullValidationMessage &= validationMessage & vbCrLf
		End If

		If fullValidationMessage <> "" Then
			Throw New Exception(fullValidationMessage)
		End If 
	End Sub
	
	'Evaluates Validate when->Updating formulas specified at the data access layer
   Public Overridable Sub Validate_Updating ()
		Dim fullValidationMessage As String = ""
		Dim validationMessage As String = ""

		dim formula as String = ""


		If validationMessage <> "" AndAlso validationMessage.ToLower() <> "true" Then
			fullValidationMessage &= validationMessage & vbCrLf
		End If

		If fullValidationMessage <> "" Then
			Throw New Exception(fullValidationMessage)
		End If 
	End Sub
 
	Public Overridable Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format As String = Nothing) As String

		Dim e As Data.BaseFormulaEvaluator = New Data.BaseFormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
        	Return resultObj.ToString()
	End Function







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_ID field.
	''' </summary>
	Public Function GetWPO_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_ID field.
	''' </summary>
	Public Function GetWPO_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_WS_ID field.
	''' </summary>
	Public Function GetWPO_WS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_WS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_WS_ID field.
	''' </summary>
	Public Function GetWPO_WS_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_WS_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WS_ID field.
	''' </summary>
	Public Sub SetWPO_WS_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WS_ID field.
	''' </summary>
	Public Sub SetWPO_WS_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WS_ID field.
	''' </summary>
	Public Sub SetWPO_WS_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WS_ID field.
	''' </summary>
	Public Sub SetWPO_WS_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WS_ID field.
	''' </summary>
	Public Sub SetWPO_WS_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_WS_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_WSD_ID field.
	''' </summary>
	Public Function GetWPO_WSD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_WSD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_WSD_ID field.
	''' </summary>
	Public Function GetWPO_WSD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_WSD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WSD_ID field.
	''' </summary>
	Public Sub SetWPO_WSD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WSD_ID field.
	''' </summary>
	Public Sub SetWPO_WSD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WSD_ID field.
	''' </summary>
	Public Sub SetWPO_WSD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WSD_ID field.
	''' </summary>
	Public Sub SetWPO_WSD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WSD_ID field.
	''' </summary>
	Public Sub SetWPO_WSD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_WSD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_WDT_ID field.
	''' </summary>
	Public Function GetWPO_WDT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_WDT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_WDT_ID field.
	''' </summary>
	Public Function GetWPO_WDT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_WDT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WDT_ID field.
	''' </summary>
	Public Sub SetWPO_WDT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WDT_ID field.
	''' </summary>
	Public Sub SetWPO_WDT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WDT_ID field.
	''' </summary>
	Public Sub SetWPO_WDT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WDT_ID field.
	''' </summary>
	Public Sub SetWPO_WDT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_WDT_ID field.
	''' </summary>
	Public Sub SetWPO_WDT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_WDT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_W_U_ID field.
	''' </summary>
	Public Function GetWPO_W_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_W_U_ID field.
	''' </summary>
	Public Function GetWPO_W_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_W_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_W_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_W_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_W_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_W_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWPO_W_U_ID_DelegateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_W_U_ID_DelegateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_W_U_ID_Delegate field.
	''' </summary>
	Public Function GetWPO_W_U_ID_DelegateFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_W_U_ID_DelegateColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPO_W_U_ID_DelegateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPO_W_U_ID_DelegateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPO_W_U_ID_DelegateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPO_W_U_ID_DelegateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_W_U_ID_DelegateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_W_U_ID_Delegate field.
	''' </summary>
	Public Sub SetWPO_W_U_ID_DelegateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_W_U_ID_DelegateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_Status field.
	''' </summary>
	Public Function GetWPO_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_Status field.
	''' </summary>
	Public Function GetWPO_StatusFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_StatusColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Status field.
	''' </summary>
	Public Sub SetWPO_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Status field.
	''' </summary>
	Public Sub SetWPO_StatusFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Status field.
	''' </summary>
	Public Sub SetWPO_StatusFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Status field.
	''' </summary>
	Public Sub SetWPO_StatusFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Status field.
	''' </summary>
	Public Sub SetWPO_StatusFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_StatusColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_Date_Assign field.
	''' </summary>
	Public Function GetWPO_Date_AssignValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_Date_AssignColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_Date_Assign field.
	''' </summary>
	Public Function GetWPO_Date_AssignFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WPO_Date_AssignColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Date_Assign field.
	''' </summary>
	Public Sub SetWPO_Date_AssignFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Date_Assign field.
	''' </summary>
	Public Sub SetWPO_Date_AssignFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Date_Assign field.
	''' </summary>
	Public Sub SetWPO_Date_AssignFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_Date_Action field.
	''' </summary>
	Public Function GetWPO_Date_ActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_Date_ActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_Date_Action field.
	''' </summary>
	Public Function GetWPO_Date_ActionFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WPO_Date_ActionColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Date_Action field.
	''' </summary>
	Public Sub SetWPO_Date_ActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Date_Action field.
	''' </summary>
	Public Sub SetWPO_Date_ActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Date_Action field.
	''' </summary>
	Public Sub SetWPO_Date_ActionFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_Remark field.
	''' </summary>
	Public Function GetWPO_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_Remark field.
	''' </summary>
	Public Function GetWPO_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPO_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Remark field.
	''' </summary>
	Public Sub SetWPO_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Remark field.
	''' </summary>
	Public Sub SetWPO_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_Is_Done field.
	''' </summary>
	Public Function GetWPO_Is_DoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_Is_DoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_Is_Done field.
	''' </summary>
	Public Function GetWPO_Is_DoneFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WPO_Is_DoneColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Is_Done field.
	''' </summary>
	Public Sub SetWPO_Is_DoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Is_Done field.
	''' </summary>
	Public Sub SetWPO_Is_DoneFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Is_Done field.
	''' </summary>
	Public Sub SetWPO_Is_DoneFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_Is_DoneColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_PONum field.
	''' </summary>
	Public Function GetWPO_PONumValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_PONumColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_PONum field.
	''' </summary>
	Public Function GetWPO_PONumFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPO_PONumColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_PONum field.
	''' </summary>
	Public Sub SetWPO_PONumFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_PONumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_PONum field.
	''' </summary>
	Public Sub SetWPO_PONumFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_PONumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_Is_InclPrint field.
	''' </summary>
	Public Function GetWPO_Is_InclPrintValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_Is_InclPrintColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Activity_.WPO_Is_InclPrint field.
	''' </summary>
	Public Function GetWPO_Is_InclPrintFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WPO_Is_InclPrintColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Is_InclPrint field.
	''' </summary>
	Public Sub SetWPO_Is_InclPrintFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_Is_InclPrintColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Is_InclPrint field.
	''' </summary>
	Public Sub SetWPO_Is_InclPrintFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_Is_InclPrintColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Activity_.WPO_Is_InclPrint field.
	''' </summary>
	Public Sub SetWPO_Is_InclPrintFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_Is_InclPrintColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_ID field.
	''' </summary>
	Public Property WPO_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_IDDefault() As String
        Get
            Return TableUtils.WPO_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_WS_ID field.
	''' </summary>
	Public Property WPO_WS_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_WS_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_WS_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_WS_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_WS_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_WS_IDDefault() As String
        Get
            Return TableUtils.WPO_WS_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_WSD_ID field.
	''' </summary>
	Public Property WPO_WSD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_WSD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_WSD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_WSD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_WSD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_WSD_IDDefault() As String
        Get
            Return TableUtils.WPO_WSD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_WDT_ID field.
	''' </summary>
	Public Property WPO_WDT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_WDT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_WDT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_WDT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_WDT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_WDT_IDDefault() As String
        Get
            Return TableUtils.WPO_WDT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_W_U_ID field.
	''' </summary>
	Public Property WPO_W_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_W_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_W_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_W_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_W_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_W_U_IDDefault() As String
        Get
            Return TableUtils.WPO_W_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_W_U_ID_Delegate field.
	''' </summary>
	Public Property WPO_W_U_ID_Delegate() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_W_U_ID_DelegateColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_W_U_ID_DelegateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_W_U_ID_DelegateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_W_U_ID_DelegateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_W_U_ID_DelegateDefault() As String
        Get
            Return TableUtils.WPO_W_U_ID_DelegateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_Status field.
	''' </summary>
	Public Property WPO_Status() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_StatusColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_StatusDefault() As String
        Get
            Return TableUtils.WPO_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_Date_Assign field.
	''' </summary>
	Public Property WPO_Date_Assign() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_Date_AssignColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_Date_AssignColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_Date_AssignSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_Date_AssignColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_Date_AssignDefault() As String
        Get
            Return TableUtils.WPO_Date_AssignColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_Date_Action field.
	''' </summary>
	Public Property WPO_Date_Action() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_Date_ActionColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_Date_ActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_Date_ActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_Date_ActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_Date_ActionDefault() As String
        Get
            Return TableUtils.WPO_Date_ActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_Remark field.
	''' </summary>
	Public Property WPO_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPO_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_RemarkDefault() As String
        Get
            Return TableUtils.WPO_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_Is_Done field.
	''' </summary>
	Public Property WPO_Is_Done() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_Is_DoneColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_Is_DoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_Is_DoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_Is_DoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_Is_DoneDefault() As String
        Get
            Return TableUtils.WPO_Is_DoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_PONum field.
	''' </summary>
	Public Property WPO_PONum() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_PONumColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPO_PONumColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_PONumSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_PONumColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_PONumDefault() As String
        Get
            Return TableUtils.WPO_PONumColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Activity_.WPO_Is_InclPrint field.
	''' </summary>
	Public Property WPO_Is_InclPrint() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_Is_InclPrintColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_Is_InclPrintColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_Is_InclPrintSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_Is_InclPrintColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_Is_InclPrintDefault() As String
        Get
            Return TableUtils.WPO_Is_InclPrintColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
