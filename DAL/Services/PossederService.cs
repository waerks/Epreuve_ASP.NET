using DAL.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
	public class PossederService
	{
		private const string ConnectionString = @"Data Source=(localDB)\MSSQLlocalDB;Initial Catalog=Epreuve-DB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";

		// Obtenir tous les Posseder
		public IEnumerable<Posseder> Get()
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_Posseder_GetAll";
					command.CommandType = CommandType.StoredProcedure;
					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							Posseder result = new Posseder()
							{
								UtilisateurId = (int)reader[nameof(Posseder.UtilisateurId)],
								JeuId = (int)reader[nameof(Posseder.JeuId)],
								Etat = reader[nameof(Posseder.Etat)].ToString()
							};
							yield return result;
						}
					}
				}
			}
		}
	}
}
