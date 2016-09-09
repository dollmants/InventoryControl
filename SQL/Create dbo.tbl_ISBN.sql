USE [INVENTORY]
GO

/****** Object: Table [dbo].[tbl_ISBN] Script Date: 9/8/2016 7:00:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_ISBN] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [ISBN] NVARCHAR (50) NULL
);


