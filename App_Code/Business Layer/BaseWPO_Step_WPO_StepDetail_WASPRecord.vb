﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WPO_Step_WPO_StepDetail_WASPRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WPO_Step_WPO_StepDetail_WASPRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WPO_Step_WPO_StepDetail_WASPView"></see> class.
''' </remarks>
''' <seealso cref="WPO_Step_WPO_StepDetail_WASPView"></seealso>
''' <seealso cref="WPO_Step_WPO_StepDetail_WASPRecord"></seealso>

<Serializable()> Public Class BaseWPO_Step_WPO_StepDetail_WASPRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As WPO_Step_WPO_StepDetail_WASPView = WPO_Step_WPO_StepDetail_WASPView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WPO_Step_WPO_StepDetail_WASPRecord_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WPO_Step_WPO_StepDetail_WASPRec As WPO_Step_WPO_StepDetail_WASPRecord = CType(sender,WPO_Step_WPO_StepDetail_WASPRecord)
        If Not WPO_Step_WPO_StepDetail_WASPRec Is Nothing AndAlso Not WPO_Step_WPO_StepDetail_WASPRec.IsReadOnly Then
                End If
    End Sub
    
    	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WPO_Step_WPO_StepDetail_WASPRecord_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WPO_Step_WPO_StepDetail_WASPRec As WPO_Step_WPO_StepDetail_WASPRecord = CType(sender,WPO_Step_WPO_StepDetail_WASPRecord)
        Validate_Inserting()
        If Not WPO_Step_WPO_StepDetail_WASPRec Is Nothing AndAlso Not WPO_Step_WPO_StepDetail_WASPRec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID field.
	''' </summary>
	Public Function GetWPO_S_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_S_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID field.
	''' </summary>
	Public Function GetWPO_S_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_S_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID field.
	''' </summary>
	Public Sub SetWPO_S_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_S_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID field.
	''' </summary>
	Public Sub SetWPO_S_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_S_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID field.
	''' </summary>
	Public Sub SetWPO_S_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID field.
	''' </summary>
	Public Sub SetWPO_S_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID field.
	''' </summary>
	Public Sub SetWPO_S_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_WDT_ID field.
	''' </summary>
	Public Function GetWPO_S_WDT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_S_WDT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_WDT_ID field.
	''' </summary>
	Public Function GetWPO_S_WDT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_S_WDT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_WDT_ID field.
	''' </summary>
	Public Sub SetWPO_S_WDT_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_S_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_WDT_ID field.
	''' </summary>
	Public Sub SetWPO_S_WDT_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_S_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_WDT_ID field.
	''' </summary>
	Public Sub SetWPO_S_WDT_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_WDT_ID field.
	''' </summary>
	Public Sub SetWPO_S_WDT_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_WDT_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_WDT_ID field.
	''' </summary>
	Public Sub SetWPO_S_WDT_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_WDT_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID_Next field.
	''' </summary>
	Public Function GetWPO_S_ID_NextValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_S_ID_NextColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID_Next field.
	''' </summary>
	Public Function GetWPO_S_ID_NextFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_S_ID_NextColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID_Next field.
	''' </summary>
	Public Sub SetWPO_S_ID_NextFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_S_ID_NextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID_Next field.
	''' </summary>
	Public Sub SetWPO_S_ID_NextFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_S_ID_NextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID_Next field.
	''' </summary>
	Public Sub SetWPO_S_ID_NextFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_ID_NextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID_Next field.
	''' </summary>
	Public Sub SetWPO_S_ID_NextFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_ID_NextColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID_Next field.
	''' </summary>
	Public Sub SetWPO_S_ID_NextFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_ID_NextColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Step_Type field.
	''' </summary>
	Public Function GetWPO_S_Step_TypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_S_Step_TypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Step_Type field.
	''' </summary>
	Public Function GetWPO_S_Step_TypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WPO_S_Step_TypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Step_Type field.
	''' </summary>
	Public Sub SetWPO_S_Step_TypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_S_Step_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Step_Type field.
	''' </summary>
	Public Sub SetWPO_S_Step_TypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_Step_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Approval_Needed field.
	''' </summary>
	Public Function GetWPO_S_Approval_NeededValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_S_Approval_NeededColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Approval_Needed field.
	''' </summary>
	Public Function GetWPO_S_Approval_NeededFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WPO_S_Approval_NeededColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Approval_Needed field.
	''' </summary>
	Public Sub SetWPO_S_Approval_NeededFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_S_Approval_NeededColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Approval_Needed field.
	''' </summary>
	Public Sub SetWPO_S_Approval_NeededFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_S_Approval_NeededColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Approval_Needed field.
	''' </summary>
	Public Sub SetWPO_S_Approval_NeededFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_Approval_NeededColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Approval_Needed field.
	''' </summary>
	Public Sub SetWPO_S_Approval_NeededFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_Approval_NeededColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Approval_Needed field.
	''' </summary>
	Public Sub SetWPO_S_Approval_NeededFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_S_Approval_NeededColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_ID field.
	''' </summary>
	Public Function GetWPO_SD_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_ID field.
	''' </summary>
	Public Function GetWPO_SD_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_SD_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_ID field.
	''' </summary>
	Public Sub SetWPO_SD_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_ID field.
	''' </summary>
	Public Sub SetWPO_SD_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_SD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_ID field.
	''' </summary>
	Public Sub SetWPO_SD_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_ID field.
	''' </summary>
	Public Sub SetWPO_SD_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_ID field.
	''' </summary>
	Public Sub SetWPO_SD_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Function GetWPO_SD_W_U_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_W_U_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Function GetWPO_SD_W_U_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WPO_SD_W_U_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_SD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_W_U_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Sub SetWPO_SD_W_U_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_W_U_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_Is_FAP field.
	''' </summary>
	Public Function GetWPO_SD_Is_FAPValue() As ColumnValue
		Return Me.GetValue(TableUtils.WPO_SD_Is_FAPColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_Is_FAP field.
	''' </summary>
	Public Function GetWPO_SD_Is_FAPFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.WPO_SD_Is_FAPColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_Is_FAP field.
	''' </summary>
	Public Sub SetWPO_SD_Is_FAPFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WPO_SD_Is_FAPColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_Is_FAP field.
	''' </summary>
	Public Sub SetWPO_SD_Is_FAPFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WPO_SD_Is_FAPColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_Is_FAP field.
	''' </summary>
	Public Sub SetWPO_SD_Is_FAPFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WPO_SD_Is_FAPColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.W_U_Full_Name field.
	''' </summary>
	Public Function GetW_U_Full_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.W_U_Full_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.W_U_Full_Name field.
	''' </summary>
	Public Function GetW_U_Full_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.W_U_Full_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.W_U_Full_Name field.
	''' </summary>
	Public Sub SetW_U_Full_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.W_U_Full_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WPO_Step_WPO_StepDetail_WASP_.W_U_Full_Name field.
	''' </summary>
	Public Sub SetW_U_Full_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.W_U_Full_NameColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID field.
	''' </summary>
	Public Property WPO_S_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_S_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_S_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_S_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_S_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_S_IDDefault() As String
        Get
            Return TableUtils.WPO_S_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_WDT_ID field.
	''' </summary>
	Public Property WPO_S_WDT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_S_WDT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_S_WDT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_S_WDT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_S_WDT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_S_WDT_IDDefault() As String
        Get
            Return TableUtils.WPO_S_WDT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_ID_Next field.
	''' </summary>
	Public Property WPO_S_ID_Next() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_S_ID_NextColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_S_ID_NextColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_S_ID_NextSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_S_ID_NextColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_S_ID_NextDefault() As String
        Get
            Return TableUtils.WPO_S_ID_NextColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Step_Type field.
	''' </summary>
	Public Property WPO_S_Step_Type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_S_Step_TypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WPO_S_Step_TypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_S_Step_TypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_S_Step_TypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_S_Step_TypeDefault() As String
        Get
            Return TableUtils.WPO_S_Step_TypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_S_Approval_Needed field.
	''' </summary>
	Public Property WPO_S_Approval_Needed() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_S_Approval_NeededColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_S_Approval_NeededColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_S_Approval_NeededSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_S_Approval_NeededColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_S_Approval_NeededDefault() As String
        Get
            Return TableUtils.WPO_S_Approval_NeededColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_ID field.
	''' </summary>
	Public Property WPO_SD_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_SD_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_IDDefault() As String
        Get
            Return TableUtils.WPO_SD_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_W_U_ID field.
	''' </summary>
	Public Property WPO_SD_W_U_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_W_U_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_SD_W_U_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_W_U_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_W_U_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_W_U_IDDefault() As String
        Get
            Return TableUtils.WPO_SD_W_U_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.WPO_SD_Is_FAP field.
	''' </summary>
	Public Property WPO_SD_Is_FAP() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.WPO_SD_Is_FAPColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WPO_SD_Is_FAPColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WPO_SD_Is_FAPSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WPO_SD_Is_FAPColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WPO_SD_Is_FAPDefault() As String
        Get
            Return TableUtils.WPO_SD_Is_FAPColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WPO_Step_WPO_StepDetail_WASP_.W_U_Full_Name field.
	''' </summary>
	Public Property W_U_Full_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.W_U_Full_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.W_U_Full_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property W_U_Full_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.W_U_Full_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property W_U_Full_NameDefault() As String
        Get
            Return TableUtils.W_U_Full_NameColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
