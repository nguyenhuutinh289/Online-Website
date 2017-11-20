CREATE TABLE [dbo].[Order] (
    [ID]          BIGINT        IDENTITY (1, 1) NOT NULL,
    [CreatedDate] DATETIME      NULL,
    [CustomerID]  BIGINT        NULL,
    [ShipName]    NVARCHAR (50) NULL,
    [ShipMobile]  VARCHAR (50)  NULL,
    [ShipAddress] NVARCHAR (50) NULL,
    [ShipEmail]   NVARCHAR (50) NULL,
    [Status]      INT           NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([ID] ASC)
);

