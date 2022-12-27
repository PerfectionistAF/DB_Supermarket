using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBProject.Model;

namespace DBProject.Controller
{
    public class MainContext : DbContext
    {
        ////////////////////////////////////////////////////////
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Provide> Providers { get; set; }
        ////////////////////////////////////////////////////////
        public String DbPath { get; }
        public MainContext()
        {
            DbPath = System.IO.Path.Join(Environment.CurrentDirectory, "THEDATABASE.db");
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
