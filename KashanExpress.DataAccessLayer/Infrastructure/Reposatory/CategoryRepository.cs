using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KashanExpress.ContextFiles;
using KashanExpress.DataAccessLayer.Infrastructure.IReposatory;
using KashanExpress.Models;
using Microsoft.EntityFrameworkCore;

namespace KashanExpress.DataAccessLayer.Infrastructure.Reposatory
{
	public class CategoryRepository : Repository<Category>, ICategory
	{
		private readonly EcommerceDataContext _context;

		public CategoryRepository(EcommerceDataContext context) : base(context)
		{
			_context = context;
		}

		public void Update(Category category)
		{
			_context.Categories.Update(category);
			_context.SaveChanges();
		}
	}


}
