USE [INVENTORY]
GO

/****** Object: Table [dbo].[tbl_AlbumName] Script Date: 9/8/2016 6:58:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_AlbumName] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [AlbumName]    NVARCHAR (250) NULL,
    [RealeaseDate] DATE           NULL
);


