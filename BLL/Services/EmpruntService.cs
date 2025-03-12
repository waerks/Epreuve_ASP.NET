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
	public class EmpruntService
	{
		private D.EmpruntService _service;
		public EmpruntService()
		{
			_service = new D.EmpruntService();
		}

		// Obtenir tous les Emprunts
		public IEnumerable<Emprunt> Get()
		{
			return _service.Get().Select(DAL => DAL.ToBLL());
		}
	}
}
