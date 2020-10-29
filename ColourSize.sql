CREATE TABLE [dbo].[ColourSize] (
    [csColourSizeID] INT  IDENTITY (1, 1) NOT NULL,
    [csProductColourID] VARCHAR (100) NULL,
    [csSizeID] VARCHAR (100) NULL,
    [csQuantity] VARCHAR (100) NULL,
    [csReorder] VARCHAR (100) NULL
);