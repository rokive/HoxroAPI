using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Repositorys.DBContext
{
    public class HoxroDbContext : DbContext
    {
        public HoxroDbContext(DbContextOptions<HoxroDbContext> options) :
           base(options)
        {

        }

        public HoxroDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../HoxroAPI"))
           .AddJsonFile("appsettings.json")
           .Build();
            var builder = new DbContextOptionsBuilder<HoxroDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("HoxroDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Shopping> Shoppings { get; set; }

        public DbSet<ShoppingItem> ShoppingItems { get; set; }

    }
}
