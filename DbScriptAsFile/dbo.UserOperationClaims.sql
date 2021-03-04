USE [Northwind]
GO

/****** Object: Table [dbo].[UserOperationClaims] Script Date: 4.03.2021 06:15:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserOperationClaims] (
    [Id]               INT IDENTITY (1, 1) NOT NULL,
    [UserId]           INT NOT NULL,
    [OperationClaimId] INT NOT NULL
);


