﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in WCAR_MinimumSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ePortalWFApproval.Data

''' <summary>
''' The generated superclass for the <see cref="WCAR_MinimumSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="WCAR_MinimumTable"></see> class.
''' </remarks>
''' <seealso cref="WCAR_MinimumTable"></seealso>
''' <seealso cref="WCAR_MinimumSqlTable"></seealso>

Public Class BaseWCAR_MinimumSqlTable
	Inherits StoredProceduresSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String, ByVal applicationName As String)
		MyBase.New(connectionName, applicationName)
	End Sub
End Class
End Namespace
