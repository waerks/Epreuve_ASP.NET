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
	public class JeuService
	{
		private const string ConnectionString = @"Data Source=(localDB)\MSSQLlocalDB;Initial Catalog=Epreuve-DB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";

		// Obtenir tous les Jeux
		public IEnumerable<Jeu> Get()
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_Jeu_GetAll";
					command.CommandType = CommandType.StoredProcedure;
					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							Jeu result = new Jeu()
							{
								JeuId = (int)reader[nameof(Jeu.JeuId)],
								Nom = reader[nameof(Jeu.Nom)].ToString(),
								Description = reader[nameof(Jeu.Description)].ToString(),
								AgeMin = (int)reader[nameof(Jeu.AgeMin)],
								AgeMax = (int)reader[nameof(Jeu.AgeMax)],
								NbJoueurMin = (int)reader[nameof(Jeu.NbJoueurMin)],
								NbJoueurMax = (int)reader[nameof(Jeu.NbJoueurMax)],
								DureeMinute = reader[nameof(Jeu.DureeMinute)] is DBNull ? (int?)null : (int)reader[nameof(Jeu.DureeMinute)],
								DateCreation = (DateTime)reader[nameof(Jeu.DateCreation)],
								EnregistreurId = (int)reader[nameof(Jeu.EnregistreurId)]
							};
							yield return result;
						}
					}
				}
			}
		}
	}
}
