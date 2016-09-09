USE [INVENTORY]
GO

/****** Object: Table [dbo].[tbl_BarCode] Script Date: 9/8/2016 6:59:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_BarCode] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [BarCode] NVARCHAR (50) NULL
);


