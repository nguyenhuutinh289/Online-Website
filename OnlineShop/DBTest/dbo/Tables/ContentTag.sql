CREATE TABLE [dbo].[ContentTag] (
    [ContentID] BIGINT       NOT NULL,
    [TagID]     VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_ContentTag] PRIMARY KEY CLUSTERED ([ContentID] ASC, [TagID] ASC)
);

