using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KashanExpress.DataAccessLayer.Infrastructure.IReposatory;

using KashanExpress.Models;

namespace KashanExpress.DataAccessLayer.Infrastructure.IReposatory
{
    public interface ICategory : IRepository<Category>
        {
         void Update (Category category);   
      
         }
}
