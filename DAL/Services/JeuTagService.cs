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
	public class JeuTagService
	{
		private const string ConnectionString = @"Data Source=(localDB)\MSSQLlocalDB;Initial Catalog=Epreuve-DB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";

		// Obtenir tous les JeuTag
		public IEnumerable<JeuTag> Get()
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_JeuTag_GetAll";
					command.CommandType = CommandType.StoredProcedure;
					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							JeuTag result = new JeuTag()
							{
								JeuId = (int)reader[nameof(JeuTag.JeuId)],
								TagId = (int)reader[nameof(JeuTag.TagId)]
							};
							yield return result;
						}
					}
				}
			}
		}
	}
}
