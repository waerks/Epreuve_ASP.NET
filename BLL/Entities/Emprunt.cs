using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
	public class Emprunt
	{
		// Les propriétés publiques
		public int EmpruntId { get; set; }
		public int PreteurId { get; set; }
		public int EmprunteurId { get; set; }
		public int JeuId { get; set; }
		public DateTime DateEmprunt { get; set; }
		public DateTime? DateRetour { get; set; }
		public int? EvaluationPreteur { get; set; }
		public int? EvaluationEmprunteur { get; set; }

		// Le constructeur
		public Emprunt(int empruntId, int preteurId, int emprunteurId, int jeuId, DateTime dateEmprunt, DateTime? dateRetour, int? evaluationPreteur, int? evaluationEmprunteur)
		{
			EmpruntId = empruntId;
			PreteurId = preteurId;
			EmprunteurId = emprunteurId;
			JeuId = jeuId;
			DateEmprunt = dateEmprunt;
			DateRetour = dateRetour;
			EvaluationPreteur = evaluationPreteur;
			EvaluationEmprunteur = evaluationEmprunteur;
		}
	}
}
