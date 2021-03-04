USE [Northwind]
GO

/****** Object: Table [dbo].[EmployeeTerritories] Script Date: 4.03.2021 06:14:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EmployeeTerritories] (
    [EmployeeID]  INT           NOT NULL,
    [TerritoryID] NVARCHAR (20) NOT NULL
);


