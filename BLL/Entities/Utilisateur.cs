using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
	public class Utilisateur
	{
		// Les variables privées
		private DateTime? _dateDesactivation;

		// Les propriétés publiques
		public int UtilisateurId { get; set; }
		public string Email { get; set; }
		public string MotDePasse { get; set; }
		public string Pseudo { get; set; }
		public DateTime DateCreation { get; set; }
		public bool EstDesactive 
		{
			get { return _dateDesactivation is not null; } 
		}
		public DateTime? DateDesactivation
		{
			get { return _dateDesactivation; }
		}

		// Le contrsucteur
		public Utilisateur(int utilisateurId, string email, string motDePasse, string pseudo, DateTime dateCreation, DateTime? dateDesactivation)
		{
			UtilisateurId = utilisateurId;
			Email = email;
			MotDePasse = motDePasse;
			Pseudo = pseudo;
			DateCreation = dateCreation;
			_dateDesactivation = dateDesactivation;
		}

		public Utilisateur(string email, string motDePasse, string pseudo)
		{
			Email = email;
			MotDePasse = motDePasse;
			Pseudo = pseudo;
			DateCreation = DateTime.Now;
			_dateDesactivation = null;
		}

		public Utilisateur(string email, string pseudo)
		{
			Email = email;
			Pseudo = pseudo;
		}
	}
}
