using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UI.Models.Utilisateur
{
	public class UtilisateurEditForm
	{
		[DisplayName("Email")]
		[Required(ErrorMessage = "Email est obligatoire")]
		[EmailAddress(ErrorMessage = "Email n'est pas valide")]
		[MaxLength(100, ErrorMessage = "Email ne doit pas dépasser 100 caractères")]
		[MinLength(5, ErrorMessage = "Email doit contenir au moins 5 caractères")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[DisplayName("Psuedo")]
		[Required(ErrorMessage = "Psuedo est obligatoire")]
		[MaxLength(100, ErrorMessage = "Psuedo ne doit pas dépasser 100 caractères")]
		[MinLength(5, ErrorMessage = "Psuedo doit contenir au moins 5 caractères")]
		public string Pseudo { get; set; }
	}
}
