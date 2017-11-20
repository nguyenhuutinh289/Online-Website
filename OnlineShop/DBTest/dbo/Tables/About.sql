CREATE TABLE [dbo].[About] (
    [ID]               BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (250) NULL,
    [MetaTitle]        VARCHAR (250)  NULL,
    [Description]      NVARCHAR (500) NULL,
    [Image]            NVARCHAR (250) NULL,
    [Detail]           NTEXT          NULL,
    [CreatedDate]      DATETIME       CONSTRAINT [DF_About_CreatedDate] DEFAULT (getdate()) NULL,
    [CreatedBy]        VARCHAR (50)   NULL,
    [ModifiedDate]     DATETIME       NULL,
    [ModifiedBy]       VARCHAR (50)   NULL,
    [MetaKeywords]     NVARCHAR (250) NULL,
    [MetaDescriptions] NCHAR (250)    NULL,
    [Status]           BIT            CONSTRAINT [DF_About_Status] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_About] PRIMARY KEY CLUSTERED ([ID] ASC)
);

