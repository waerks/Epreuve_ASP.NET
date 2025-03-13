using System.ComponentModel.DataAnnotations;

namespace UI.Models.Jeu
{
	public class JeuListItem
	{
		[ScaffoldColumn(false)]
		public int JeuId { get; set; }

		[Display(Name = "Nom")]
		public string JeuName { get; set; }

		[Display(Name = "Description")]
		public string Description { get; set; }

		[Display(Name = "Durée")]
		public int? DureeMinute { get; set; }

		[Display(Name = "Age minimum")]
		public int AgeMinimum { get; set; }

		[Display(Name = "Age maximum")]
		public int AgeMaximum { get; set; }

		[Display(Name = "Nombre de joueurs minimum")]
		public int NbJoueurMin { get; set; }

		[Display(Name = "Nombre de joueurs maximum")]
		public int NbJoueurMax { get; set; }

		[Display(Name = "Date de création")]
		[DataType(DataType.Date)]
		public DateTime DateCreation { get; set; }

		[Display(Name = "Enregistreur")]
		public int EnregistreurId { get; set; }
	}
}
