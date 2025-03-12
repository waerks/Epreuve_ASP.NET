using UI.Models.Utilisateur;
using BLL.Entities;

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
	}
}
