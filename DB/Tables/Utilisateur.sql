﻿CREATE TABLE [dbo].[Utilisateur]
(
	[UtilisateurId] INT IDENTITY(1,1) PRIMARY KEY,
	[Email] VARCHAR(255) NOT NULL,
	[MotDePasse] VARCHAR(255) NOT NULL,
	[Pseudo] VARCHAR(120) NOT NULL,
	[DateCreation] DATETIME NOT NULL DEFAULT GETDATE(),
	[DateDesactivation] DATETIME NULL
)
