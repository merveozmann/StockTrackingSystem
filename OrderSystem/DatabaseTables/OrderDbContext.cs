using System.Data.Entity;

namespace OrderStockSystem.DatabaseTables
{
   public class OrderDbContext:DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<SalesOrder> SalesOrder { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<User> User { get; set; }

        public OrderDbContext() : base("OrderDbConStr")
        {

        }

    }
}
