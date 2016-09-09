USE [INVENTORY]
GO

/****** Object: Table [dbo].[tbl_MusicArtist] Script Date: 9/8/2016 7:00:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_MusicArtist] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (50) NULL,
    [MiddleName] NVARCHAR (50) NULL,
    [LastName]   NVARCHAR (50) NULL,
    [BirthDate]  DATE          NULL,
    [DeathDate]  DATE          NULL
);


