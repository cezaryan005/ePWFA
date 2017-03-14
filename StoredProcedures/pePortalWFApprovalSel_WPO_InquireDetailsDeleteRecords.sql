﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_InquireDetailsDeleteRecords') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_InquireDetailsDeleteRecords 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a set of rows from the [dbo].[sel_WPO_InquireDetails] table
-- that match the specified search criteria.
-- Returns the number of rows deleted as an output parameter.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_InquireDetailsDeleteRecords
        @p_where_str nvarchar(max),
        @p_num_deleted int OUTPUT
AS
DECLARE
    @l_where_str nvarchar(max),
    @l_query_str nvarchar(max)
BEGIN

    -- Initialize the where string
    SET @l_where_str = ' '
    IF @p_where_str IS NOT NULL
        SET @l_where_str = ' WHERE ' + @p_where_str;

    SET @p_num_deleted = 0;

    -- Set up the query string
    SET @l_query_str =
        'DELETE [dbo].[sel_WPO_InquireDetails] ' +
        'FROM [dbo].[sel_WPO_InquireDetails] sel_WPO_InquireDetails_' +
        @l_where_str + ' ';

    -- Run the query
    EXECUTE (@l_query_str)

    -- Return the number of rows affected to the output parameter
    SELECT @p_num_deleted = @@ROWCOUNT

END

