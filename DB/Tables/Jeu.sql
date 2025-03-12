CREATE TABLE [dbo].[Jeu]
(
	[JeuId] INT IDENTITY(1,1) PRIMARY KEY,
	[Nom] VARCHAR(255) NOT NULL,
	[Deescription] TEXT NOT NULL,
	[AgeMin] INT NOT NULL,
	[AgeMax] INT NOT NULL,
	[NbJoueurMin] INT NOT NULL,
	[NbJoueurMax] INT NOT NULL,
	[DureeMinute] INT NULL,
	[DateCreation] DATETIME NOT NULL DEFAULT GETDATE(),
	[EnregistreurId] INT NOT NULL,
	CONSTRAINT CK_JEU_AGE CHECK (AgeMin < AgeMax),
	CONSTRAINT CK_JEU_NBJOUEUR CHECK (NbJoueurMin <= NbJoueurMax),
	FOREIGN KEY (EnregistreurId) REFERENCES Utilisateur(UtilisateurId)
)
