create table [dbo].[JBregistration]
(
ID int identity (1,1) not null primary key,
PName varchar(100),
PEmail varchar(100),
PAddress varchar(100),
PPhoneNumber varchar(100),
PHomeNumber varchar(100),
CName varchar(100),
CAge varchar(100),
CDOB varchar(100),
CGender char(1),
SkillLevel varchar(100),
);