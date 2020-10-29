CREATE TABLE [dbo].[ProductLocation] (
    [pclProductLocationID] INT           IDENTITY (1, 1) NOT NULL,
    [plStoreID]       VARCHAR (100) NULL,
    [plInventoryLocationID]        VARCHAR (100) NULL,
    [pcColourSizeID]           VARCHAR (100) NULL,
    [pcQuantity]       VARCHAR (100) NULL
);

