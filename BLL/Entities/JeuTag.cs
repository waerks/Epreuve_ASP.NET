using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
	public class JeuTag
	{
		// Les propriétés publiques
		public int JeuId { get; set; }
		public int TagId { get; set; }

		// Le constructeur
		public JeuTag(int jeuId, int tagId)
		{
			JeuId = jeuId;
			TagId = tagId;
		}
	}
}
