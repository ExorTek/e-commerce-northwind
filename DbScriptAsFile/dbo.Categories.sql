USE [Northwind]
GO

/****** Object: Table [dbo].[Categories] Script Date: 4.03.2021 06:12:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Categories] (
    [CategoryID]   INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName] NVARCHAR (15) NOT NULL,
    [Description]  NTEXT         NULL,
    [Picture]      IMAGE         NULL
);


GO
CREATE NONCLUSTERED INDEX [CategoryName]
    ON [dbo].[Categories]([CategoryName] ASC);


GO
ALTER TABLE [dbo].[Categories]
    ADD CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([CategoryID] ASC);


