using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Jeu
	{
		public int JeuId { get; set; }
		public string Nom { get; set; }
		public string Description { get; set; }
		public int AgeMin { get; set; }
		public int AgeMax { get; set; }
		public int NbJoueurMin { get; set; }
		public int NbJoueurMax { get; set; }
		public int? DureeMinute { get; set; }
		public DateTime DateCreation { get; set; }

		// Référence à l'utilisateur qui a enregistré le jeu
		public int EnregistreurId { get; set; }

		public virtual Utilisateur Enregistreur { get; set; }
		public virtual ICollection<Posseder> Posseders { get; set; }
		public virtual ICollection<Emprunt> Emprunts { get; set; }
		public virtual ICollection<JeuTag> JeuTags { get; set; }

		public Jeu()
		{
			Posseders = new HashSet<Posseder>();
			Emprunts = new HashSet<Emprunt>();
			JeuTags = new HashSet<JeuTag>();
		}
	}
}
