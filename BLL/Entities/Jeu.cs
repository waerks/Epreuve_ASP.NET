using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
	public class Jeu
	{
		// Les propriétés publiques
		public int JeuId { get; set; }
		public string Nom { get; set; }
		public string Description { get; set; }
		public int AgeMin { get; set; }
		public int AgeMax { get; set; }
		public int NbJoueurMin { get; set; }
		public int NbJoueurMax { get; set; }
		public int? DureeMinute { get; set; }
		public DateTime DateCreation { get; set; }
		public int EnregistreurId { get; set; }

		// Le constructeur
		public Jeu(int jeuId, string nom, string description, int ageMin, int ageMax, int nbJoueurMin, int nbJoueurMax, int? dureeMinute, DateTime dateCreation, int enregistreurId)
		{
			JeuId = jeuId;
			Nom = nom;
			Description = description;
			AgeMin = ageMin;
			AgeMax = ageMax;
			NbJoueurMin = nbJoueurMin;
			NbJoueurMax = nbJoueurMax;
			DureeMinute = dureeMinute;
			DateCreation = dateCreation;
			EnregistreurId = enregistreurId;
		}
	}
}
