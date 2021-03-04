USE [Northwind]
GO

/****** Object: Table [dbo].[OperationClaims] Script Date: 4.03.2021 06:14:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OperationClaims] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (250) NOT NULL
);


