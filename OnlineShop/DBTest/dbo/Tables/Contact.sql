CREATE TABLE [dbo].[Contact] (
    [ID]      INT   IDENTITY (1, 1) NOT NULL,
    [Content] NTEXT NULL,
    [Status]  BIT   NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED ([ID] ASC)
);

