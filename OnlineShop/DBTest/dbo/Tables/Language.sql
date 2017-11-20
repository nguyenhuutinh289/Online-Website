CREATE TABLE [dbo].[Language] (
    [ID]        VARCHAR (2)   NOT NULL,
    [Name]      NVARCHAR (50) NULL,
    [IsDefault] BIT           CONSTRAINT [DF_Language_IsDefault] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED ([ID] ASC)
);

