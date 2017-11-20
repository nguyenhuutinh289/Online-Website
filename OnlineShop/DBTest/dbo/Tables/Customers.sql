CREATE TABLE [dbo].[Customers] (
    [CustomerID]   BIGINT         NOT NULL,
    [ContactTitle] NVARCHAR (30)  NULL,
    [Address]      NVARCHAR (100) NULL,
    [Phone]        NVARCHAR (24)  NULL,
    [Email]        NVARCHAR (24)  NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);

