using DAL.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
	public class UtilisateurService
	{
		private const string ConnectionString = @"Data Source=(localDB)\MSSQLlocalDB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";

		// Obtenir tous les Utilisateurs
		public IEnumerable<Utilisateur> Get()
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_Utilisateur_GetAllActive";
					command.CommandType = System.Data.CommandType.StoredProcedure;
					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							Utilisateur result = new Utilisateur()
							{
								UtilisateurId = (Guid)reader[nameof(Utilisateur.UtilisateurId)],
								Email = reader[nameof(Utilisateur.Email)].ToString(),
								MotDePasse = "********",
								Pseudo = reader[nameof(Utilisateur.Pseudo)].ToString(),
								DateCreation = (DateTime)reader[nameof(Utilisateur.DateCreation)],
								DateDesactivation = reader[nameof(Utilisateur.DateDesactivation)] is DBNull ? (DateTime?)null : (DateTime)reader[nameof(Utilisateur.DateDesactivation)]
							};
							yield return result;
						}
					}
				}
			}
		}
	}
}
