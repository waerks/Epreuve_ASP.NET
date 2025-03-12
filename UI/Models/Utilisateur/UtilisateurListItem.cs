using System.ComponentModel.DataAnnotations;

namespace UI.Models.Utilisateur
{
	public class UtilisateurListItem
	{
		[ScaffoldColumn(false)]
		public Guid UtilisateurId { get; set; }

		[Display(Name = "Email")]
		public string Email { get; set; }

		[Display(Name = "Pseudo")]
		public string Pseudo { get; set; }

		[Display(Name = "Date de création")]
		public DateTime DateCreation { get; set; }
	}
}
