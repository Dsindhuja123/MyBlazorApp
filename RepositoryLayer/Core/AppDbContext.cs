using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Core
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {


        }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            { 

                Id = 1,
                Name = "Books",
                Price = 500,
                Description = "Nice Book"

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {

                Id = 2,
                Name = "Papers",
                Price = 5000,
                Description = "Empty Papers"

            });
        }
    }
}
