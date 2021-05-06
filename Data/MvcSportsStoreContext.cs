using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcSportsStore.Models;

namespace MvcSportsStore.Data
{
    public class MvcSportsStoreContext : DbContext
    {
        public MvcSportsStoreContext (DbContextOptions<MvcSportsStoreContext> options)
            : base(options)
        {
        }

        public DbSet<MvcSportsStore.Models.Products> Products { get; set; }
    }
}
