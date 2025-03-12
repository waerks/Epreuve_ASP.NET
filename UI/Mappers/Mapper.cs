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
	}
}
