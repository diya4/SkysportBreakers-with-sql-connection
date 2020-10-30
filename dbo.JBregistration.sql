CREATE TABLE [dbo].[JBregistration] (
    [ID]           INT           IDENTITY (1, 1) NOT NULL,
    [PName]        VARCHAR (100) NULL,
    [PEmail]       VARCHAR (100) NULL,
    [PAddress]     VARCHAR (100) NULL,
    [PPhoneNumber] VARCHAR (100) NULL,
    [PHomeNumber]  VARCHAR (100) NULL,
    [CName]        VARCHAR (100) NULL,
    [CAge]         VARCHAR (100) NULL,
    [CDOB]         DATE NULL,
    [CGender]      CHAR (1)      NULL,
    [SkillLevel]   VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

