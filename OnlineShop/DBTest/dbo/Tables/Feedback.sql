CREATE TABLE [dbo].[Feedback] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)  NULL,
    [Phone]       NVARCHAR (50)  NULL,
    [Email]       NVARCHAR (50)  NULL,
    [Address]     NVARCHAR (50)  NULL,
    [Content]     NVARCHAR (250) NULL,
    [CreatedDate] DATETIME       CONSTRAINT [DF_Feedback_CreatedDate] DEFAULT (getdate()) NULL,
    [Status]      BIT            NULL,
    CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED ([ID] ASC)
);

