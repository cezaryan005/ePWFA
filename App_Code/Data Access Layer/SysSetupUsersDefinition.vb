﻿Namespace ePortalWFApproval.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="SysSetupUsersTable">ePortalWFApproval.SysSetupUsersTable</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="SysSetupUsersTable"></seealso>

Public Class SysSetupUsersDefinition

#Region "Definition (XML) for SysSetupUsersDefinition table"
	'Next 318 lines contain Table Definition (XML) for table "SysSetupUsersDefinition"
	Private Shared _DefinitionString As String = ""
#End Region
	
	''' <summary>
	''' Gets the embedded schema and configuration data for the  
	''' <see cref="SysSetupUsersTable"></see>
	''' class's TableDefinition.
	''' </summary>
	''' <remarks>This function is only called once at runtime.</remarks>
	''' <returns>An XML string.</returns>
	Public Shared Function GetXMLString() As String
		If _DefinitionString = "" Then
			         Dim tbf As System.Text.StringBuilder = New System.Text.StringBuilder()
         tbf.Append("<XMLDefinition Generator=""Iron Speed Designer"" Version=""12.1"" Type=""GENERIC"">")
         tbf.Append(  "<ColumnDefinition>")
         tbf.Append(    "<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">")
         tbf.Append(      "<columnName>SSU_UserName</columnName>")
         tbf.Append(      "<columnUIName>SSU User Name</columnUIName>")
         tbf.Append(      "<columnType>String</columnType>")
         tbf.Append(      "<columnDBType>char</columnDBType>")
         tbf.Append(      "<columnLengthSet>15</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>Y</columnIndex>")
         tbf.Append(      "<columnUnique>Y</columnUnique>")
         tbf.Append(      "<columnFunction>notrim</columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>Y</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>Y</columnRequired>")
         tbf.Append(      "<columnNotNull>Y</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">")
         tbf.Append(      "<columnName>SSU_FullName</columnName>")
         tbf.Append(      "<columnUIName>SSU Full Name</columnUIName>")
         tbf.Append(      "<columnType>String</columnType>")
         tbf.Append(      "<columnDBType>varchar</columnDBType>")
         tbf.Append(      "<columnLengthSet>50</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">")
         tbf.Append(      "<columnName>SSU_Password</columnName>")
         tbf.Append(      "<columnUIName>SSU Password</columnUIName>")
         tbf.Append(      "<columnType>Password</columnType>")
         tbf.Append(      "<columnDBType>varchar</columnDBType>")
         tbf.Append(      "<columnLengthSet>50</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">")
         tbf.Append(      "<columnName>SSU_EmpID</columnName>")
         tbf.Append(      "<columnUIName>SSU Employee</columnUIName>")
         tbf.Append(      "<columnType>Number</columnType>")
         tbf.Append(      "<columnDBType>int</columnDBType>")
         tbf.Append(      "<columnLengthSet>10.0</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">")
         tbf.Append(      "<columnName>SSU_SSC_CompanyID</columnName>")
         tbf.Append(      "<columnUIName>SSU SSC Company</columnUIName>")
         tbf.Append(      "<columnType>Number</columnType>")
         tbf.Append(      "<columnDBType>smallint</columnDBType>")
         tbf.Append(      "<columnLengthSet>5.0</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction>notrim</columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(      "<foreignKey>")
         tbf.Append(        "<columnFKName>FK_SysSetupUsers_SysSetupCompany</columnFKName>")
         tbf.Append(        "<columnFKTable>ePortalWFApproval.Business.SysSetupCompanyTable, App_Code</columnFKTable>")
         tbf.Append(        "<columnFKOwner>dbo</columnFKOwner>")
         tbf.Append(        "<columnFKColumn>SSC_CompanyID</columnFKColumn>")
         tbf.Append(        "<columnFKColumnDisplay>SSC_CompanyName</columnFKColumnDisplay>")
         tbf.Append(        "<foreignKeyType>Explicit</foreignKeyType>")
         tbf.Append(      "</foreignKey>")
         tbf.Append(      "<applyDFKA>Y</applyDFKA>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""5"" Priority=""6"" ColumnNum=""5"">")
         tbf.Append(      "<columnName>SSU_IsActive</columnName>")
         tbf.Append(      "<columnUIName>SSU Is Active</columnUIName>")
         tbf.Append(      "<columnType>Boolean</columnType>")
         tbf.Append(      "<columnDBType>bit</columnDBType>")
         tbf.Append(      "<columnLengthSet></columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault>(1)</columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""6"" Priority=""7"" ColumnNum=""6"">")
         tbf.Append(      "<columnName>SSU_DateCreated</columnName>")
         tbf.Append(      "<columnUIName>SSU Date Created</columnUIName>")
         tbf.Append(      "<columnType>Date</columnType>")
         tbf.Append(      "<columnDBType>datetime</columnDBType>")
         tbf.Append(      "<columnLengthSet></columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault>getdate()</columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction>notrim</columnFunction>")
         tbf.Append(      "<columnFormat>g</columnFormat>")
         tbf.Append(      "<columnDBFormat>g</columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""7"" Priority=""8"" ColumnNum=""7"">")
         tbf.Append(      "<columnName>SSU_DateModified</columnName>")
         tbf.Append(      "<columnUIName>SSU Date Modified</columnUIName>")
         tbf.Append(      "<columnType>Date</columnType>")
         tbf.Append(      "<columnDBType>datetime</columnDBType>")
         tbf.Append(      "<columnLengthSet></columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault>getdate()</columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction>notrim</columnFunction>")
         tbf.Append(      "<columnFormat>g</columnFormat>")
         tbf.Append(      "<columnDBFormat>g</columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""8"" Priority=""9"" ColumnNum=""8"">")
         tbf.Append(      "<columnName>SSU_RowID</columnName>")
         tbf.Append(      "<columnUIName>SSU Row</columnUIName>")
         tbf.Append(      "<columnType>Number</columnType>")
         tbf.Append(      "<columnDBType>int</columnDBType>")
         tbf.Append(      "<columnLengthSet>10.0</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>Y</columnComputed>")
         tbf.Append(      "<columnIdentity>Y</columnIdentity>")
         tbf.Append(      "<columnReadOnly>Y</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>Y</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""9"" Priority=""10"" ColumnNum=""9"">")
         tbf.Append(      "<columnName>SSU_GPUsername</columnName>")
         tbf.Append(      "<columnUIName>SSU GPUsername</columnUIName>")
         tbf.Append(      "<columnType>String</columnType>")
         tbf.Append(      "<columnDBType>varchar</columnDBType>")
         tbf.Append(      "<columnLengthSet>20</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""10"" Priority=""11"" ColumnNum=""10"">")
         tbf.Append(      "<columnName>SSU_Designation</columnName>")
         tbf.Append(      "<columnUIName>SSU Designation</columnUIName>")
         tbf.Append(      "<columnType>String</columnType>")
         tbf.Append(      "<columnDBType>varchar</columnDBType>")
         tbf.Append(      "<columnLengthSet>250</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(  "</ColumnDefinition>")
         tbf.Append(  "<TableName>SysSetupUsers</TableName>")
         tbf.Append(  "<Version></Version>")
         tbf.Append(  "<Owner>dbo</Owner>")
         tbf.Append(  "<TableAliasName>SysSetupUsers_</TableAliasName>")
         tbf.Append(  "<ConnectionName>DatabaseWASS</ConnectionName>")
         tbf.Append(  "<PagingMethod>RowNum</PagingMethod>")
         tbf.Append(  "<canCreateRecords Source=""Database"">Y</canCreateRecords>")
         tbf.Append(  "<canEditRecords Source=""Database"">Y</canEditRecords>")
         tbf.Append(  "<canDeleteRecords Source=""Database"">Y</canDeleteRecords>")
         tbf.Append(  "<canViewRecords Source=""Database"">Y</canViewRecords>")
         tbf.Append(  "<ConcurrencyMethod>BinaryChecksum</ConcurrencyMethod>")
         tbf.Append(  "<AppShortName>ePortalWFApproval</AppShortName>")
         tbf.Append(  "<FolderName>SysSetupUsers</FolderName>")
         tbf.Append(  "<MenuName>System Setup Users</MenuName>")
         tbf.Append(  "<QSPath>../SysSetupUsers/SysSetupUsers-QuickSelector.aspx</QSPath>")
         tbf.Append(  "<TableCodeName>SysSetupUsers</TableCodeName>")
         tbf.Append(  "<TableStoredProcPrefix>pePortalWFApprovalSysSetupUsers</TableStoredProcPrefix>")
         tbf.Append("</XMLDefinition>")
         _DefinitionString = tbf.ToString()

		End	If	
		Return _DefinitionString		
	End Function

End Class
End Namespace
