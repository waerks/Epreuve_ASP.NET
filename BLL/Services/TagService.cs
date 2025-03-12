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
	public class TagService
	{
		private D.TagService _service;

		public TagService()
		{
			_service = new D.TagService();
		}

		// Obtenir tous les Tags
		public IEnumerable<Entities.Tag> Get()
		{
			return _service.Get().Select(DAL => DAL.ToBLL());
		}
	}
}
