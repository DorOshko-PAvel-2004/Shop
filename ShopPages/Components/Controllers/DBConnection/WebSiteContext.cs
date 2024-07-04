using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShopModels.Models;
using ShopPages.Components.Models;

namespace ShopModels.Controllers.DBConnection
{
    public class WebSiteContext<T>:DbContext where T: class
    {
        public DbSet<T> DataArray { get; set; } = null!;
        public WebSiteContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(WebApplication.CreateBuilder().Configuration.GetConnectionString("dbConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T>().ToTable(typeof(T).Name); // Имя таблицы совпадает с именем типа

            modelBuilder.Entity<Role>()
                .HasMany(e => e.userDatas)
                .WithOne(e => e.Role)
                .HasForeignKey(e => e.RoleID);

            modelBuilder.Entity<ProductStatus>()
                .HasMany(e => e.Products)
                .WithOne(e => e.ProductStatus)
                .HasForeignKey(e => e.StatusID);

            modelBuilder.Entity<ProductType>()
                .HasMany(e => e.Products)
                .WithOne(e => e.ProductType)
                .HasForeignKey(e => e.TypeID);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.ProductTypes)
                .WithOne(e => e.ProductCategory)
                .HasForeignKey(e => e.CategoryID);
        }
    }
}
