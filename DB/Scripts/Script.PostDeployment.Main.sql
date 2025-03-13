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
    ('Risk', 'Jeu de stratégie et conquête', 12, 99, 2, 6, 120, GETDATE(), 1),
    ('Ticket to Ride', 'Jeu de stratégie ferroviaire', 8, 99, 2, 5, 80, GETDATE(), 3),
    ('Carcassonne', 'Jeu de pose de tuiles médiéval', 7, 99, 2, 5, 45, GETDATE(), 3),
    ('Azul', 'Jeu de stratégie et d''esthétique', 8, 99, 2, 4, 30, GETDATE(), 1),
    ('Splendor', 'Jeu de gestion de ressources et de commerce', 10, 99, 2, 4, 40, GETDATE(), 2),
    ('7 Wonders', 'Jeu de civilisation et de stratégie', 10, 99, 2, 7, 60, GETDATE(), 3),
    ('Dixit', 'Jeu d''imagination et de narration', 8, 99, 3, 6, 30, GETDATE(), 1),
    ('Dominion', 'Jeu de construction de deck', 10, 99, 2, 4, 45, GETDATE(), 2),
    ('Agricola', 'Jeu de gestion agricole', 12, 99, 1, 5, 120, GETDATE(), 3),
    ('Puerto Rico', 'Jeu de stratégie économique', 12, 99, 2, 5, 90, GETDATE(), 1);
GO

-- Insertion dans Posseder
INSERT INTO [dbo].[Posseder] (UtilisateurId, JeuId, Etat)
VALUES 
    (1, 1, 'Neuf'),
    (2, 2, 'Neuf'),
    (3, 3, 'Abimé'),
	(1, 4, 'Neuf'),
	(2, 5, 'Abimé'),
	(3, 6, 'Neuf'),
	(1, 7, 'Abimé'),
	(2, 8, 'Abimé'),
	(3, 9, 'Neuf'),
	(1, 10, 'Abimé'),
	(2, 11, 'Neuf'),
	(3, 12, 'Neuf');
GO

-- Insertion des Emprunts
INSERT INTO [dbo].[Emprunt] (PreteurId, EmprunteurId, JeuId, DateEmprunt, DateRetour, EvaluationPreteur, EvaluationEmprunteur)
VALUES 
	(1, 2, 1, GETDATE(), NULL, NULL, NULL),               
    (2, 3, 2, GETDATE(), DATEADD(day,7,GETDATE()), 5, 4),  
    (3, 1, 3, GETDATE(), NULL, NULL, NULL),                  
    (1, 2, 4, GETDATE(), DATEADD(day,7,GETDATE()), 6, 5),  
    (2, 3, 5, GETDATE(), NULL, NULL, NULL),                  
    (3, 1, 6, GETDATE(), DATEADD(day,7,GETDATE()), 7, 6),  
    (1, 2, 7, GETDATE(), NULL, NULL, NULL),                  
    (2, 3, 8, GETDATE(), DATEADD(day,7,GETDATE()), 8, 7),  
    (3, 1, 9, GETDATE(), NULL, NULL, NULL),                  
    (1, 2, 10, GETDATE(), DATEADD(day,7,GETDATE()), 9, 8), 
    (2, 3, 11, GETDATE(), NULL, NULL, NULL),                 
    (3, 1, 12, GETDATE(), DATEADD(day,7,GETDATE()), 10, 9);

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
  (1, 1),
  (2, 2),
  (3, 3),
  (4, 4),
  (5, 5),
  (6, 6),
  (7, 1),
  (8, 2),
  (9, 3),
  (10, 4),
  (11, 5),
  (12, 6);
GO
