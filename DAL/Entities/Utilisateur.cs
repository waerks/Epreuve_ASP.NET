using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Utilisateur
	{
		public int UtilisateurId { get; set; }
		public string Email { get; set; }
		public string MotDePasse { get; set; }
		public string Pseudo { get; set; }
		public DateTime DateCreation { get; set; }
		public DateTime? DateDesactivation { get; set; }

		// Jeux créés/enregistrés par l'utilisateur (via EnregistreurId)
		public virtual ICollection<Jeu> JeuxEnregistres { get; set; }
		public virtual ICollection<Posseder> Possessions { get; set; }

		// Emprunts où l'utilisateur est le prêteur
		public virtual ICollection<Emprunt> EmpruntsPrete { get; set; }

		// Emprunts où l'utilisateur est l'emprunteur
		public virtual ICollection<Emprunt> EmpruntsEmpruntes { get; set; }

		public Utilisateur()
		{
			JeuxEnregistres = new HashSet<Jeu>();
			Possessions = new HashSet<Posseder>();
			EmpruntsPrete = new HashSet<Emprunt>();
			EmpruntsEmpruntes = new HashSet<Emprunt>();
		}
	}
}
