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
	public class JeuService
	{
		private D.JeuService _service;
		public JeuService()
		{
			_service = new DAL.Services.JeuService();
		}
		// Obtenir tous les Jeux
		public IEnumerable<Entities.Jeu> Get()
		{
			return _service.Get().Select(DAL => DAL.ToBLL());
		}
	}
}
