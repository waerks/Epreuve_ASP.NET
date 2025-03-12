using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
	internal static class Mapper
	{
		public static Utilisateur ToUtilisateur(this IDataRecord record)
		{
			if (record is null) throw new ArgumentNullException(nameof(record));
			return new Utilisateur()
			{
				UtilisateurId = (Guid)record[nameof(Utilisateur.UtilisateurId)],
				Email = record[nameof(Utilisateur.Email)].ToString(),
				MotDePasse = record[nameof(Utilisateur.MotDePasse)].ToString(),
				Pseudo = record[nameof(Utilisateur.Pseudo)].ToString(),
				DateCreation = (DateTime)record[nameof(Utilisateur.DateCreation)],
				DateDesactivation = record[nameof(Utilisateur.DateDesactivation)] is DBNull ? (DateTime?)null : (DateTime)record[nameof(Utilisateur.DateDesactivation)]
			};
		}

		public static Jeu ToJeu(this IDataRecord record)
		{
			if (record is null) throw new ArgumentNullException(nameof(record));
			return new Jeu()
			{
				JeuId = (int)record[nameof(Jeu.JeuId)],
				Nom = record[nameof(Jeu.Nom)].ToString(),
				Description = record[nameof(Jeu.Description)].ToString(),
				AgeMin = (int)record[nameof(Jeu.AgeMin)],
				AgeMax = (int)record[nameof(Jeu.AgeMax)],
				NbJoueurMin = (int)record[nameof(Jeu.NbJoueurMin)],
				NbJoueurMax = (int)record[nameof(Jeu.NbJoueurMax)],
				DureeMinute = record[nameof(Jeu.DureeMinute)] is DBNull ? (int?)null : (int)record[nameof(Jeu.DureeMinute)],
				DateCreation = (DateTime)record[nameof(Jeu.DateCreation)],
				EnregistreurId = (int)record[nameof(Jeu.EnregistreurId)]
			};
		}

		public static Posseder ToPosseder(this IDataRecord record)
		{
			if (record is null) throw new ArgumentNullException(nameof(record));
			return new Posseder()
			{
				UtilisateurId = (int)record[nameof(Posseder.UtilisateurId)],
				JeuId = (int)record[nameof(Posseder.JeuId)],
				Etat = record[nameof(Posseder.Etat)].ToString()
			};
		}

		public static Emprunt ToEmprunt(this IDataRecord record)
		{
			if (record is null) throw new ArgumentNullException(nameof(record));
			return new Emprunt()
			{
				EmpruntId = (Guid)record[nameof(Emprunt.EmpruntId)],
				PreteurId = (int)record[nameof(Emprunt.PreteurId)],
				EmprunteurId = (int)record[nameof(Emprunt.EmprunteurId)],
				JeuId = (int)record[nameof(Emprunt.JeuId)],
				DateEmprunt = (DateTime)record[nameof(Emprunt.DateEmprunt)],
				DateRetour = record[nameof(Emprunt.DateRetour)] is DBNull ? (DateTime?)null : (DateTime)record[nameof(Emprunt.DateRetour)],
				EvaluationPreteur = record[nameof(Emprunt.EvaluationPreteur)] is DBNull ? (int?)null : (int)record[nameof(Emprunt.EvaluationPreteur)],
				EvaluationEmprunteur = record[nameof(Emprunt.EvaluationEmprunteur)] is DBNull ? (int?)null : (int)record[nameof(Emprunt.EvaluationEmprunteur)]
			};
		}

		public static Tag ToTag(this IDataRecord record)
		{
			if (record is null) throw new ArgumentNullException(nameof(record));
			return new Tag()
			{
				TagId = (int)record[nameof(Tag.TagId)],
				NomTag = record[nameof(Tag.NomTag)].ToString()
			};
		}

		public static JeuTag ToJeuTag(this IDataRecord record)
		{
			if (record is null) throw new ArgumentNullException(nameof(record));
			return new JeuTag()
			{
				JeuId = (int)record[nameof(JeuTag.JeuId)],
				TagId = (int)record[nameof(JeuTag.TagId)]
			};
		}
	}
}
