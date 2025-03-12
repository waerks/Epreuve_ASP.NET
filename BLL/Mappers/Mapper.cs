using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D = DAL.Entities;

namespace BLL.Mappers
{
	internal static class Mapper
	{
		// Utilisateur
		public static Utilisateur ToBLL(this D.Utilisateur utilisateur)
		{
			if (utilisateur is null) throw new ArgumentOutOfRangeException(nameof(utilisateur));

			return new Utilisateur(
				utilisateur.UtilisateurId, 
				utilisateur.Email, 
				utilisateur.MotDePasse, 
				utilisateur.Pseudo, 
				utilisateur.DateCreation,
				utilisateur.DateDesactivation
				);
		}

		public static D.Utilisateur ToDAL(this Utilisateur utilisateur)
		{
			if (utilisateur is null) throw new ArgumentOutOfRangeException(nameof(utilisateur));

			return new D.Utilisateur()
			{
				UtilisateurId = utilisateur.UtilisateurId,
				Email = utilisateur.Email,
				MotDePasse = utilisateur.MotDePasse,
				Pseudo = utilisateur.Pseudo,
				DateCreation = utilisateur.DateCreation,
				DateDesactivation = utilisateur.EstDesactive ? DateTime.Now : null
			};
		}

		// Jeu
		public static Jeu ToBLL(this D.Jeu jeu)
		{
			if (jeu is null) throw new ArgumentOutOfRangeException(nameof(jeu));
			return new Jeu(
				jeu.JeuId,
				jeu.Nom,
				jeu.Description,
				jeu.AgeMin,
				jeu.AgeMax,
				jeu.NbJoueurMin,
				jeu.NbJoueurMax,
				jeu.DureeMinute,
				jeu.DateCreation,
				jeu.EnregistreurId
				);
		}

		public static D.Jeu ToDAL(this Jeu jeu)
		{
			if (jeu is null) throw new ArgumentOutOfRangeException(nameof(jeu));
			return new D.Jeu()
			{
				JeuId = jeu.JeuId,
				Nom = jeu.Nom,
				Description = jeu.Description,
				AgeMin = jeu.AgeMin,
				AgeMax = jeu.AgeMax,
				NbJoueurMin = jeu.NbJoueurMin,
				NbJoueurMax = jeu.NbJoueurMax,
				DureeMinute = jeu.DureeMinute,
				DateCreation = jeu.DateCreation,
				EnregistreurId = jeu.EnregistreurId
			};
		}

		// Posseder
		public static Posseder ToBLL(this D.Posseder posseder)
		{
			if (posseder is null) throw new ArgumentOutOfRangeException(nameof(posseder));
			return new Posseder(
				posseder.UtilisateurId,
				posseder.JeuId,
				posseder.Etat
				);
		}

		public static D.Posseder ToDAL(this Posseder posseder)
		{
			if (posseder is null) throw new ArgumentOutOfRangeException(nameof(posseder));
			return new D.Posseder()
			{
				UtilisateurId = posseder.UtilisateurId,
				JeuId = posseder.JeuId,
				Etat = posseder.Etat
			};
		}

		// Emprunt
		public static Emprunt ToBLL(this D.Emprunt emprunt)
		{
			if (emprunt is null) throw new ArgumentOutOfRangeException(nameof(emprunt));
			return new Emprunt(
				emprunt.EmpruntId,
				emprunt.PreteurId,
				emprunt.EmprunteurId,
				emprunt.JeuId,
				emprunt.DateEmprunt,
				emprunt.DateRetour,
				emprunt.EvaluationPreteur,
				emprunt.EvaluationEmprunteur
				);
		}

		public static D.Emprunt ToDAL(this Emprunt emprunt)
		{
			if (emprunt is null) throw new ArgumentOutOfRangeException(nameof(emprunt));
			return new D.Emprunt()
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

		// Tag
		public static Tag ToBLL(this D.Tag tag)
		{
			if (tag is null) throw new ArgumentOutOfRangeException(nameof(tag));
			return new Tag(
				tag.TagId,
				tag.NomTag
				);
		}

		public static D.Tag ToDAL(this Tag tag)
		{
			if (tag is null) throw new ArgumentOutOfRangeException(nameof(tag));
			return new D.Tag()
			{
				TagId = tag.TagId,
				NomTag = tag.NomTag
			};
		}

		// JeuTag
		public static JeuTag ToBLL(this D.JeuTag jeuTag)
		{
			if (jeuTag is null) throw new ArgumentOutOfRangeException(nameof(jeuTag));
			return new JeuTag(
				jeuTag.JeuId,
				jeuTag.TagId
				);
		}

		public static D.JeuTag ToDAL(this JeuTag jeuTag)
		{
			if (jeuTag is null) throw new ArgumentOutOfRangeException(nameof(jeuTag));
			return new D.JeuTag()
			{
				JeuId = jeuTag.JeuId,
				TagId = jeuTag.TagId
			};
		}
	}
}
