CREATE TABLE [dbo].[Shipper] (
    [ShipperID]   INT           NOT NULL,
    [CompanyName] NVARCHAR (40) NULL,
    [Phone]       NVARCHAR (24) NULL,
    CONSTRAINT [PK_Shipper] PRIMARY KEY CLUSTERED ([ShipperID] ASC)
);

