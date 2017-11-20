CREATE TABLE [dbo].[Menu] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Text]         NVARCHAR (50)  NULL,
    [Link]         NVARCHAR (250) NULL,
    [DisplayOrder] INT            NULL,
    [Target]       NVARCHAR (50)  NULL,
    [Status]       BIT            NULL,
    [TypeID]       INT            NULL,
    CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED ([ID] ASC)
);

