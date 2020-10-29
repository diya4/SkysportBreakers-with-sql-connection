CREATE TABLE [dbo].[PurchaseOrderDetails] (
    [podID]     INT           IDENTITY (1, 1) NOT NULL,
    [podPurchaseOrderID]       VARCHAR (100) NULL,
    [podQuantity] VARCHAR (100) NULL,
    [podDescription]   VARCHAR (100) NULL,
    [podCost]  VARCHAR (100) NULL
);

