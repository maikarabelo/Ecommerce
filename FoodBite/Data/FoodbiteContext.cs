using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FoodBite.Data.Entities;
using Microsoft.Extensions.Configuration;

namespace FoodBite.Data
{
    public class FoodbiteContext : DbContext
    {
        public FoodbiteContext(DbContextOptions<FoodbiteContext> options) : base(options)
        {

        }
        //private readonly IConfiguration _config;
        // public FoodbiteContext(IConfiguration config)
        // {
        //_config = config;
        //}
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderRequest> OrderRequests { get; set; }

        // protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        //{
        //base.OnConfiguring(optionsBuilder);
        //optionsBuilder.UseSqlServer(_config["ConnectionStrings:FoodBiteContextDb"]);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 1,
                ProductName = "Ribs & Wings + Chips",
                ProductPrice = 70,
                Image = "~/images/0fb3c319-ab08-4c09-a568-8aa089d9df89.jpeg"
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 2,
                ProductName = "Steak & Wors + Chips",
                ProductPrice = 70,
                Image = "~/images/43d5ecaa-7b70-44e0-9b0d-f1639b7d4aa9.jpeg"
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 3,
                ProductName = "Chicken Dust + Chips Mild or Spicy",
                ProductPrice = 100,
                Image = "~/images/images.jpeg"
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 4,
                ProductName = "Green Salad",
                ProductPrice = 70,
                Image = "~/images/54f194c0-1766-47a2-9d03-8b5682564918.jpeg"

            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {

                ProductId = 5,
                ProductName = "Fish + Chips Mild or Spicy",
                ProductPrice = 100,
                Image = "~/images/download.jpeg"
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 6,
                ProductName = "Chichen Dust, Small Pops & Fish Cakes + Chips Mild or Spicy",
                ProductPrice = 120,
                Image = "~/images/images (1).jpeg"
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 7,
                ProductName = "Green Salad, Fish  + Chips",
                ProductPrice = 100,
                Image = "~/images/929c81e9-e8ac-4e93-bfa4-7839ab9fc2c0.jpeg"
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 8,
                ProductName = "Family Mixed Meat platter",
                ProductPrice = 370,
                Image = "~/images/download (2).jpeg"
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 9,
                ProductName = "Family Meaty platter",
                ProductPrice = 450,
                Image = "~/images/images (5).jpeg"
            });

            /*
                        modelBuilder.Entity<Order>().HasData(new Order()
                        {
                            OrderId = 1,
                            OrderDate = DateTime.Today,
                            OrderNumber = "101",


                        });

                        modelBuilder.Entity<OrderItem>().HasData(new OrderItem()
                        {
                            OrderItemId = 1,
                            ProductId = ,
                            Quantity = "101",
                            UnitPrice=jj,
                            OrderId

                        });

                        modelBuilder.Entity<OrderRequest>().HasData(new OrderRequest()
                        {
                            OrderItemId = 1,
                            ProductId = ,
                            Quantity = "101",
                            UnitPrice = jj,
                            OrderId

                        });*/

        }
    }
}


