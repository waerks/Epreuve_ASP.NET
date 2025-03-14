using BLL.Entities;
using BLL.Mappers;
using D = DAL.Entities;
using Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
	public class UtilisateurService : IUtilisateurService<Utilisateur>
	{
		private IUtilisateurService<D.Utilisateur> _service;

		public UtilisateurService(IUtilisateurService<D.Utilisateur> utilisateurService)
		{
			_service = utilisateurService;
		}

		public UtilisateurService() : this(new DAL.Services.UtilisateurService())
		{
		}

		// Obtenir tous les Utilisateurs
		public IEnumerable<Utilisateur> Get()
		{
			return _service.Get().Select(DAL => DAL.ToBLL());
		}

		// Obtenir tous les ID Utilisateurs
		public Utilisateur Get(int utilisateurId)
		{
			return _service.Get(utilisateurId).ToBLL();
		}

		// Insérer les Utilisateurs
		public int Insert(Utilisateur utilisateur)
		{
			if (utilisateur == null)
				throw new ArgumentNullException(nameof(utilisateur));
			return _service.Insert(utilisateur.ToDAL());
		}

		// Update les Utilisateurs
		public void Update(int utilisateurId, Utilisateur utilisateur)
		{
			_service.Update(utilisateurId, utilisateur.ToDAL());
		}

		// Delete les Utilisateurs
		public void Delete(int utilisateurId)
		{
			_service.Delete(utilisateurId);
		}

		// Check le MotDePasse des Utilisateurs
		public int CheckPassword(string email, string motDePasse)
		{
			return _service.CheckPassword(email, motDePasse);
		}
	}
}
