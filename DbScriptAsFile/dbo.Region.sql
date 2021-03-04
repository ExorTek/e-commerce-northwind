USE [Northwind]
GO

/****** Object: Table [dbo].[Region] Script Date: 4.03.2021 06:14:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Region] (
    [RegionID]          INT        NOT NULL,
    [RegionDescription] NCHAR (50) NOT NULL
);


