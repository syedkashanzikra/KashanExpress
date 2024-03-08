using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KashanExpress.ContextFiles;
using KashanExpress.DataAccessLayer.Infrastructure.IReposatory;
using KashanExpress.Models;

namespace KashanExpress.DataAccessLayer.Infrastructure.Reposatory
{
	public class UnitofWork : IUnitofWork
	{
		private readonly EcommerceDataContext _context;
		public ICategory Category { get; private set; }

		public UnitofWork(EcommerceDataContext context, ICategory category)
		{
			_context = context;
			Category = category; // Make sure this line correctly assigns the injected category repository
		}

		public void Save()
		{
			_context.SaveChanges();
		}
	}

}
