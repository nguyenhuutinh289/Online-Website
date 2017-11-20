CREATE TABLE [dbo].[MenuType] (
    [ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NULL,
    CONSTRAINT [PK_MenuType] PRIMARY KEY CLUSTERED ([ID] ASC)
);

