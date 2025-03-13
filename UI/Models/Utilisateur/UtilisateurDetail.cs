using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UI.Models.Utilisateur
{
	public class UtilisateurDetail
	{
		[ScaffoldColumn(false)]
		public int UtilisateurId { get; set; }

		[DisplayName("Email")]
		public string Email { get; set; }

		[DisplayName("Pseudo")]
		public string Pseudo { get; set; }

		[DisplayName("Date de création")]
		[DataType(DataType.Date)]
		public DateTime DateCreation { get; set; }
	}
}
