using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class Tag
	{
		public int TagId { get; set; }
		public string NomTag { get; set; }

		// Propriété de navigation pour la relation many-to-many avec Jeu
		public virtual ICollection<JeuTag> JeuTags { get; set; }

		public Tag()
		{
			JeuTags = new HashSet<JeuTag>();
		}
	}
}
