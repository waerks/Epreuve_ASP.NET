﻿CREATE TABLE [dbo].[Tag]
(
	[TagId] INT IDENTITY(1,1) PRIMARY KEY,
    [NomTag] VARCHAR(50) NOT NULL UNIQUE
)
