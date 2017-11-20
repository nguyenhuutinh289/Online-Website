CREATE TABLE [dbo].[Footer] (
    [ID]      VARCHAR (50) NOT NULL,
    [Content] NTEXT        NULL,
    [Status]  BIT          NULL,
    CONSTRAINT [PK_Footer] PRIMARY KEY CLUSTERED ([ID] ASC)
);

