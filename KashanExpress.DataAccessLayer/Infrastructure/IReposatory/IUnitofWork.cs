using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KashanExpress.DataAccessLayer.Infrastructure.IReposatory
{
	public interface IUnitofWork
	{
		ICategory Category { get;   }
		IProduct Product { get; }
		void Save();

	}
}
