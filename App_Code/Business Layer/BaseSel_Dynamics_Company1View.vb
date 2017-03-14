﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in Sel_Dynamics_Company1View.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ePortalWFApproval.Data

Namespace ePortalWFApproval.Business

''' <summary>
''' The generated superclass for the <see cref="Sel_Dynamics_Company1View"></see> class.
''' Provides access to the schema information and record data of a database table or view named DatabaseWASS%dbo.sel_Dynamics_Company.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="Sel_Dynamics_Company1View.Instance">Sel_Dynamics_Company1View.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="Sel_Dynamics_Company1View"></seealso>

<Serializable()> Public Class BaseSel_Dynamics_Company1View
	Inherits KeylessTable
	

	Private ReadOnly TableDefinitionString As String = Sel_Dynamics_Company1Definition.GetXMLString()







	Protected Sub New()
		MyBase.New()
		Me.Initialize()
	End Sub

	Protected Overridable Sub Initialize()
		Dim def As New XmlTableDefinition(TableDefinitionString)
		Me.TableDefinition = New TableDefinition()
		Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.Sel_Dynamics_Company1View")
		def.InitializeTableDefinition(Me.TableDefinition)
		Me.ConnectionName = def.GetConnectionName()
		Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "ePortalWFApproval.Business.Sel_Dynamics_Company1Record")
		Me.ApplicationName = "App_Code"
		Me.DataAdapter = New Sel_Dynamics_Company1SqlView()
		Directcast(Me.DataAdapter, Sel_Dynamics_Company1SqlView).ConnectionName = Me.ConnectionName
		Directcast(Me.DataAdapter, Sel_Dynamics_Company1SqlView).ApplicationName = Me.ApplicationName
		Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        CMPANYIDColumn.CodeName = "CMPANYID"
        CMPNYNAMColumn.CodeName = "CMPNYNAM"
        INTERIDColumn.CodeName = "INTERID"
        FULLADDRESSColumn.CodeName = "FULLADDRESS"
        TAXREGTNColumn.CodeName = "TAXREGTN"
        ADDRESS1Column.CodeName = "ADDRESS1"
        ADDRESS2Column.CodeName = "ADDRESS2"
        ADDRESS3Column.CodeName = "ADDRESS3"
        CITYColumn.CodeName = "CITY"
        ZIPCODEColumn.CodeName = "ZIPCODE"
        COUNTYColumn.CodeName = "COUNTY"
        STATEColumn.CodeName = "STATE"
        PHONE2Column.CodeName = "PHONE2"
        PHONE1Column.CodeName = "PHONE1"
        PHONE3Column.CodeName = "PHONE3"
        FAXNUMBRColumn.CodeName = "FAXNUMBR"
        p1Column.CodeName = "p1"
        p2Column.CodeName = "p2"
        p3Column.CodeName = "p3"
        faxColumn.CodeName = "fax"
        LSTUSREDColumn.CodeName = "LSTUSRED"
        MODIFDTColumn.CodeName = "MODIFDT"
        Company_Short_NameColumn.CodeName = "Company_Short_Name"
		
	End Sub
	
#Region "Overriden methods"
    
#End Region
	
#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.CMPANYID column object.
    ''' </summary>
    Public ReadOnly Property CMPANYIDColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.CMPANYID column object.
    ''' </summary>
    Public Shared ReadOnly Property CMPANYID() As BaseClasses.Data.NumberColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.CMPANYIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.CMPNYNAM column object.
    ''' </summary>
    Public ReadOnly Property CMPNYNAMColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.CMPNYNAM column object.
    ''' </summary>
    Public Shared ReadOnly Property CMPNYNAM() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.CMPNYNAMColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.INTERID column object.
    ''' </summary>
    Public ReadOnly Property INTERIDColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.INTERID column object.
    ''' </summary>
    Public Shared ReadOnly Property INTERID() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.INTERIDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.FULLADDRESS column object.
    ''' </summary>
    Public ReadOnly Property FULLADDRESSColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.FULLADDRESS column object.
    ''' </summary>
    Public Shared ReadOnly Property FULLADDRESS() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.FULLADDRESSColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.TAXREGTN column object.
    ''' </summary>
    Public ReadOnly Property TAXREGTNColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.TAXREGTN column object.
    ''' </summary>
    Public Shared ReadOnly Property TAXREGTN() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.TAXREGTNColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.ADDRESS1 column object.
    ''' </summary>
    Public ReadOnly Property ADDRESS1Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.ADDRESS1 column object.
    ''' </summary>
    Public Shared ReadOnly Property ADDRESS1() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.ADDRESS1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.ADDRESS2 column object.
    ''' </summary>
    Public ReadOnly Property ADDRESS2Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.ADDRESS2 column object.
    ''' </summary>
    Public Shared ReadOnly Property ADDRESS2() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.ADDRESS2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.ADDRESS3 column object.
    ''' </summary>
    Public ReadOnly Property ADDRESS3Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.ADDRESS3 column object.
    ''' </summary>
    Public Shared ReadOnly Property ADDRESS3() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.ADDRESS3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.CITY column object.
    ''' </summary>
    Public ReadOnly Property CITYColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.CITY column object.
    ''' </summary>
    Public Shared ReadOnly Property CITY() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.CITYColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.ZIPCODE column object.
    ''' </summary>
    Public ReadOnly Property ZIPCODEColumn() As BaseClasses.Data.UsaZipCodeColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.UsaZipCodeColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.ZIPCODE column object.
    ''' </summary>
    Public Shared ReadOnly Property ZIPCODE() As BaseClasses.Data.UsaZipCodeColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.ZIPCODEColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.COUNTY column object.
    ''' </summary>
    Public ReadOnly Property COUNTYColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.COUNTY column object.
    ''' </summary>
    Public Shared ReadOnly Property COUNTY() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.COUNTYColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.STATE column object.
    ''' </summary>
    Public ReadOnly Property STATEColumn() As BaseClasses.Data.UsaStateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.UsaStateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.STATE column object.
    ''' </summary>
    Public Shared ReadOnly Property STATE() As BaseClasses.Data.UsaStateColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.STATEColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.PHONE2 column object.
    ''' </summary>
    Public ReadOnly Property PHONE2Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.PHONE2 column object.
    ''' </summary>
    Public Shared ReadOnly Property PHONE2() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.PHONE2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.PHONE1 column object.
    ''' </summary>
    Public ReadOnly Property PHONE1Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.PHONE1 column object.
    ''' </summary>
    Public Shared ReadOnly Property PHONE1() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.PHONE1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.PHONE3 column object.
    ''' </summary>
    Public ReadOnly Property PHONE3Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.PHONE3 column object.
    ''' </summary>
    Public Shared ReadOnly Property PHONE3() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.PHONE3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.FAXNUMBR column object.
    ''' </summary>
    Public ReadOnly Property FAXNUMBRColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.FAXNUMBR column object.
    ''' </summary>
    Public Shared ReadOnly Property FAXNUMBR() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.FAXNUMBRColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.p1 column object.
    ''' </summary>
    Public ReadOnly Property p1Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.p1 column object.
    ''' </summary>
    Public Shared ReadOnly Property p1() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.p1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.p2 column object.
    ''' </summary>
    Public ReadOnly Property p2Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.p2 column object.
    ''' </summary>
    Public Shared ReadOnly Property p2() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.p2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.p3 column object.
    ''' </summary>
    Public ReadOnly Property p3Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.p3 column object.
    ''' </summary>
    Public Shared ReadOnly Property p3() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.p3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.fax column object.
    ''' </summary>
    Public ReadOnly Property faxColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.fax column object.
    ''' </summary>
    Public Shared ReadOnly Property fax() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.faxColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.LSTUSRED column object.
    ''' </summary>
    Public ReadOnly Property LSTUSREDColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.LSTUSRED column object.
    ''' </summary>
    Public Shared ReadOnly Property LSTUSRED() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.LSTUSREDColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.MODIFDT column object.
    ''' </summary>
    Public ReadOnly Property MODIFDTColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.MODIFDT column object.
    ''' </summary>
    Public Shared ReadOnly Property MODIFDT() As BaseClasses.Data.DateColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.MODIFDTColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.Company_Short_Name column object.
    ''' </summary>
    Public ReadOnly Property Company_Short_NameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's sel_Dynamics_Company_.Company_Short_Name column object.
    ''' </summary>
    Public Shared ReadOnly Property Company_Short_Name() As BaseClasses.Data.StringColumn
        Get
            Return Sel_Dynamics_Company1View.Instance.Company_Short_NameColumn
        End Get
    End Property


#End Region

#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_Dynamics_Company1Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As Sel_Dynamics_Company1Record()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_Dynamics_Company1Record records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal join As BaseFilter, ByVal where As String) As Sel_Dynamics_Company1Record()

        Return GetRecords(join, where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_Dynamics_Company1Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Sel_Dynamics_Company1Record()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_Dynamics_Company1Record records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Sel_Dynamics_Company1Record()

        Return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_Dynamics_Company1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Sel_Dynamics_Company1Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing 
        Dim recList As ArrayList =  Sel_Dynamics_Company1View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Sel_Dynamics_Company1Record)), Sel_Dynamics_Company1Record())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_Dynamics_Company1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Sel_Dynamics_Company1Record()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  Sel_Dynamics_Company1View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Sel_Dynamics_Company1Record)), Sel_Dynamics_Company1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Sel_Dynamics_Company1Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = Sel_Dynamics_Company1View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Sel_Dynamics_Company1Record)), Sel_Dynamics_Company1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Sel_Dynamics_Company1Record()

        Dim recList As ArrayList = Sel_Dynamics_Company1View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Sel_Dynamics_Company1Record)), Sel_Dynamics_Company1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As Sel_Dynamics_Company1Record()
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = Sel_Dynamics_Company1View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Sel_Dynamics_Company1Record)), Sel_Dynamics_Company1Record())
    End Function

    Public Shared Function GetRecords( _
     ByVal join As BaseFilter, _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer, _
     ByRef totalRecords As Integer) As Sel_Dynamics_Company1Record()

        Dim recList As ArrayList = Sel_Dynamics_Company1View.Instance.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize, totalRecords)

        Return CType(recList.ToArray(GetType(ePortalWFApproval.Business.Sel_Dynamics_Company1Record)), Sel_Dynamics_Company1Record())
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function PostGetRecordCount(ByVal selectCols As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal finalFilter As BaseFilter) As Integer
	      Return CInt(Sel_Dynamics_Company1View.Instance.GetCountResponseForPost(Sel_Dynamics_Company1View.Instance.TableDefinition, selectCols, join, finalFilter))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Sel_Dynamics_Company1Record records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function PostGetRecordList(ByVal requestedSelection As SqlBuilderColumnSelection, ByVal workingSelection As SqlBuilderColumnSelection, _
		ByVal distinctSelection As SqlBuilderColumnSelection, ByVal join As BaseFilter, ByVal filter As BaseFilter, ByVal groupBy As GroupBy, _
	    ByVal sortOrder As OrderBy, ByVal startIndex As Integer, ByVal count As Integer, ByRef totalCount As Integer, ByVal fromDataSource As [Boolean], _
	    Optional ByVal table As KeylessVirtualTable = Nothing, Optional isGetColumnValues As Boolean = False) As ArrayList
	      
		Dim recList As ArrayList = Nothing
		If IsNothing(table) Then
			recList = Sel_Dynamics_Company1View.Instance.GetRecordListResponseForPost(Sel_Dynamics_Company1View.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection, join, filter, _
			groupBy, sortOrder, startIndex, count, totalCount, fromDataSource, isGetColumnValues)
		ElseIf Not IsNothing(table) Then
			recList = table.GetDataSourceResponseForPost(requestedSelection, workingSelection, distinctSelection, join, filter, _
			groupBy, sortOrder, startIndex, count, totalCount, fromDataSource)
		End If

		Return recList
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(Sel_Dynamics_Company1View.Instance.GetRecordListCount(Nothing, whereFilter, Nothing, Nothing))
    End Function

''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(Sel_Dynamics_Company1View.Instance.GetRecordListCount(join, whereFilter, Nothing, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(Sel_Dynamics_Company1View.Instance.GetRecordListCount(Nothing, where.GetFilter(), Nothing, Nothing))
    End Function
    
      Public Shared Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer
        Return CInt(Sel_Dynamics_Company1View.Instance.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Sel_Dynamics_Company1Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As Sel_Dynamics_Company1Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Sel_Dynamics_Company1Record record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal join As BaseFilter, ByVal where As String) As Sel_Dynamics_Company1Record
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(join, where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Sel_Dynamics_Company1Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Sel_Dynamics_Company1Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If
        Dim join As BaseClasses.Data.BaseFilter = Nothing
        Dim recList As ArrayList = Sel_Dynamics_Company1View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As Sel_Dynamics_Company1Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), Sel_Dynamics_Company1Record)
        End If

        Return rec
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Sel_Dynamics_Company1Record record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal join As BaseFilter, _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Sel_Dynamics_Company1Record

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = Sel_Dynamics_Company1View.Instance.GetRecordList(join, whereFilter, Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As Sel_Dynamics_Company1Record = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), Sel_Dynamics_Company1Record)
        End If

        Return rec
    End Function


    Public Shared Function GetValues( _
        ByVal col As BaseColumn, _
         ByVal where As WhereClause, _
         ByVal orderBy As OrderBy, _
         ByVal maxItems As Integer) As String()

        ' Create the filter list.
        Dim retCol As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, True)
        retCol.AddColumn(col)

        Return Sel_Dynamics_Company1View.Instance.GetColumnValues(retCol, Nothing, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function

    Public Shared Function GetValues( _
         ByVal col As BaseColumn, _
         ByVal join As BaseFilter, _
         ByVal where As WhereClause, _
         ByVal orderBy As OrderBy, _
         ByVal maxItems As Integer) As String()

        ' Create the filter list.
        Dim retCol As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, True)
        retCol.AddColumn(col)

        Return Sel_Dynamics_Company1View.Instance.GetColumnValues(retCol, join, where.GetFilter(), Nothing, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As Sel_Dynamics_Company1Record = GetRecords(where)
        Return Sel_Dynamics_Company1View.Instance.CreateDataTable(recs, Nothing)
    End Function
    
    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String) As System.Data.DataTable

        Dim recs() As Sel_Dynamics_Company1Record = GetRecords(join, where)
        Return Sel_Dynamics_Company1View.Instance.CreateDataTable(recs, Nothing)
    End Function
    

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As Sel_Dynamics_Company1Record = GetRecords(where, orderBy)
        Return Sel_Dynamics_Company1View.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal join As BaseFilter, ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As Sel_Dynamics_Company1Record = GetRecords(join, where, orderBy)
        Return Sel_Dynamics_Company1View.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As Sel_Dynamics_Company1Record = GetRecords(where, orderBy, pageIndex, pageSize)
        Return Sel_Dynamics_Company1View.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal join As BaseFilter, _    
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As Sel_Dynamics_Company1Record = GetRecords(join, where, orderBy, pageIndex, pageSize)
        Return Sel_Dynamics_Company1View.Instance.CreateDataTable(recs, Nothing)
    End Function


    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        Sel_Dynamics_Company1View.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return Sel_Dynamics_Company1View.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return Sel_Dynamics_Company1View.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function GetSum( _
        ByVal col As BaseColumn, _
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum)

        Return Sel_Dynamics_Company1View.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function

    Public Shared Function GetSum( _
        ByVal col As BaseColumn, _
        ByVal join As BaseFilter, _        
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum)

        Return Sel_Dynamics_Company1View.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function

    
    Public Shared Function GetCount( _
        ByVal col As BaseColumn, _
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count)

        Return Sel_Dynamics_Company1View.Instance.GetColumnStatistics(colSel, Nothing, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function
    
    Public Shared Function GetCount( _
        ByVal col As BaseColumn, _
        ByVal join As BaseFilter, _         
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count)

        Return Sel_Dynamics_Company1View.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)

    End Function    

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return Sel_Dynamics_Company1View.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return Sel_Dynamics_Company1View.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return Sel_Dynamics_Company1View.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return Sel_Dynamics_Company1View.Instance.CreateRecord(tempId)
    End Function

    ''' <summary>
    ''' This method checks if column is editable.
    ''' </summary>
    ''' <param name="columnName">Name of the column to check.</param>
    Public Shared Function isReadOnlyColumn(ByVal columnName As String) As Boolean
        Dim column As BaseColumn = GetColumn(columnName)
        If (Not IsNothing(column)) Then
            Return column.IsValuesReadOnly
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="uniqueColumnName">Unique name of the column to fetch.</param>
    Public Shared Function GetColumn(ByVal uniqueColumnName As String) As BaseColumn
        Dim column As BaseColumn = Sel_Dynamics_Company1View.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     


    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="name">name of the column to fetch.</param>
    Public Shared Function GetColumnByName(ByVal name As String) As BaseColumn
        Dim column As BaseColumn = Sel_Dynamics_Company1View.Instance.TableDefinition.ColumnList.GetByInternalName(name)
        Return column
    End Function       
        

	 ''' <summary>
     ''' This method takes a record and a Column and returns an evaluated value of DFKA formula.
     ''' </summary>
	Public Shared Function GetDFKA(ByVal rec As BaseRecord, ByVal col As BaseColumn) As String
	    Dim fkColumn As ForeignKey = Sel_Dynamics_Company1View.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
	    If fkColumn Is Nothing Then
 			Return Nothing
		End If
        Dim _DFKA As String = fkColumn.PrimaryKeyDisplayColumns
        If (_DFKA.Trim().StartsWith("=")) Then
            ' if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
            Dim tableCodeName As String = fkColumn.PrimaryKeyTableDefinition.TableCodeName
            Dim column As String = _DFKA.Trim("="c).Trim()
            If column.StartsWith(tableCodeName & ".", StringComparison.InvariantCultureIgnoreCase) Then
                column = column.Substring(tableCodeName.Length + 1)
            End If

            For Each c As BaseColumn In fkColumn.PrimaryKeyTableDefinition.Columns
                If column = c.CodeName Then
                    Return rec.Format(c)
                End If
            Next        
			Dim tableName As String = fkColumn.PrimaryKeyTableDefinition.TableCodeName
			Return EvaluateFormula(_DFKA, rec, Nothing, tableName)
		Else
            Return Nothing
        End If
    End Function

	''' <summary>
    ''' This method takes a keyValue and a Column and returns an evaluated value of DFKA formula.
    ''' </summary>
	Public Shared Function GetDFKA(ByVal keyValue As String, ByVal col As BaseColumn, ByVal formatPattern as String) As String
	    If keyValue Is Nothing Then
 			Return Nothing
		End If
	    Dim fkColumn As ForeignKey = Sel_Dynamics_Company1View.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col)
	    If fkColumn Is Nothing Then
 			Return Nothing
		End If
        Dim _DFKA As String = fkColumn.PrimaryKeyDisplayColumns
        If (_DFKA.Trim().StartsWith("=")) Then
			Dim tableName As String = fkColumn.PrimaryKeyTableDefinition.TableCodeName
			Dim t As PrimaryKeyTable = CType(DatabaseObjects.GetTableObject(tableName), PrimaryKeyTable)
			Dim rec As BaseRecord = Nothing
			If Not t Is Nothing Then
				Try
					rec = CType(t.GetRecordData(keyValue, False), BaseRecord)
				Catch 
					rec = Nothing
				End Try
			End If
			If rec Is Nothing Then
				Return ""
			End If
			
            ' if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
            Dim tableCodeName As String = fkColumn.PrimaryKeyTableDefinition.TableCodeName
            Dim column As String = _DFKA.Trim("="c).Trim()
            If column.StartsWith(tableCodeName & ".", StringComparison.InvariantCultureIgnoreCase) Then
                column = column.Substring(tableCodeName.Length + 1)
            End If

            For Each c As BaseColumn In fkColumn.PrimaryKeyTableDefinition.Columns
                If column = c.CodeName Then
                    Return rec.Format(c)
                End If
            Next			
			Return EvaluateFormula(_DFKA, rec, Nothing, tableName)
		Else
            Return Nothing
        End If
    End Function
    
	''' <summary>
    ''' Evaluates the formula
    ''' </summary>
	Public Shared Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format As String = Nothing, Optional ByVal name As String = "") As String
		Dim e As BaseFormulaEvaluator = New BaseFormulaEvaluator()
		If Not dataSourceForEvaluate Is Nothing Then
			e.Evaluator.Variables.Add(name, dataSourceForEvaluate)
        end if
        e.DataSource = dataSourceForEvaluate

        Dim resultObj As Object = e.Evaluate(formula)
        If resultObj Is Nothing Then
	        Return ""
        End If
        If Not String.IsNullOrEmpty(format) Then
            Return BaseFormulaUtils.Format(resultObj, format)
        Else
            Return resultObj.ToString()
        End If
    End Function
#End Region	

End Class
End Namespace
