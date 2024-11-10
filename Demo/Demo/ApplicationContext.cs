using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Demo
{
    class ApplicationContext : DbContext
    {

        public DbSet<Type_Partner> Type_Partners { get; set; }
        public DbSet<Type_Material> Type_Materials { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationContext () : base("DefaultConnection") { }
        
    }
}
