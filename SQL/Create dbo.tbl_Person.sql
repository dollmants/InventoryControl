USE [INVENTORY]
GO

/****** Object: Table [dbo].[tbl_Person] Script Date: 9/8/2016 7:00:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Person] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (50) NULL,
    [MiddleName] NVARCHAR (50) NULL,
    [Sirname]    NVARCHAR (50) NULL,
    [Nickname]   NVARCHAR (50) NULL,
    [BirthDate]  DATE          NULL,
    [DeathDate]  DATE          NULL
);


