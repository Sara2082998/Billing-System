using System;
using System.Data.Entity;
using System.Linq;

namespace billsystem.Model
{
    public class BillDBContext : DbContext
    {
        // Your context has been configured to use a 'BillDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'billsystem.Model.BillDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BillDBContext' 
        // connection string in the application configuration file.
        public BillDBContext()
            : base("name=BillDBContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Bill_Item> Bill_Items { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}