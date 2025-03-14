using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UI.Models.Utilisateur
{
	public class UtilisateurCreateForm
	{
		[ScaffoldColumn(false)]
		public int UtilisateurId { get; set; }

		[DisplayName("Email")]
		[Required(ErrorMessage = "L'email est obligatoire")]
		[EmailAddress(ErrorMessage = "L'email n'est pas valide")]
		[MinLength(5, ErrorMessage = "L'email doit contenir au moins 5 caractères")]
		public string Email { get; set; }

		[DisplayName("Pseudo")]
		[MinLength(3, ErrorMessage = "Le pseudo doit contenir au moins 3 caractères")]
		public string Pseudo { get; set; }

		[DisplayName("Mot de passe")]
		[Required(ErrorMessage = "Le mot de passe est obligatoire")]
		[MinLength(8, ErrorMessage = "Le mot de passe doit contenir au moins 8 caractères")]
		[MaxLength(20, ErrorMessage = "Le mot de passe doit contenir au maximum 20 caractères")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$", ErrorMessage = "Le mot de passe doit contenir au moins une minuscule, une majuscule, un chiffre et un caractère spécial")]
		[DataType(DataType.Password)]
		public string MotDePasse { get; set; }

		[DisplayName("Confirmation du mot de passe")]
		[Required(ErrorMessage = "La confirmation du mot de passe est obligatoire")]
		[Compare("MotDePasse", ErrorMessage = "Les mots de passe ne correspondent pas")]
		[DataType(DataType.Password)]
		public string ConfirmeMotDePasse { get; set; }

		[DisplayName("Date de création")]
		[DataType(DataType.Date)]
		public DateTime DateCreation { get; set; }

		[DisplayName("Est désactivé")]
		public bool DateDesactivation { get; set; }

		[DisplayName("En cochant cette case, vous acceptez les termes de conditions générales d'utilisation de notre plateforme.")]
		[Required(ErrorMessage = "Vous devez accepter les conditions générales d'utilisation")]
		public bool Consent { get; set; }
	}
}
