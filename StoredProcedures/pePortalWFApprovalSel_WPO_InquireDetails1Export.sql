﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_InquireDetails1Export') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_InquireDetails1Export 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pePortalWFApprovalSel_WPO_InquireDetails1Export
        @p_separator_str nvarchar(15),
        @p_title_str nvarchar(max),
        @p_select_str nvarchar(max),
        @p_join_str nvarchar(max),
        @p_where_str nvarchar(max),
        @p_num_exported int output
    AS
    DECLARE
        @l_title_str nvarchar(max),
        @l_select_str nvarchar(max),
        @l_from_str nvarchar(max),
        @l_join_str nvarchar(max),
        @l_where_str nvarchar(max),
        @l_query_select nvarchar(max),
        @l_query_union nvarchar(max),
        @l_query_from nvarchar(max)
    BEGIN
        -- Set up the title string from the column names.  Excel 
        -- will complain if the first column value is ID. So wrap
        -- the value with "".
        SET @l_title_str = @p_title_str + char(13)
        IF @p_title_str IS NULL
            BEGIN
            SET @l_title_str = 
                N'"CompanyID"' + @p_separator_str +
                N'"PONUMBER"' + @p_separator_str +
                N'"LineNumber"' + @p_separator_str +
                N'"ITEMNMBR"' + @p_separator_str +
                N'"ITEMDESC"' + @p_separator_str +
                N'"UOFM"' + @p_separator_str +
                N'"UNITCOST"' + @p_separator_str +
                N'"QTYORDER"' + @p_separator_str +
                N'"EXTDCOST"' + @p_separator_str +
                N'"DOCDATE"' + @p_separator_str +
                N'"REQSTDBY"' + @p_separator_str +
                N'"ORD"' + @p_separator_str +
                N'"COMMENTS"' + @p_separator_str +
                N'"COMMENT_4"' + @p_separator_str +
                N'"VENDORID"' + @p_separator_str +
                N'"VENDNAME"' + @p_separator_str +
                N'"WPOFR_Rate"' + @p_separator_str +
                N'"WPOFR_Unit_Cost"' + @p_separator_str +
                N'"WCur_Short"' + @p_separator_str +
                N'"ExtCostForex"' + ' ';
            END
        ELSE IF SUBSTRING(@l_title_str, 1, 2) = 'ID'
            SET @l_title_str = 
                '"' + 
                SUBSTRING(@l_title_str, 1, PATINDEX('%,%', @l_title_str)-1) + 
                '"' + 
                SUBSTRING(@l_title_str, PATINDEX('%,%', @l_title_str), LEN(@l_title_str)); 

        -- Set up the select string
        SET @l_select_str = @p_select_str
        IF @p_select_str IS NULL
            BEGIN
            SET @l_select_str = 
                N'IsNULL(Convert(nvarchar, sel_WPO_InquireDetails_.[CompanyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WPO_InquireDetails_.[PONUMBER], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WPO_InquireDetails_.[LineNumber]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WPO_InquireDetails_.[ITEMNMBR], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WPO_InquireDetails_.[ITEMDESC], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WPO_InquireDetails_.[UOFM], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WPO_InquireDetails_.[UNITCOST]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WPO_InquireDetails_.[QTYORDER]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WPO_InquireDetails_.[EXTDCOST]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WPO_InquireDetails_.[DOCDATE], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WPO_InquireDetails_.[REQSTDBY], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WPO_InquireDetails_.[ORD]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WPO_InquireDetails_.[COMMENTS], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WPO_InquireDetails_.[COMMENT_4], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WPO_InquireDetails_.[VENDORID], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WPO_InquireDetails_.[VENDNAME], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WPO_InquireDetails_.[WPOFR_Rate]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WPO_InquireDetails_.[WPOFR_Unit_Cost]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(sel_WPO_InquireDetails_.[WCur_Short], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, sel_WPO_InquireDetails_.[ExtCostForex]), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[sel_WPO_InquireDetails] sel_WPO_InquireDetails_';

        SET @l_join_str = @p_join_str
        if @p_join_str is null
            SET @l_join_str = ' ';

        -- Set up the where string
        SET @l_where_str = ' ';
        IF @p_where_str IS NOT NULL
            SET @l_where_str = @l_where_str + 'WHERE ' + @p_where_str;

        -- Construct the query string.  Append the result set with the title.
        SET @l_query_select = 
                'SELECT '''
        SET @l_query_union = 
                ''' UNION ALL ' +
                'SELECT '
        SET @l_query_from = 
                ' FROM ' + @l_from_str + ' ' + @l_join_str + ' ' +
                @l_where_str;

        -- Run the query
        EXECUTE (@l_query_select + @l_title_str + @l_query_union + @l_select_str+ @l_query_from)

        -- Return the total number of rows of the query
        SELECT @p_num_exported = @@rowcount
    END

