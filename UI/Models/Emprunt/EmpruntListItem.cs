using System.ComponentModel.DataAnnotations;

namespace UI.Models.Emprunt
{
	public class EmpruntListItem
	{
		[ScaffoldColumn(false)]
		public int EmpruntId { get; set; }

		[Display(Name = "Prêteur")]
		public int PreteurId { get; set; }

		[Display(Name = "Emprunteur")]
		public int EmprunteurId { get; set; }

		[Display(Name = "Jeu")]
		public int JeuId { get; set; }

		[Display(Name = "Date d'emprunt")]
		[DataType(DataType.Date)]
		public System.DateTime DateEmprunt { get; set; }

		[Display(Name = "Date de retour")]
		[DataType(DataType.Date)]
		public System.DateTime? DateRetour { get; set; }

		[Display(Name = "Evaluation du prêteur")]
		public int? EvaluationPreteur { get; set; }

		[Display(Name = "Evaluation de l'emprunteur")]
		public int? EvaluationEmprunteur { get; set; }
	}
}
