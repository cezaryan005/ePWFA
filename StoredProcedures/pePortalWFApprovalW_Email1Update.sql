﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_Email1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_Email1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[W_Email] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalW_Email1Update
    @pk_WE_ID int,
    @p_WE_U_ID int,
    @p_WE_Directory varchar(250),
    @p_WE_Site varchar(250),
    @p_WE_Template text,
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[W_Email] WHERE [WE_ID] = @pk_WE_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[W_Email]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[W_Email]
            SET 
            [WE_U_ID] = @p_WE_U_ID,
            [WE_Directory] = @p_WE_Directory,
            [WE_Site] = @p_WE_Site,
            [WE_Template] = @p_WE_Template
            WHERE [WE_ID] = @pk_WE_ID

            -- Make sure only one record is affected
            SET @l_rowcount = @@ROWCOUNT
            IF @l_rowcount = 0
                RAISERROR ('The record cannot be updated.', 16, 1)
            IF @l_rowcount > 1
                RAISERROR ('duplicate object instances.', 16, 1)

        END
    ELSE
        BEGIN
            -- Get the checksum value for the record 
            -- and put an update lock on the record to 
            -- ensure transactional integrity.  The lock
            -- will be release when the transaction is 
            -- later committed or rolled back.
            Select @l_newValue = CAST(BINARY_CHECKSUM([WE_ID],[WE_U_ID],[WE_Directory],[WE_Site],[WE_Template]) AS nvarchar(max)) 
            FROM [dbo].[W_Email] with (rowlock, holdlock)
            WHERE [WE_ID] = @pk_WE_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[W_Email]
                    SET 
                    [WE_U_ID] = @p_WE_U_ID,
                    [WE_Directory] = @p_WE_Directory,
                    [WE_Site] = @p_WE_Site,
                    [WE_Template] = @p_WE_Template
                    WHERE [WE_ID] = @pk_WE_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[W_Email]', 16, 1)

        END
END

