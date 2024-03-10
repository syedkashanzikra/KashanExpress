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
	public class ProductRepository : Repository<Product>, IProduct
		{
		private readonly EcommerceDataContext _context;

		public ProductRepository(EcommerceDataContext context) : base(context)
		{
			_context = context;
		}

		public void Update(Product product)
		{
			_context.Products.Update(product);
			_context.SaveChanges();
		}
	}


}
