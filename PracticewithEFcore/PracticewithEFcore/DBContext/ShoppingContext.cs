using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PracticewithEFcore.model;

namespace PracticewithEFcore.DBContext
{
    public class ShoppingContext : DbContext 
    {
        private string _connectionString;

        public ShoppingContext()
        {
            _connectionString = "Server = DESKTOP-28DHLU6; Database = test; User Id = arafat; Password = 123; ";
        }
        public ShoppingContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(_connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Customer> Customers { get; set; }

    }
}
