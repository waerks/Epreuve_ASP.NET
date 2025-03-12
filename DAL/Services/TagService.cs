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
	public class TagService
	{
		private const string ConnectionString = @"Data Source=(localDB)\MSSQLlocalDB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";

		// Obtenir tous les Tags
		public IEnumerable<Tag> Get()
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_Tag_GetAll";
					command.CommandType = CommandType.StoredProcedure;
					connection.Open();

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							Tag result = new Tag()
							{
								TagId = (int)reader[nameof(Tag.TagId)],
								NomTag = reader[nameof(Tag.NomTag)].ToString()
							};
							yield return result;
						}
					}
				}
			}
		}
	}
}
