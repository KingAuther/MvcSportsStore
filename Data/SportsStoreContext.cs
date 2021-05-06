using Microsoft.EntityFrameworkCore;
using MvcSportsStore.Models;

namespace MvcSportsStore.Data
{
    public class SportsStoreContext : DbContext
    {
        public SportsStoreContext(DbContextOptions<SportsStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}
