using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
	public class Posseder
	{
		// Les propriétés publiques
		public int UtilisateurId { get; set; }
		public int JeuId { get; set; }
		public string Etat { get; set; }

		// Le constructeur
		public Posseder(int utilisateurId, int jeuId, string etat)
		{
			UtilisateurId = utilisateurId;
			JeuId = jeuId;
			Etat = etat;
		}
	}
}
