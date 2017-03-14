﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWASS_Dynamics_Comp_EqGet') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWASS_Dynamics_Comp_EqGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[WASS_Dynamics_Comp_Eq] table.
CREATE PROCEDURE pePortalWFApprovalWASS_Dynamics_Comp_EqGet
        @pk_WDCE_ID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[WASS_Dynamics_Comp_Eq]
    WHERE [WDCE_ID] =@pk_WDCE_ID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [WDCE_ID],
        [WDCE_WASS_CompID],
        [WDCE_Dynamics_CompID],
        [WDCE_CompName],
        CAST(BINARY_CHECKSUM([WDCE_ID],[WDCE_WASS_CompID],[WDCE_Dynamics_CompID],[WDCE_CompName]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[WASS_Dynamics_Comp_Eq]
    WHERE [WDCE_ID] =@pk_WDCE_ID
    SET NOCOUNT OFF
END

