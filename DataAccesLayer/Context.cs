using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
   public class Context :DbContext
    {
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Employee> Employees { get; set; }
      
        public DbSet<StockOperation> StockOperations { get; set; }
        public DbSet<StockOperationDetail> StockOperationDetails { get; set; }

        public Context()
        {  
        }

        private static Context context; // ismi context yani classın kendisi olacak

        public static Context ContextVer()  // static newlemeden cagırabiliriz.
        {
            if (context == null)
            {
                context = new Context();
            }
            return context;
        }


    }
}
