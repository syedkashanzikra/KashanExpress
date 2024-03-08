

using KashanExpress.Models;
using Microsoft.EntityFrameworkCore;

namespace KashanExpress.ContextFiles
{
    public class EcommerceDataContext : DbContext
    {
        public EcommerceDataContext(DbContextOptions<EcommerceDataContext> options) : base(options) {

            
        }
        
        
        public DbSet<Category> Categories { get; set; } 
    }
}
