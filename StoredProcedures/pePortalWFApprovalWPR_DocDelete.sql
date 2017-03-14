﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_DocDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_DocDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPR_Doc] table.
CREATE PROCEDURE pePortalWFApprovalWPR_DocDelete
        @pk_WPRD_ID int
AS
BEGIN
    DELETE [dbo].[WPR_Doc]
    WHERE [WPRD_ID] = @pk_WPRD_ID
END

