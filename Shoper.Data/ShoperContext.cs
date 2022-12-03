using Microsoft.EntityFrameworkCore;
using Shoper.Entities;

namespace Shoper.Data
{
    public class ShoperContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-N9J61E8\SQLEXPRESS;Database=ShoperDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //tablo ismi ve tabloya ait primary key verilir.
            modelBuilder.Entity<Category>().ToTable("Category").HasKey(c => c.CategoryId);
            modelBuilder.Entity<Product>().ToTable("Product").HasKey(c => c.ProductId);
            modelBuilder.Entity<ProductPrice>().ToTable("ProductPrice").HasKey(pp=>pp.PriceId);
            modelBuilder.Entity<ProductImage>().ToTable("PeoductImage").HasKey(pi => pi.ImageId);
                //Relations
                //category/product
                modelBuilder.Entity<Category>()
                .HasMany<Product>(c=>c.Products)
                .WithOne(p=>p.ProductCategory)
                .HasForeignKey(p=>p.CategoryId)
                .HasConstraintName("Fk_ProductToCategory")
                .OnDelete(DeleteBehavior.Cascade);

            //productPrice - Product
            modelBuilder.Entity<ProductPrice>()
                .HasOne<Product>(pp => pp.Product)
                .WithMany(p => p.ProductPrices)
                .HasForeignKey(pp => pp.ProductId)
                .HasConstraintName("Fk_ProductPriceToProduct");

            //Product-ProductImage
            modelBuilder.Entity<ProductImage>()
                .HasOne<Product>(pp => pp.Product)
                .WithMany(p => p.ProductImages)
                .HasForeignKey(pp => pp.ProductId)
                .HasConstraintName("Fk_ProductImageToProduct");
        }
    }
    
}