CREATE TABLE [dbo].[Slide] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Image]        NVARCHAR (250) NULL,
    [DisplayOrder] INT            CONSTRAINT [DF_Slide_DisplayOrder] DEFAULT ((1)) NULL,
    [Link]         NVARCHAR (250) NULL,
    [CreatedDate]  DATETIME       CONSTRAINT [DF_Slide_CreatedDate] DEFAULT (getdate()) NULL,
    [Status]       BIT            NULL,
    CONSTRAINT [PK_Slide] PRIMARY KEY CLUSTERED ([ID] ASC)
);

