USE [Northwind]
GO

/****** Object: Table [dbo].[CustomerDemographics] Script Date: 4.03.2021 06:13:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustomerDemographics] (
    [CustomerTypeID] NCHAR (10) NOT NULL,
    [CustomerDesc]   NTEXT      NULL
);


