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
INSERT INTO Tag (Tag) VALUES ('Coopératif');
INSERT INTO Tag (Tag) VALUES ('Equipe');
INSERT INTO Tag (Tag) VALUES ('Dés');
INSERT INTO Tag (Tag) VALUES ('Cartes');
INSERT INTO Tag (Tag) VALUES ('Plateau');
INSERT INTO Tag (Tag) VALUES ('Argent');