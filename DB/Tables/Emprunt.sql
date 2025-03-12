CREATE TABLE [dbo].[Emprunt]
(
	[EmpruntId] INT IDENTITY(1,1) PRIMARY KEY,
	[PreteurId] INT NOT NULL,
	[EmprunteurId] INT NOT NULL,
	[JeuId] INT NOT NULL,
	[DateEmprunt] DATETIME NOT NULL DEFAULT GETDATE(),
	[DateRetour] DATETIME NULL,
	[EvaluationPreteur] INT NULL,
	[EvaluationEmprunteur] INT NULL,
	FOREIGN KEY (PreteurId) REFERENCES Utilisateur(UtilisateurId),
	FOREIGN KEY (EmprunteurId) REFERENCES Utilisateur(UtilisateurId),
	FOREIGN KEY (JeuId) REFERENCES Jeu(JeuId)
)
