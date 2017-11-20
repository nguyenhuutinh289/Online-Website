CREATE TABLE [dbo].[Content] (
    [ID]               BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (250) NULL,
    [MetaTitle]        VARCHAR (250)  NULL,
    [Description]      NVARCHAR (500) NULL,
    [Image]            NVARCHAR (250) NULL,
    [CategoryID]       BIGINT         NULL,
    [Detail]           NTEXT          NULL,
    [Warranty]         INT            NULL,
    [CreatedDate]      DATETIME       CONSTRAINT [DF_Content_CreatedDate] DEFAULT (getdate()) NULL,
    [CreatedBy]        VARCHAR (50)   NULL,
    [ModifiedDate]     DATETIME       NULL,
    [ModifiedBy]       VARCHAR (50)   NULL,
    [MetaKeywords]     NVARCHAR (250) NULL,
    [MetaDescriptions] NCHAR (250)    NULL,
    [Status]           BIT            CONSTRAINT [DF_Content_Status] DEFAULT ((1)) NOT NULL,
    [TopHot]           DATETIME       NULL,
    [ViewCount]        INT            CONSTRAINT [DF_Content_ViewCount] DEFAULT ((0)) NULL,
    [Tags]             NVARCHAR (500) NULL,
    [Language]         VARCHAR (2)    NULL,
    CONSTRAINT [PK_Content] PRIMARY KEY CLUSTERED ([ID] ASC)
);

