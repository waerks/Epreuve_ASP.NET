using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class JeuTag
	{
		public int JeuId { get; set; }
		public int TagId { get; set; }

		public virtual Jeu Jeu { get; set; }
		public virtual Tag Tag { get; set; }
	}
}
