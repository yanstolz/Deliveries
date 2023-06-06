using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Data.SQLite;
using Deliveries.Model;

namespace Deliveries.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext() : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = @"C:\work\Deliveries\DataBase\deliveries.db",
                ForeignKeys = true
            }.ConnectionString
        }, true)
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
        public DbSet<DeliverySuppliers> DeliverySuppliers { get; set; }

    }
}
