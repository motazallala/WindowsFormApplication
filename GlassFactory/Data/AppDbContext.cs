using GlassFactory.Data.Model;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;

namespace GlassFactory.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Batteries.Init();
            optionsBuilder.UseSqlite("Data Source=D:\\Self Work\\Work\\Glass\\Glass\\glass12.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(col =>
            {
                col.HasKey(c => c.CustomerID);
            });
            modelBuilder.Entity<Employee>(col =>
            {
                col.HasKey(c => c.EmployeeId);
                col.HasOne(c => c.Role).WithMany(c => c.Employees).HasForeignKey(c => c.RoleId);
            });
            modelBuilder.Entity<Piece>(col =>
            {
                col.HasKey(c => c.PieceID);
                col.HasOne(c => c.Customer).WithMany(c => c.Pieces).HasForeignKey(c => c.CustomerID);
                col.HasOne(c => c.OrderItem).WithOne(c => c.Piece).HasForeignKey<Piece>(c => c.OrderItemId);
            });
            modelBuilder.Entity<Order>(col =>
            {
                col.HasKey(c => c.OrderID);
                col.HasOne(c => c.Customer).WithMany(c => c.Orders).HasForeignKey(c => c.CustomerID);
            });
            modelBuilder.Entity<OrderItem>(col =>
            {
                col.HasKey(c => c.OrderItemId);
                col.HasOne(c => c.Order).WithMany(c => c.OrderItems).HasForeignKey(c => c.OrderId);
                col.HasOne(c => c.Piece).WithOne(c => c.OrderItem).HasForeignKey<OrderItem>(c => c.PieceID);
            });
            modelBuilder.Entity<Role>(col =>
            {
                col.HasKey(c => c.RoleId);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}