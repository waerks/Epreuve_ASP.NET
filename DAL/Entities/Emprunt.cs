﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Emprunt
	{
		public Guid EmpruntId { get; set; }
		public int PreteurId { get; set; }
		public int EmprunteurId { get; set; }
		public int JeuId { get; set; }
		public DateTime DateEmprunt { get; set; }
		public DateTime? DateRetour { get; set; }
		public int? EvaluationPreteur { get; set; }
		public int? EvaluationEmprunteur { get; set; }

		public virtual Utilisateur Preteur { get; set; }
		public virtual Utilisateur Emprunteur { get; set; }
		public virtual Jeu Jeu { get; set; }
	}
}
