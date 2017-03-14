﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCurrency1Delete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCurrency1Delete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WCurrency] table.
CREATE PROCEDURE pePortalWFApprovalWCurrency1Delete
        @pk_WCur_ID smallint
AS
BEGIN
    DELETE [dbo].[WCurrency]
    WHERE [WCur_ID] = @pk_WCur_ID
END

