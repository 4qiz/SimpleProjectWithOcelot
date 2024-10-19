using Microsoft.EntityFrameworkCore;
using OrdersApi.Models;

namespace OrdersApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextoptions) : base(dbContextoptions)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            List<Order> orders = new List<Order>
            {
                new Order{ OrderId = 101 },
                new Order{ OrderId = 102 },
                new Order{ OrderId = 103 },
            };
            builder.Entity<Order>().HasData(orders);

            var orderItems = new List<OrderItem>()
            {
                new OrderItem { Id = 1, OrderId=101, ProductId = 1, ProductName = "Laptop", Price = 1200.99m, Quantity = 1 },
                new OrderItem { Id = 2, OrderId=101, ProductId = 2, ProductName = "Smartphone", Price = 199.99m, Quantity = 2 },
                new OrderItem { Id = 3, OrderId=102, ProductId = 3, ProductName = "Headphones", Price = 799.99m, Quantity = 1 },
                new OrderItem { Id = 4, OrderId=102, ProductId = 4, ProductName = "Smartwatch", Price = 249.99m, Quantity = 1 },
                new OrderItem { Id = 5, OrderId=103, ProductId = 5, ProductName = "Tablet", Price = 329.99m, Quantity = 3 },
                new OrderItem { Id = 6, OrderId=103, ProductId = 2, ProductName = "Smartphone", Price = 199.99m, Quantity = 1 }
            };
            builder.Entity<OrderItem>().HasData(orderItems);

            base.OnModelCreating(builder);
        }
    }
}