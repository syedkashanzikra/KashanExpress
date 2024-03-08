using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using KashanExpress.ContextFiles;
using KashanExpress.DataAccessLayer.Infrastructure.IReposatory;
using Microsoft.EntityFrameworkCore;

namespace KashanExpress.DataAccessLayer.Infrastructure.Reposatory
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly EcommerceDataContext _context;
		private readonly DbSet<T> _dbset;

		public Repository(EcommerceDataContext context)
		{
			_context = context;
			_dbset = context.Set<T>(); // Ensure this line is correctly implemented
		}

		public void Add(T entity)
		{
			_dbset.Add(entity);
		}

		public void Delete(T entity)
		{
			_dbset.Remove(entity);
		}

		public void DeleteRange(IEnumerable<T> entity)
		{

			_dbset.RemoveRange(entity);

		}

		public IEnumerable<T> GetAll()
		{
			return _dbset.ToList();
		}


		public T GetT(Expression<Func<T, bool>> predicate)
		{
	    return _dbset.Where(predicate).FirstOrDefault();
		}

		//public void Update(T entity)
		//{
		//	throw new NotImplementedException();
		//}
	//	public void Update(T entity)
		//{
	    //_dbset.Attach(entity);
//_context.Entry(entity).State = EntityState.Modified;
		//}
	}
}
