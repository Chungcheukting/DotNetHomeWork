using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq;


namespace OrderApp
{
    class OrderManagement : DbContext
    {
        public OrderManagement()
            : base("OrderManagement")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderManagement>());
        }

        public virtual DbSet<Order> Orders { get; set; }

    }
}
