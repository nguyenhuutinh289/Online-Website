CREATE TABLE [dbo].[SystemConfig] (
    [ID]     VARCHAR (50)   NOT NULL,
    [Name]   NVARCHAR (50)  NULL,
    [Type]   VARCHAR (50)   NULL,
    [Value]  NVARCHAR (250) NULL,
    [Status] BIT            NULL,
    CONSTRAINT [PK_SystemConfig] PRIMARY KEY CLUSTERED ([ID] ASC)
);

