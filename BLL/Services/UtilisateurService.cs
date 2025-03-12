using BLL.Entities;
using BLL.Mappers;
using D = DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
	public class UtilisateurService
	{
		private D.UtilisateurService _service;

		public UtilisateurService()
		{
			_service = new D.UtilisateurService();
		}

		// Obtenir tous les Utilisateurs
		public IEnumerable<Utilisateur> Get()
		{
			return _service.Get().Select(DAL => DAL.ToBLL());
		}

		// Obtenir tous les ID Utilisateurs
		public Utilisateur Get(Guid utilisateurId)
		{
			return _service.Get(utilisateurId).ToBLL();
		}

		// Insérer les Utilisateurs
		public void Insert(Utilisateur utilisateur)
		{
			_service.Insert(utilisateur.ToDAL());
		}

		// Update les Utilisateurs
		public void Update(Guid utilisateurId, Utilisateur utilisateur)
		{
			_service.Update(utilisateurId, utilisateur.ToDAL());
		}

		// Delete les Utilisateurs
		public void Delete(Guid utilisateurId)
		{
			_service.Delete(utilisateurId);
		}

		// Check le MotDePasse des Utilisateurs
		public Guid CheckPassword(string email, string motDePasse)
		{
			return _service.CheckPassword(email, motDePasse);
		}
	}
}
