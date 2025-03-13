/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

-- Insertion des Utilisateurs
INSERT INTO [dbo].[Utilisateur] (Email, MotDePasse, Pseudo, DateCreation, DateDesactivation)
VALUES 
    ('john.doe@example.com', 'password1', 'JohnDoe', GETDATE(), NULL),
    ('jane.smith@example.com', 'password2', 'JaneSmith', GETDATE(), NULL),
    ('bob.brown@example.com', 'password3', 'BobBrown', GETDATE(), NULL);
GO

-- Insertion des Jeux

INSERT INTO [dbo].[Jeu] (Nom, Description, AgeMin, AgeMax, NbJoueurMin, NbJoueurMax, DureeMinute, DateCreation, EnregistreurId)
VALUES 
    ('Catan', 'Jeu de commerce et de construction', 10, 99, 3, 4, 90, GETDATE(), 1),
    ('Pandemic', 'Jeu coopératif sur la lutte contre les maladies', 8, 99, 2, 4, 60, GETDATE(), 2),
    ('Risk', 'Jeu de stratégie et conquête', 12, 99, 2, 6, 120, GETDATE(), 1);
GO

-- Insertion dans Posseder
INSERT INTO [dbo].[Posseder] (UtilisateurId, JeuId, Etat)
VALUES 
    (1, 1, 'Neuf'),
    (2, 2, 'Neuf'),
    (3, 3, 'Abimé');
GO

-- Insertion des Emprunts

INSERT INTO [dbo].[Emprunt] (PreteurId, EmprunteurId, JeuId, DateEmprunt, DateRetour, EvaluationPreteur, EvaluationEmprunteur)
VALUES 
    (1, 2, 1, GETDATE(), NULL, NULL, NULL),
    (2, 3, 2, GETDATE(), DATEADD(day, 7, GETDATE()), 5, 4);
GO

-- Insertion des Tags
INSERT INTO [dbo].[Tag] (NomTag)
VALUES 
	('Coopératif'),
	('Equipe'),
	('Dés'),
	('Cartes'),
	('Plateau'),
	('Argent');
GO

-- Insertion dans JeuTag
INSERT INTO [dbo].[JeuTag] (JeuId, TagId)
VALUES 
    (1, 1), -- Catan : Coopératif
    (1, 4), -- Catan : Cartes (exemple)
    (2, 1), -- Pandemic : Coopératif
    (2, 2), -- Pandemic : Equipe
    (3, 3); -- Risk : Dés (exemple)
GO
