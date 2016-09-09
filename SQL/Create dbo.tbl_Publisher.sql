USE [INVENTORY]
GO

/****** Object: Table [dbo].[tbl_Publisher] Script Date: 9/8/2016 7:01:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Publisher] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [PublisherName] NVARCHAR (50) NULL
);


