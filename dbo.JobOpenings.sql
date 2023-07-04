USE [BasecodeDB]
GO

/****** Object: Table [dbo].[JobOpenings] Script Date: 04/07/2023 8:15:48 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[JobOpenings] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Title]           NVARCHAR (100) NOT NULL,
    [DateOfPosting]   DATE           NULL,
    [EmploymentType]  NVARCHAR (50)  NOT NULL,
    [JobDescription]  NVARCHAR (MAX) NULL,
    [RequiredSkills]  NVARCHAR (MAX) NOT NULL,
    [PreferredSkills] NVARCHAR (MAX) NULL,
    [PostedBy]        NVARCHAR (100) NULL,
    [PostedTime]      DATETIME       NULL
);


