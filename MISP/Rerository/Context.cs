using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MISP.Rerository
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection") { }

        public DbSet<Product> Products { set; get; }
        public DbSet<FoodCategory> FoodCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodCategory>().HasMany(c => c.Products)
                .WithMany(s => s.Categories)
                .Map(t => t.MapLeftKey("FoodCategoryId")
                .MapRightKey("ProductId")
                .ToTable("ProductsCategories"));
        }

    }
}