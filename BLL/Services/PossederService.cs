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
	public class PossederService
	{
		private D.PossederService _service;

		public PossederService()
		{
			_service = new D.PossederService();
		}

		// Obtenir tous les Posseder
		public IEnumerable<Entities.Posseder> Get()
		{
			return _service.Get().Select(DAL => DAL.ToBLL());
		}
	}
}
