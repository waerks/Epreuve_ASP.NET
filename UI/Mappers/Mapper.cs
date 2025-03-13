﻿using BLL.Entities;

namespace UI.Mappers
{
	internal static class Mapper
	{
		// Lister tous les Utilisateurs
		public static UtilisateurListItem ToListItem(this Utilisateur utilisateur)
		{
			return new UtilisateurListItem
			{
				Email = utilisateur.Email,
				Pseudo = utilisateur.Pseudo,
				DateCreation = utilisateur.DateCreation
			};
		}

		// Détail d'un Utilisateur
		public static UtilisateurDetail ToDetail(this Utilisateur utilisateur)
		{
			if (utilisateur is null) throw new ArgumentOutOfRangeException(nameof(utilisateur));

			return new UtilisateurDetail
			{
				UtilisateurId = utilisateur.UtilisateurId,
				Email = utilisateur.Email,
				Pseudo = utilisateur.Pseudo,
				DateCreation = utilisateur.DateCreation
			};
		}

		// Lister tous les Emprunts
		public static EmpruntListItem ToListItem(this Emprunt emprunt)
		{
			return new EmpruntListItem
			{
				EmpruntId = emprunt.EmpruntId,
				PreteurId = emprunt.PreteurId,
				EmprunteurId = emprunt.EmprunteurId,
				JeuId = emprunt.JeuId,
				DateEmprunt = emprunt.DateEmprunt,
				DateRetour = emprunt.DateRetour,
				EvaluationPreteur = emprunt.EvaluationPreteur,
				EvaluationEmprunteur = emprunt.EvaluationEmprunteur
			};
		}

		// Lister tous les Jeux
		public static JeuListItem ToListItem(this Jeu jeu)
		{
			return new JeuListItem
			{
				JeuName = jeu.Nom,
				JeuId = jeu.JeuId,
				Description = jeu.Description,
				AgeMinimum = jeu.AgeMin,
				AgeMaximum = jeu.AgeMax,
				NbJoueurMin = jeu.NbJoueurMin,
				NbJoueurMax = jeu.NbJoueurMax,
				DureeMinute = jeu.DureeMinute,
				DateCreation = jeu.DateCreation,
				EnregistreurId = jeu.EnregistreurId
			};
		}

		// Détail d'un Jeu
		public static JeuDetail ToDetail(this Jeu jeu)
		{
			if (jeu is null) throw new ArgumentOutOfRangeException(nameof(jeu));
			return new JeuDetail
			{
				JeuId = jeu.JeuId,
				JeuName = jeu.Nom,
				Description = jeu.Description,
				AgeMinimum = jeu.AgeMin,
				AgeMaximum = jeu.AgeMax,
				NbJoueurMin = jeu.NbJoueurMin,
				NbJoueurMax = jeu.NbJoueurMax,
				DureeMinute = jeu.DureeMinute,
				DateCreation = jeu.DateCreation,
				EnregistreurId = jeu.EnregistreurId,
				EnregistreurName = jeu.Enregistreur != null ? jeu.Enregistreur.Pseudo : "Inconnu"
			};
		}
	}
}
