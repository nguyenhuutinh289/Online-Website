CREATE TABLE [dbo].[OrderDetail] (
    [ProductID] BIGINT       NOT NULL,
    [OrderID]   BIGINT       NOT NULL,
    [Quantity]  INT          CONSTRAINT [DF_OrderDetail_Quantity] DEFAULT ((1)) NULL,
    [Price]     DECIMAL (18) NULL,
    CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED ([ProductID] ASC, [OrderID] ASC)
);

