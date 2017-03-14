﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_PRNo_QDetailsDelete') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_PRNo_QDetailsDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[WPO_PRNo_QDetails] table.
CREATE PROCEDURE pePortalWFApprovalWPO_PRNo_QDetailsDelete
        @pk_CompanyID smallint,
    @pk_PRNo varchar(50),
    @pk_PONo char(30)
AS
BEGIN
    DELETE [dbo].[WPO_PRNo_QDetails]
    WHERE [CompanyID] = @pk_CompanyID
    AND [PRNo] = @pk_PRNo
    AND [PONo] = @pk_PONo
END

