using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.SqlServer;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryInfrastructure.Data.DbContexts
{
    public class KitchenStory_DbContext : DbContext
    {
        public KitchenStory_DbContext (DbContextOptions options):base(options)
        {


        }

        
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<City> cities { get; set; }
        public virtual DbSet<Country> countries { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderAddress> OrderAddresss { get; set; }
        public virtual DbSet<OrderContactDetail> OrderContactDetails { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> products { get; set; }
        public virtual DbSet<ProductSubCategory> productSubCategories { get; set; }
        public virtual DbSet<ProductCategory> productCategories { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string prodCat = File.ReadAllText("ProductCategory.json");
            try
            {
                List<ProductCategory> prodcatList = System.Text.Json.JsonSerializer.Deserialize<List<ProductCategory>>(prodCat);
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<ProductCategory>().ToTable("ProductCategory");
                modelBuilder.Entity<ProductSubCategory>().ToTable("ProductSubCategory");
                foreach (var item in prodcatList)
                {
                    modelBuilder.Entity<ProductCategory>().HasData(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File not found " + prodCat);
                throw new Exception("File not found " + prodCat);
            }

        }
    }
}
