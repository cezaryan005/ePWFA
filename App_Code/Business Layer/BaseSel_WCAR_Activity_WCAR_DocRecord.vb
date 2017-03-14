﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_WCAR_Activity_WCAR_DocRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_WCAR_Activity_WCAR_DocRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Sel_WCAR_Activity_WCAR_DocView"></see> class.
''' </remarks>
''' <seealso cref="Sel_WCAR_Activity_WCAR_DocView"></seealso>
''' <seealso cref="Sel_WCAR_Activity_WCAR_DocRecord"></seealso>

<Serializable()> Public Class BaseSel_WCAR_Activity_WCAR_DocRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Sel_WCAR_Activity_WCAR_DocView = Sel_WCAR_Activity_WCAR_DocView.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub Sel_WCAR_Activity_WCAR_DocRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim Sel_WCAR_Activity_WCAR_DocRec As Sel_WCAR_Activity_WCAR_DocRecord = CType(sender,Sel_WCAR_Activity_WCAR_DocRecord)
        Validate_Inserting()
        If Not Sel_WCAR_Activity_WCAR_DocRec Is Nothing AndAlso Not Sel_WCAR_Activity_WCAR_DocRec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub Sel_WCAR_Activity_WCAR_DocRecord_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim Sel_WCAR_Activity_WCAR_DocRec As Sel_WCAR_Activity_WCAR_DocRecord = CType(sender,Sel_WCAR_Activity_WCAR_DocRecord)
        Validate_Updating()
        If Not Sel_WCAR_Activity_WCAR_DocRec Is Nothing AndAlso Not Sel_WCAR_Activity_WCAR_DocRec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub Sel_WCAR_Activity_WCAR_DocRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim Sel_WCAR_Activity_WCAR_DocRec As Sel_WCAR_Activity_WCAR_DocRecord = CType(sender,Sel_WCAR_Activity_WCAR_DocRecord)
        If Not Sel_WCAR_Activity_WCAR_DocRec Is Nothing AndAlso Not Sel_WCAR_Activity_WCAR_DocRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_ID field.
	''' </summary>
	Public Function GetWCA_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_ID field.
	''' </summary>
	Public Function GetWCA_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCA_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_ID field.
	''' </summary>
	Public Sub SetWCA_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_ID field.
	''' </summary>
	Public Sub SetWCA_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_ID field.
	''' </summary>
	Public Sub SetWCA_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_ID field.
	''' </summary>
	Public Sub SetWCA_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_ID field.
	''' </summary>
	Public Sub SetWCA_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WS_ID field.
	''' </summary>
	Public Function GetWCA_WS_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_WS_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WS_ID field.
	''' </summary>
	Public Function GetWCA_WS_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCA_WS_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WS_ID field.
	''' </summary>
	Public Sub SetWCA_WS_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WS_ID field.
	''' </summary>
	Public Sub SetWCA_WS_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WS_ID field.
	''' </summary>
	Public Sub SetWCA_WS_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WS_ID field.
	''' </summary>
	Public Sub SetWCA_WS_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_WS_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WS_ID field.
	''' </summary>
	Public Sub SetWCA_WS_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_WS_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WSD_ID field.
	''' </summary>
	Public Function GetWCA_WSD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_WSD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WSD_ID field.
	''' </summary>
	Public Function GetWCA_WSD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCA_WSD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WSD_ID field.
	''' </summary>
	Public Sub SetWCA_WSD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WSD_ID field.
	''' </summary>
	Public Sub SetWCA_WSD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WSD_ID field.
	''' </summary>
	Public Sub SetWCA_WSD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WSD_ID field.
	''' </summary>
	Public Sub SetWCA_WSD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_WSD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WSD_ID field.
	''' </summary>
	Public Sub SetWCA_WSD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_WSD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WDT_ID field.
	''' </summary>
	Public Function GetWCA_WDT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_WDT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WDT_ID field.
	''' </summary>
	Public Function GetWCA_WDT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCA_WDT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WDT_ID field.
	''' </summary>
	Public Sub SetWCA_WDT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WDT_ID field.
	''' </summary>
	Public Sub SetWCA_WDT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WDT_ID field.
	''' </summary>
	Public Sub SetWCA_WDT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WDT_ID field.
	''' </summary>
	Public Sub SetWCA_WDT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WDT_ID field.
	''' </summary>
	Public Sub SetWCA_WDT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_WDT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_W_U_ID field.
	''' </summary>
	Public Function GetWCA_W_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_W_U_ID field.
	''' </summary>
	Public Function GetWCA_W_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCA_W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_W_U_ID field.
	''' </summary>
	Public Sub SetWCA_W_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_W_U_ID field.
	''' </summary>
	Public Sub SetWCA_W_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_W_U_ID field.
	''' </summary>
	Public Sub SetWCA_W_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_W_U_ID field.
	''' </summary>
	Public Sub SetWCA_W_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_W_U_ID field.
	''' </summary>
	Public Sub SetWCA_W_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WCD_ID field.
	''' </summary>
	Public Function GetWCA_WCD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_WCD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WCD_ID field.
	''' </summary>
	Public Function GetWCA_WCD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCA_WCD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WCD_ID field.
	''' </summary>
	Public Sub SetWCA_WCD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WCD_ID field.
	''' </summary>
	Public Sub SetWCA_WCD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCA_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WCD_ID field.
	''' </summary>
	Public Sub SetWCA_WCD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WCD_ID field.
	''' </summary>
	Public Sub SetWCA_WCD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_WCD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WCD_ID field.
	''' </summary>
	Public Sub SetWCA_WCD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_WCD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Status field.
	''' </summary>
	Public Function GetWCA_StatusValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_StatusColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Status field.
	''' </summary>
	Public Function GetWCA_StatusFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCA_StatusColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Status field.
	''' </summary>
	Public Sub SetWCA_StatusFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Status field.
	''' </summary>
	Public Sub SetWCA_StatusFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_StatusColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Date_Assign field.
	''' </summary>
	Public Function GetWCA_Date_AssignValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_Date_AssignColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Date_Assign field.
	''' </summary>
	Public Function GetWCA_Date_AssignFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WCA_Date_AssignColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Date_Assign field.
	''' </summary>
	Public Sub SetWCA_Date_AssignFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Date_Assign field.
	''' </summary>
	Public Sub SetWCA_Date_AssignFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Date_Assign field.
	''' </summary>
	Public Sub SetWCA_Date_AssignFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_Date_AssignColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Date_Action field.
	''' </summary>
	Public Function GetWCA_Date_ActionValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_Date_ActionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Date_Action field.
	''' </summary>
	Public Function GetWCA_Date_ActionFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WCA_Date_ActionColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Date_Action field.
	''' </summary>
	Public Sub SetWCA_Date_ActionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Date_Action field.
	''' </summary>
	Public Sub SetWCA_Date_ActionFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Date_Action field.
	''' </summary>
	Public Sub SetWCA_Date_ActionFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_Date_ActionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Remark field.
	''' </summary>
	Public Function GetWCA_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Remark field.
	''' </summary>
	Public Function GetWCA_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCA_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Remark field.
	''' </summary>
	Public Sub SetWCA_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Remark field.
	''' </summary>
	Public Sub SetWCA_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_No field.
	''' </summary>
	Public Function GetWCD_NoValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_NoColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_No field.
	''' </summary>
	Public Function GetWCD_NoFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_NoColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_No field.
	''' </summary>
	Public Sub SetWCD_NoFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_No field.
	''' </summary>
	Public Sub SetWCD_NoFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_NoColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Project_Title field.
	''' </summary>
	Public Function GetWCD_Project_TitleValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Project_TitleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Project_Title field.
	''' </summary>
	Public Function GetWCD_Project_TitleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_Project_TitleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Project_Title field.
	''' </summary>
	Public Sub SetWCD_Project_TitleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Project_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Project_Title field.
	''' </summary>
	Public Sub SetWCD_Project_TitleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Project_TitleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Exp_Total field.
	''' </summary>
	Public Function GetWCD_Exp_TotalValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Exp_TotalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Exp_Total field.
	''' </summary>
	Public Function GetWCD_Exp_TotalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WCD_Exp_TotalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Exp_Total field.
	''' </summary>
	Public Sub SetWCD_Exp_TotalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Is_Done field.
	''' </summary>
	Public Function GetWCA_Is_DoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCA_Is_DoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Is_Done field.
	''' </summary>
	Public Function GetWCA_Is_DoneFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WCA_Is_DoneColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Is_Done field.
	''' </summary>
	Public Sub SetWCA_Is_DoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCA_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Is_Done field.
	''' </summary>
	Public Sub SetWCA_Is_DoneFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCA_Is_DoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Is_Done field.
	''' </summary>
	Public Sub SetWCA_Is_DoneFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCA_Is_DoneColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_U_ID field.
	''' </summary>
	Public Function GetWCD_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_U_ID field.
	''' </summary>
	Public Function GetWCD_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WCD_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_U_ID field.
	''' </summary>
	Public Sub SetWCD_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_U_ID field.
	''' </summary>
	Public Sub SetWCD_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_U_ID field.
	''' </summary>
	Public Sub SetWCD_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_U_ID field.
	''' </summary>
	Public Sub SetWCD_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_U_ID field.
	''' </summary>
	Public Sub SetWCD_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Remark field.
	''' </summary>
	Public Function GetWCD_RemarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_RemarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Remark field.
	''' </summary>
	Public Function GetWCD_RemarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WCD_RemarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Remark field.
	''' </summary>
	Public Sub SetWCD_RemarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Remark field.
	''' </summary>
	Public Sub SetWCD_RemarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_RemarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_WCur_ID field.
	''' </summary>
	Public Function GetWCD_WCur_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_WCur_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_WCur_ID field.
	''' </summary>
	Public Function GetWCD_WCur_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCD_WCur_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_WCur_ID field.
	''' </summary>
	Public Sub SetWCD_WCur_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_WCur_ID field.
	''' </summary>
	Public Sub SetWCD_WCur_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_WCur_ID field.
	''' </summary>
	Public Sub SetWCD_WCur_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_WCur_ID field.
	''' </summary>
	Public Sub SetWCD_WCur_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_WCur_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_WCur_ID field.
	''' </summary>
	Public Sub SetWCD_WCur_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_WCur_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Request_Date field.
	''' </summary>
	Public Function GetWCD_Request_DateValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_Request_DateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Request_Date field.
	''' </summary>
	Public Function GetWCD_Request_DateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.WCD_Request_DateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Request_Date field.
	''' </summary>
	Public Sub SetWCD_Request_DateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_Request_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Request_Date field.
	''' </summary>
	Public Sub SetWCD_Request_DateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_Request_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Request_Date field.
	''' </summary>
	Public Sub SetWCD_Request_DateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_Request_DateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_C_ID field.
	''' </summary>
	Public Function GetWCD_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WCD_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_C_ID field.
	''' </summary>
	Public Function GetWCD_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WCD_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_C_ID field.
	''' </summary>
	Public Sub SetWCD_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.SSC_CompanyID field.
	''' </summary>
	Public Function GetSSC_CompanyIDValue() As ColumnValue
		Return Me.GetValue(TableUtils.SSC_CompanyIDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.SSC_CompanyID field.
	''' </summary>
	Public Function GetSSC_CompanyIDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.SSC_CompanyIDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSC_CompanyIDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSC_CompanyIDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSC_CompanyIDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSC_CompanyIDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSC_CompanyIDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's sel_WCAR_Activity_WCAR_Doc_.SSC_CompanyID field.
	''' </summary>
	Public Sub SetSSC_CompanyIDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.SSC_CompanyIDColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_ID field.
	''' </summary>
	Public Property WCA_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCA_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_IDDefault() As String
        Get
            Return TableUtils.WCA_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WS_ID field.
	''' </summary>
	Public Property WCA_WS_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_WS_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCA_WS_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_WS_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_WS_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_WS_IDDefault() As String
        Get
            Return TableUtils.WCA_WS_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WSD_ID field.
	''' </summary>
	Public Property WCA_WSD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_WSD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCA_WSD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_WSD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_WSD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_WSD_IDDefault() As String
        Get
            Return TableUtils.WCA_WSD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WDT_ID field.
	''' </summary>
	Public Property WCA_WDT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_WDT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCA_WDT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_WDT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_WDT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_WDT_IDDefault() As String
        Get
            Return TableUtils.WCA_WDT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_W_U_ID field.
	''' </summary>
	Public Property WCA_W_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_W_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCA_W_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_W_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_W_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_W_U_IDDefault() As String
        Get
            Return TableUtils.WCA_W_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_WCD_ID field.
	''' </summary>
	Public Property WCA_WCD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_WCD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCA_WCD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_WCD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_WCD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_WCD_IDDefault() As String
        Get
            Return TableUtils.WCA_WCD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Status field.
	''' </summary>
	Public Property WCA_Status() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_StatusColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCA_StatusColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_StatusSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_StatusColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_StatusDefault() As String
        Get
            Return TableUtils.WCA_StatusColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Date_Assign field.
	''' </summary>
	Public Property WCA_Date_Assign() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_Date_AssignColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCA_Date_AssignColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_Date_AssignSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_Date_AssignColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_Date_AssignDefault() As String
        Get
            Return TableUtils.WCA_Date_AssignColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Date_Action field.
	''' </summary>
	Public Property WCA_Date_Action() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_Date_ActionColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCA_Date_ActionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_Date_ActionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_Date_ActionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_Date_ActionDefault() As String
        Get
            Return TableUtils.WCA_Date_ActionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Remark field.
	''' </summary>
	Public Property WCA_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCA_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_RemarkDefault() As String
        Get
            Return TableUtils.WCA_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_No field.
	''' </summary>
	Public Property WCD_No() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_NoColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_NoColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_NoSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_NoColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_NoDefault() As String
        Get
            Return TableUtils.WCD_NoColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Project_Title field.
	''' </summary>
	Public Property WCD_Project_Title() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Project_TitleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_Project_TitleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Project_TitleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Project_TitleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Project_TitleDefault() As String
        Get
            Return TableUtils.WCD_Project_TitleColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Exp_Total field.
	''' </summary>
	Public Property WCD_Exp_Total() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Exp_TotalColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Exp_TotalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Exp_TotalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Exp_TotalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Exp_TotalDefault() As String
        Get
            Return TableUtils.WCD_Exp_TotalColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCA_Is_Done field.
	''' </summary>
	Public Property WCA_Is_Done() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WCA_Is_DoneColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCA_Is_DoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCA_Is_DoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCA_Is_DoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCA_Is_DoneDefault() As String
        Get
            Return TableUtils.WCA_Is_DoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_U_ID field.
	''' </summary>
	Public Property WCD_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_U_IDDefault() As String
        Get
            Return TableUtils.WCD_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Remark field.
	''' </summary>
	Public Property WCD_Remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_RemarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WCD_RemarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_RemarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_RemarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_RemarkDefault() As String
        Get
            Return TableUtils.WCD_RemarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_WCur_ID field.
	''' </summary>
	Public Property WCD_WCur_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_WCur_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_WCur_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_WCur_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_WCur_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_WCur_IDDefault() As String
        Get
            Return TableUtils.WCD_WCur_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_Request_Date field.
	''' </summary>
	Public Property WCD_Request_Date() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_Request_DateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_Request_DateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_Request_DateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_Request_DateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_Request_DateDefault() As String
        Get
            Return TableUtils.WCD_Request_DateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.WCD_C_ID field.
	''' </summary>
	Public Property WCD_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WCD_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WCD_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WCD_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WCD_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WCD_C_IDDefault() As String
        Get
            Return TableUtils.WCD_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's sel_WCAR_Activity_WCAR_Doc_.SSC_CompanyID field.
	''' </summary>
	Public Property SSC_CompanyID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.SSC_CompanyIDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.SSC_CompanyIDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property SSC_CompanyIDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.SSC_CompanyIDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property SSC_CompanyIDDefault() As String
        Get
            Return TableUtils.SSC_CompanyIDColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
