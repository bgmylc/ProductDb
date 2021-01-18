using Microsoft.EntityFrameworkCore;
using ProductDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDb.Data
{
    public class ProductsDbCntxt : DbContext
    {
        public ProductsDbCntxt()
        {

        }

        public ProductsDbCntxt(DbContextOptions<ProductsDbCntxt> options) : base(options) 
        { 

        }

        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                        .HasMany(x => x.Products)
                        .WithOne(q => q.Category)
                        .HasForeignKey(w => w.CategoryID);

            base.OnModelCreating(modelBuilder);

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLOCALDB;Database=SegumStore;Integrated Security = yes");
            }
        
        
        }

    }
}
