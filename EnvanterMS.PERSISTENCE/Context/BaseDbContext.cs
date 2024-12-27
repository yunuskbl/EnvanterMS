using Microsoft.EntityFrameworkCore;
using EnvanterMS.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Persistence.Context
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(p =>
            {
                p.HasKey(c => c.MusteriID);
                p.Property(p => p.MusteriID).HasColumnName("ID");

            });
            modelBuilder.Entity<Order>(p =>
            {
                p.HasKey(c => c.OrderID);
                p.Property(p => p.OrderID).HasColumnName("ID");

            });
            modelBuilder.Entity<Product>(p =>
            {
                p.HasKey(c => c.ProductID);
                p.Property(p => p.ProductID).HasColumnName("ID");

            });
        }

    }


}

