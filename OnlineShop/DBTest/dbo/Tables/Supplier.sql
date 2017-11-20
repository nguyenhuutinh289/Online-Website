CREATE TABLE [dbo].[Supplier] (
    [SupplierID]  BIGINT         NOT NULL,
    [CompanyName] NVARCHAR (40)  NULL,
    [ContactName] NVARCHAR (40)  NULL,
    [Address]     NVARCHAR (100) NULL,
    [Phone]       NVARCHAR (15)  NULL,
    [Fax]         NVARCHAR (15)  NULL,
    CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED ([SupplierID] ASC)
);

