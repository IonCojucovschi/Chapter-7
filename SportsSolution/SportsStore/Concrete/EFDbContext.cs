using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Entities;

namespace SportsStore.Concrete
{
    class EFDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
