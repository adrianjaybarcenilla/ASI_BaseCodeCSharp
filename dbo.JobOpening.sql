USE [BasecodeDB]
GO

/****** Object: Table [dbo].[JobOpening] Script Date: 04/07/2023 8:15:48 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[JobOpening] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Title]           NVARCHAR (100) NOT NULL,
    [Description]     NVARCHAR (MAX) NULL,
    [EmploymentType]  NVARCHAR (50)  NOT NULL,
    [ExperienceLevel] NVARCHAR (MAX) NOT NULL,
    [CreatedTime]     DATETIME       NULL,
    [CreatedBy]       NVARCHAR (100) NULL,
    [UpdatedTime]     DATETIME       NULL,
    [UpdatedBy]       NVARCHAR (100) NULL
);
