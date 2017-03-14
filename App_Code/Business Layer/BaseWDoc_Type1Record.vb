﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WDoc_Type1Record.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="WDoc_Type1Record"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WDoc_Type1Table"></see> class.
''' </remarks>
''' <seealso cref="WDoc_Type1Table"></seealso>
''' <seealso cref="WDoc_Type1Record"></seealso>

<Serializable()> Public Class BaseWDoc_Type1Record
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As WDoc_Type1Table = WDoc_Type1Table.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub
	
	'Evaluates Initialize when->Inserting record formulas specified at the data access layer
    Public Overridable Sub WDoc_Type1Record_InsertingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.InsertingRecord
        'Apply Initialize->Inserting record formula only if validation is successful.
        	        Dim WDoc_Type1Rec As WDoc_Type1Record = CType(sender,WDoc_Type1Record)
        Validate_Inserting()
        If Not WDoc_Type1Rec Is Nothing AndAlso Not WDoc_Type1Rec.IsReadOnly Then
                End If
    End Sub

	'Evaluates Initialize when->Updating record formulas specified at the data access layer
    Public Overridable Sub WDoc_Type1Record_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.UpdatingRecord
        'Apply Initialize->Updating record formula only if validation is successful.
        	        Dim WDoc_Type1Rec As WDoc_Type1Record = CType(sender,WDoc_Type1Record)
        Validate_Updating()
        If Not WDoc_Type1Rec Is Nothing AndAlso Not WDoc_Type1Rec.IsReadOnly Then
                End If
    End Sub
    
    'Evaluates Initialize when->Reading record formulas specified at the data access layer
    Public Overridable Sub WDoc_Type1Record_ReadRecord(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReadRecord
        'Apply Initialize->Reading record formula only if validation is successful.
        	        Dim WDoc_Type1Rec As WDoc_Type1Record = CType(sender,WDoc_Type1Record)
        If Not WDoc_Type1Rec Is Nothing AndAlso Not WDoc_Type1Rec.IsReadOnly Then
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
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_ID field.
	''' </summary>
	Public Function GetWDT_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WDT_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_ID field.
	''' </summary>
	Public Function GetWDT_IDFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.WDT_IDColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_C_ID field.
	''' </summary>
	Public Function GetWDT_C_IDValue() As ColumnValue
		Return Me.GetValue(TableUtils.WDT_C_IDColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_C_ID field.
	''' </summary>
	Public Function GetWDT_C_IDFieldValue() As Int16
		Return CType(Me.GetValue(TableUtils.WDT_C_IDColumn).ToInt16(), Int16)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_C_ID field.
	''' </summary>
	Public Sub SetWDT_C_IDFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WDT_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_C_ID field.
	''' </summary>
	Public Sub SetWDT_C_IDFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WDT_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_C_ID field.
	''' </summary>
	Public Sub SetWDT_C_IDFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDT_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_C_ID field.
	''' </summary>
	Public Sub SetWDT_C_IDFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDT_C_IDColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_C_ID field.
	''' </summary>
	Public Sub SetWDT_C_IDFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDT_C_IDColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_Name field.
	''' </summary>
	Public Function GetWDT_NameValue() As ColumnValue
		Return Me.GetValue(TableUtils.WDT_NameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_Name field.
	''' </summary>
	Public Function GetWDT_NameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WDT_NameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Name field.
	''' </summary>
	Public Sub SetWDT_NameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WDT_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Name field.
	''' </summary>
	Public Sub SetWDT_NameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDT_NameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_Desc field.
	''' </summary>
	Public Function GetWDT_DescValue() As ColumnValue
		Return Me.GetValue(TableUtils.WDT_DescColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_Desc field.
	''' </summary>
	Public Function GetWDT_DescFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WDT_DescColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Desc field.
	''' </summary>
	Public Sub SetWDT_DescFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WDT_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Desc field.
	''' </summary>
	Public Sub SetWDT_DescFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDT_DescColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_Type field.
	''' </summary>
	Public Function GetWDT_TypeValue() As ColumnValue
		Return Me.GetValue(TableUtils.WDT_TypeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_Type field.
	''' </summary>
	Public Function GetWDT_TypeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.WDT_TypeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Type field.
	''' </summary>
	Public Sub SetWDT_TypeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WDT_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Type field.
	''' </summary>
	Public Sub SetWDT_TypeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDT_TypeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_Limit field.
	''' </summary>
	Public Function GetWDT_LimitValue() As ColumnValue
		Return Me.GetValue(TableUtils.WDT_LimitColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_Limit field.
	''' </summary>
	Public Function GetWDT_LimitFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WDT_LimitColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Limit field.
	''' </summary>
	Public Sub SetWDT_LimitFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WDT_LimitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Limit field.
	''' </summary>
	Public Sub SetWDT_LimitFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WDT_LimitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Limit field.
	''' </summary>
	Public Sub SetWDT_LimitFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDT_LimitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Limit field.
	''' </summary>
	Public Sub SetWDT_LimitFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDT_LimitColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Limit field.
	''' </summary>
	Public Sub SetWDT_LimitFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDT_LimitColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_Minimum field.
	''' </summary>
	Public Function GetWDT_MinimumValue() As ColumnValue
		Return Me.GetValue(TableUtils.WDT_MinimumColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's WDoc_Type_.WDT_Minimum field.
	''' </summary>
	Public Function GetWDT_MinimumFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.WDT_MinimumColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Minimum field.
	''' </summary>
	Public Sub SetWDT_MinimumFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.WDT_MinimumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Minimum field.
	''' </summary>
	Public Sub SetWDT_MinimumFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.WDT_MinimumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Minimum field.
	''' </summary>
	Public Sub SetWDT_MinimumFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDT_MinimumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Minimum field.
	''' </summary>
	Public Sub SetWDT_MinimumFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDT_MinimumColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's WDoc_Type_.WDT_Minimum field.
	''' </summary>
	Public Sub SetWDT_MinimumFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.WDT_MinimumColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WDoc_Type_.WDT_ID field.
	''' </summary>
	Public Property WDT_ID() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.WDT_IDColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WDT_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WDT_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WDT_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WDT_IDDefault() As String
        Get
            Return TableUtils.WDT_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WDoc_Type_.WDT_C_ID field.
	''' </summary>
	Public Property WDT_C_ID() As Int16
		Get 
			Return CType(Me.GetValue(TableUtils.WDT_C_IDColumn).ToInt16(), Int16)
		End Get
		Set (ByVal val As Int16) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WDT_C_IDColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WDT_C_IDSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WDT_C_IDColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WDT_C_IDDefault() As String
        Get
            Return TableUtils.WDT_C_IDColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WDoc_Type_.WDT_Name field.
	''' </summary>
	Public Property WDT_Name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WDT_NameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WDT_NameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WDT_NameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WDT_NameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WDT_NameDefault() As String
        Get
            Return TableUtils.WDT_NameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WDoc_Type_.WDT_Desc field.
	''' </summary>
	Public Property WDT_Desc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WDT_DescColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WDT_DescColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WDT_DescSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WDT_DescColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WDT_DescDefault() As String
        Get
            Return TableUtils.WDT_DescColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WDoc_Type_.WDT_Type field.
	''' </summary>
	Public Property WDT_Type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.WDT_TypeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.WDT_TypeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WDT_TypeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WDT_TypeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WDT_TypeDefault() As String
        Get
            Return TableUtils.WDT_TypeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WDoc_Type_.WDT_Limit field.
	''' </summary>
	Public Property WDT_Limit() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WDT_LimitColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WDT_LimitColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WDT_LimitSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WDT_LimitColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WDT_LimitDefault() As String
        Get
            Return TableUtils.WDT_LimitColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's WDoc_Type_.WDT_Minimum field.
	''' </summary>
	Public Property WDT_Minimum() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.WDT_MinimumColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.WDT_MinimumColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property WDT_MinimumSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.WDT_MinimumColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property WDT_MinimumDefault() As String
        Get
            Return TableUtils.WDT_MinimumColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
