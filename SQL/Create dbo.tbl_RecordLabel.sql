USE [INVENTORY]
GO

/****** Object: Table [dbo].[tbl_RecordLabel] Script Date: 9/8/2016 7:01:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_RecordLabel] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [RecordLabelName] NVARCHAR (50) NULL
);


