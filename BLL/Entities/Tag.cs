using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
	public class Tag
	{
		// Les propriétés publiques
		public int TagId { get; set; }
		public string NomTag { get; set; }

		// Le constructeur
		public Tag(int tagId, string nomTag)
		{
			TagId = tagId;
			NomTag = nomTag;
		}
	}
}
