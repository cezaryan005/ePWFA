﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_User1Update') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_User1Update 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[W_User] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pePortalWFApprovalW_User1Update
    @pk_W_U_ID int,
    @p_W_U_User_Name varchar(20),
    @p_W_U_Password varchar(20),
    @p_W_U_Full_Name varchar(125),
    @p_W_U_Email varchar(40),
    @p_W_U_GP_User_Name varchar(20),
    @p_W_U_Designation varchar(250),
    @p_prevConValue nvarchar(max),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(max),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[W_User] WHERE [W_U_ID] = @pk_W_U_ID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[W_User]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[W_User]
            SET 
            [W_U_User_Name] = @p_W_U_User_Name,
            [W_U_Password] = @p_W_U_Password,
            [W_U_Full_Name] = @p_W_U_Full_Name,
            [W_U_Email] = @p_W_U_Email,
            [W_U_GP_User_Name] = @p_W_U_GP_User_Name,
            [W_U_Designation] = @p_W_U_Designation
            WHERE [W_U_ID] = @pk_W_U_ID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([W_U_ID],[W_U_User_Name],[W_U_Password],[W_U_Full_Name],[W_U_Email],[W_U_GP_User_Name],[W_U_Designation]) AS nvarchar(max)) 
            FROM [dbo].[W_User] with (rowlock, holdlock)
            WHERE [W_U_ID] = @pk_W_U_ID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[W_User]
                    SET 
                    [W_U_User_Name] = @p_W_U_User_Name,
                    [W_U_Password] = @p_W_U_Password,
                    [W_U_Full_Name] = @p_W_U_Full_Name,
                    [W_U_Email] = @p_W_U_Email,
                    [W_U_GP_User_Name] = @p_W_U_GP_User_Name,
                    [W_U_Designation] = @p_W_U_Designation
                    WHERE [W_U_ID] = @pk_W_U_ID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[W_User]', 16, 1)

        END
END

