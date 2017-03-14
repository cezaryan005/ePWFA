﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_Email_DefaultGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_Email_DefaultGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[W_Email_Default] table.
CREATE PROCEDURE pePortalWFApprovalW_Email_DefaultGet
        @pk_WED_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[W_Email_Default]
    WHERE [WED_ID] =@pk_WED_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WED_ID],
        [WED_Type],
        [WED_Template],
        CAST(BINARY_CHECKSUM([WED_ID],[WED_Type],[WED_Template]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[W_Email_Default]
    WHERE [WED_ID] =@pk_WED_ID
    SET NOCOUNT OFF
END

