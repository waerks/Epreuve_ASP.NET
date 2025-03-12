using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Posseder
	{
		public int UtilisateurId { get; set; }
		public int JeuId { get; set; }
		public string Etat { get; set; }

		public virtual Utilisateur Utilisateur { get; set; }
		public virtual Jeu Jeu { get; set; }
	}
}
