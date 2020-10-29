CREATE TABLE [dbo].[Stores] (
    [sStoresID] INT           IDENTITY (1, 1) NOT NULL,
    [sStoreNumber]       VARCHAR (100) NULL,
    [sName]       VARCHAR (100) NULL,
    [sAddress1]       VARCHAR (100) NULL,
    [sAddress2]       VARCHAR (100) NULL,
    [sCityName]       VARCHAR (100) NULL,
    [sPostalCode]       VARCHAR (100) NULL,
    [sCountryID]       VARCHAR (100) NULL,
    [sMainPhone]       VARCHAR (100) NULL,
    [sTollFreeNumber]       VARCHAR (100) NULL,
    [sWebSite] VARCHAR (100) NULL,
    [sMainEmail]  VARCHAR (100) NULL,
);

