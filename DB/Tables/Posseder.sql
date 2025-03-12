CREATE TABLE [dbo].[Posseder]
(
	[UtilisateurId] INT NOT NULL,
	[JeuId] INT NOT NULL,
	[Etat] VARCHAR(50) NOT NULL CHECK (Etat IN ('Neuf', 'Abimé', 'Incomplet')),
	PRIMARY KEY (UtilisateurId, JeuId),
	FOREIGN KEY (UtilisateurId) REFERENCES Utilisateur(UtilisateurId),
	FOREIGN KEY (JeuId) REFERENCES Jeu(JeuId)
)
