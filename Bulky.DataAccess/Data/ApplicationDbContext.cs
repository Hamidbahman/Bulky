using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Category> Categories{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category{Id=1,Name="داستان", DisplayOrder=1},
                new Category{Id=2,Name="شعر", DisplayOrder=2},
                new Category{Id=3,Name="فلسفه", DisplayOrder=3},
                new Category{Id=4,Name="جامعه شناسی", DisplayOrder=4},
                new Category{Id=5,Name="تئاتر", DisplayOrder=5},
                new Category{Id=6,Name="سینما", DisplayOrder=6},
                new Category{Id=7,Name="هنر", DisplayOrder=7},
                new Category{Id=8,Name="عکاسی", DisplayOrder=8},
                new Category{Id=9,Name="معماری", DisplayOrder=9},
                new Category{Id=10,Name="جستار", DisplayOrder=10}
            );
        }
        
    }
}