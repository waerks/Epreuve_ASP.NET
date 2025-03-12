using DAL.Entities;
using DAL.Mappers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
	public class UtilisateurService
	{
		private const string ConnectionString = @"Data Source=(localDB)\MSSQLlocalDB;Initial Catalog=Epreuve-DB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";

		// Obtenir tous les Utilisateurs
		public IEnumerable<Utilisateur> Get()
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_Utilisateur_GetAllActive";
					command.CommandType = CommandType.StoredProcedure;
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

		// Obtenir tous les ID Utilisateurs
		public Utilisateur Get(Guid UtilisateurId)
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_Utilisateur_GetByID";
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue(nameof(UtilisateurId), UtilisateurId);

					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							return reader.ToUtilisateur();
						} else
						{
							throw new ArgumentOutOfRangeException(nameof(UtilisateurId));
						}
					}
				}
			}
		}

		// Insérer les Utilisateurs
		public Guid Insert(Utilisateur utilisateur)
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_Utilisateur_Insert";
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue(nameof(Utilisateur.Email), utilisateur.Email);
					command.Parameters.AddWithValue(nameof(Utilisateur.MotDePasse), utilisateur.MotDePasse);
					command.Parameters.AddWithValue(nameof(Utilisateur.Pseudo), utilisateur.Pseudo);
					command.Parameters.AddWithValue(nameof(Utilisateur.DateCreation), utilisateur.DateCreation);
					command.Parameters.AddWithValue(nameof(Utilisateur.DateDesactivation), utilisateur.DateDesactivation);

					connection.Open();
					return (Guid)command.ExecuteScalar();
				}
			}
		}

		// Update les Utilisateurs
		public void Update(Guid UtilisateurId, Utilisateur utilisateur)
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_Utilisateur_Update";
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue(nameof(UtilisateurId), UtilisateurId);

					command.Parameters.AddWithValue(nameof(Utilisateur.Email), utilisateur.Email);
					command.Parameters.AddWithValue(nameof(Utilisateur.MotDePasse), utilisateur.MotDePasse);
					command.Parameters.AddWithValue(nameof(Utilisateur.Pseudo), utilisateur.Pseudo);
					command.Parameters.AddWithValue(nameof(Utilisateur.DateCreation), utilisateur.DateCreation);
					command.Parameters.AddWithValue(nameof(Utilisateur.DateDesactivation), utilisateur.DateDesactivation);

					connection.Open();
					command.ExecuteNonQuery();
				}
			}
		}

		// Delete les Utilisateurs
		public void Delete(Guid UtilisateurId)
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_Utilisateur_Delete";
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue(nameof(UtilisateurId), UtilisateurId);

					connection.Open();
					command.ExecuteNonQuery();
				}
			}
		}

		// Check le MotDePasse des Utilisateurs
		public Guid CheckPassword(string Email, string MotDePasse)
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_Utilisateur_CheckPassword";
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue(nameof(Email), Email);
					command.Parameters.AddWithValue(nameof(MotDePasse), MotDePasse);

					connection.Open();
					return (Guid)command.ExecuteScalar();
				}
			}
		}
	}
}
