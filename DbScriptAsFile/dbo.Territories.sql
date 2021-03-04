USE [Northwind]
GO

/****** Object: Table [dbo].[Territories] Script Date: 4.03.2021 06:15:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Territories] (
    [TerritoryID]          NVARCHAR (20) NOT NULL,
    [TerritoryDescription] NCHAR (50)    NOT NULL,
    [RegionID]             INT           NOT NULL
);


