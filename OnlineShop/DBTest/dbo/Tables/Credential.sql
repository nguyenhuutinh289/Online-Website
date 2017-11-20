CREATE TABLE [dbo].[Credential] (
    [UserGroupID] VARCHAR (20) NOT NULL,
    [RoleID]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Credential] PRIMARY KEY CLUSTERED ([UserGroupID] ASC, [RoleID] ASC)
);

