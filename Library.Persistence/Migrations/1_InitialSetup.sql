CREATE TABLE [Library].[dbo].[Authors]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVarchar(max) NOT NULL
)

CREATE TABLE [Library].[dbo].[Books]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVarchar(max) NOT NULL,
	[PublishDate] Date NOT NULL
)

CREATE TABLE [Library].[dbo].[Lenders]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVarchar(max) NOT NULL,
)

CREATE TABLE [Library].[dbo].[Lendings]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[LendDate] Date NOT NULL,
	[ReturnDate] Date NOT NULL
)