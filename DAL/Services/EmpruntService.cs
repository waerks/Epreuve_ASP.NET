using DAL.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
	public class EmpruntService
	{
		private const string ConnectionString = @"Data Source=(localDB)\MSSQLlocalDB;Initial Catalog=Epreuve-DB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";

		// Obtenir tous les Emprunts
		public IEnumerable<Emprunt> Get()
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_Emprunt_GetAllActive";
					command.CommandType = System.Data.CommandType.StoredProcedure;
					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							Emprunt result = new Emprunt()
							{
								EmpruntId = (Guid)reader[nameof(Emprunt.EmpruntId)],
								PreteurId = (int)reader[nameof(Emprunt.PreteurId)],
								EmprunteurId = (int)reader[nameof(Emprunt.EmprunteurId)],
								JeuId = (int)reader[nameof(Emprunt.JeuId)],
								DateEmprunt = (DateTime)reader[nameof(Emprunt.DateEmprunt)],
								DateRetour = reader[nameof(Emprunt.DateRetour)] is DBNull ? (DateTime?)null : (DateTime)reader[nameof(Emprunt.DateRetour)],
								EvaluationPreteur = reader[nameof(Emprunt.EvaluationPreteur)] is DBNull ? (int?)null : (int)reader[nameof(Emprunt.EvaluationPreteur)],
								EvaluationEmprunteur = reader[nameof(Emprunt.EvaluationEmprunteur)] is DBNull ? (int?)null : (int)reader[nameof(Emprunt.EvaluationEmprunteur)]
							};
							yield return result;
						}
					}
				}
			}
		}
	}
}
