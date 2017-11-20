CREATE TABLE [dbo].[ProductCategory] (
    [ID]               BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (250) NULL,
    [MetaTitle]        VARCHAR (250)  NULL,
    [ParentID]         BIGINT         NULL,
    [DisplayOrder]     INT            CONSTRAINT [DF_ProductCategory_DisplayOrder] DEFAULT ((0)) NULL,
    [SeoTitle]         NVARCHAR (250) NULL,
    [CreatedDate]      DATETIME       CONSTRAINT [DF_ProductCategory_CreatedDate] DEFAULT (getdate()) NULL,
    [CreatedBy]        VARCHAR (50)   NULL,
    [ModifiedDate]     DATETIME       NULL,
    [ModifiedBy]       VARCHAR (50)   NULL,
    [MetaKeywords]     NVARCHAR (250) NULL,
    [MetaDescriptions] NCHAR (250)    NULL,
    [Status]           BIT            CONSTRAINT [DF_ProductCategory_Status] DEFAULT ((1)) NULL,
    [ShowOnHome]       BIT            CONSTRAINT [DF_ProductCategory_ShowOnHome] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED ([ID] ASC)
);

