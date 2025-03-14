using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
	public interface IUtilisateurService<TUtilisateur>
	{
		IEnumerable<TUtilisateur> Get();
		TUtilisateur Get(int utilisateurId);
		int Insert(TUtilisateur utilisateur);
		void Update(int utilisateurId, TUtilisateur utilisateur);
		void Delete(int utilisateurId);
		int CheckPassword(string email, string motDePasse);
	}
}
