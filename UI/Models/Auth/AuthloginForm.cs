using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UI.Models.Auth
{
	public class AuthloginForm
	{
		[DisplayName("Email")]
		[Required(ErrorMessage = "Email est obligatoire")]
		[EmailAddress(ErrorMessage = "Email n'est pas valide")]
		[MaxLength(100, ErrorMessage = "Email ne doit pas dépasser 100 caractères")]
		[MinLength(5, ErrorMessage = "Email doit contenir au moins 5 caractères")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[DisplayName("Mot de passe")]
		[Required(ErrorMessage = "Mot de passe est obligatoire")]
		[MaxLength(100, ErrorMessage = "Mot de passe ne doit pas dépasser 100 caractères")]
		[MinLength(5, ErrorMessage = "Mot de passe doit contenir au moins 5 caractères")]
		[DataType(DataType.Password)]
		public string MotDePasse { get; set; }
	}
}
