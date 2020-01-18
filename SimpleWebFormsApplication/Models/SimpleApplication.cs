namespace SimpleWebFormsApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public class SimpleApplication : DbContext
    {
        // Your context has been configured to use a 'SimpleApplication' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SimpleWebFormsApplication.Models.SimpleApplication' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SimpleApplication' 
        // connection string in the application configuration file.
        public SimpleApplication()
            : base("name=SimpleApplication")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        // add index for column Name
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Index]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        // foreign key related to Category Table
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        // Add Table Time 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}