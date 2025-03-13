-- SP_Utilisateur_GetAllActive
CREATE PROCEDURE SP_Utilisateur_GetAllActive
AS
BEGIN
    SELECT UtilisateurId, Email, MotDePasse, Pseudo, DateCreation, DateDesactivation
    FROM Utilisateur
    WHERE DateDesactivation IS NULL;
END;
GO

-- SP_Utilisateur_GetByID
CREATE PROCEDURE SP_Utilisateur_GetByID
    @UtilisateurId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT UtilisateurId, Email, MotDePasse, Pseudo, DateCreation, DateDesactivation
    FROM Utilisateur
    WHERE UtilisateurId = @UtilisateurId;
END;
GO

-- SP_Utilisateur_Insert
CREATE PROCEDURE SP_Utilisateur_Insert
    @Email VARCHAR(255),
    @MotDePasse VARCHAR(255),
    @Pseudo VARCHAR(255),
    @DateCreation DATETIME,
    @DateDesactivation DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Utilisateur (Email, MotDePasse, Pseudo, DateCreation, DateDesactivation)
    VALUES (@Email, @MotDePasse, @Pseudo, @DateCreation, @DateDesactivation);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS NewUtilisateurId;
END;
GO

-- SP_Utilisateur_Update
CREATE PROCEDURE SP_Utilisateur_Update
    @UtilisateurId INT,
    @Email VARCHAR(255),
    @MotDePasse VARCHAR(255),
    @Pseudo VARCHAR(255),
    @DateCreation DATETIME,
    @DateDesactivation DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Utilisateur
    SET Email = @Email,
        MotDePasse = @MotDePasse,
        Pseudo = @Pseudo,
        DateCreation = @DateCreation,
        DateDesactivation = @DateDesactivation
    WHERE UtilisateurId = @UtilisateurId;
END;
GO

-- SP_Utilisateur_Delete
CREATE PROCEDURE SP_Utilisateur_Delete
    @UtilisateurId INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Utilisateur
    WHERE UtilisateurId = @UtilisateurId;
END;
GO

-- SP_Utilisateur_CheckPassword
CREATE PROCEDURE SP_Utilisateur_CheckPassword
    @Email VARCHAR(255),
    @MotDePasse VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT UtilisateurId
    FROM Utilisateur
    WHERE Email = @Email AND MotDePasse = @MotDePasse;
END;
GO

-- SP_Jeu_GetAll
CREATE PROCEDURE SP_Jeu_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT JeuId, Nom, Description, AgeMin, AgeMax, NbJoueurMin, NbJoueurMax, DureeMinute, DateCreation, EnregistreurId
    FROM Jeu;
END;
GO

-- SP_Posseder_GetAll
CREATE PROCEDURE SP_Posseder_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT UtilisateurId, JeuId, Etat
    FROM Posseder;
END;
GO

-- SP_Emprunt_GetAll
CREATE PROCEDURE SP_Emprunt_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT EmpruntId, PreteurId, EmprunteurId, JeuId, DateEmprunt, DateRetour, EvaluationPreteur, EvaluationEmprunteur
    FROM Emprunt;
END;
GO

-- SP_Tag_GetAll
CREATE PROCEDURE SP_Tag_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TagId, NomTag
    FROM Tag;
END;
GO

-- SP_JeuTag_GetAll
CREATE PROCEDURE SP_JeuTag_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT JeuId, TagId
    FROM JeuTag;
END;
GO