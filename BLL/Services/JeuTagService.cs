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
	public class JeuTagService
	{
		private D.JeuTagService _service;

		public JeuTagService()
		{
			_service = new D.JeuTagService();
		}

		// Obtenir tous les JeuTags
		public IEnumerable<Entities.JeuTag> Get()
		{
			return _service.Get().Select(DAL => DAL.ToBLL());
		}
	}
}
