using System;
using System.Data.Entity;
using System.Linq;

namespace Bill_system.DB
{
    public class Bill : DbContext
    {
        // Your context has been configured to use a 'Bill' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Bill_system.DB.Bill' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Bill' 
        // connection string in the application configuration file.
        public Bill()
            : base("name=Bill")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Type_p> Types { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}