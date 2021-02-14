using Microsoft.EntityFrameworkCore;
using Skinet.Entities;

namespace Skinet.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options):base(options)
        { 
        } 

        public DbSet<Product> Products { get; set; }

    }
}
