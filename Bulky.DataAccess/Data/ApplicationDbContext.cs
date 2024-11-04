using Bulky.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Category> Categories{get;set;}
        public DbSet<Product> Products{get;set;}
        public DbSet<ApplicationUser> ApplicationUsers{get;set;}
        public DbSet<Company> Companies{get;set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

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


            modelBuilder.Entity<Company>().HasData(
                new Company
                {Id=2,
                Name="بیدگل", 
                City="تهران",
                State="تهران",
                StreetAddress= "فرشته-خیابان مریم",
                PostalCode="110",
                PhoneNumber="021-66212141"
                },
                new Company
                {Id=3,
                Name="چشمه", 
                City="تهران",
                State="تهران",
                StreetAddress= "خیابان انقلاب-12فروردین-پلاک22",
                PostalCode="764",
                PhoneNumber="021-22343465"
                },
                new Company
                {Id=4,
                Name="مروارید", 
                City="تهران",
                State="تهران",
                StreetAddress= "خیابان سهروردی-بالاتر از مطهری",
                PostalCode="545",
                PhoneNumber="021-21621032"
                },
                new Company
                {Id=5,
                Name="گیلگمش", 
                City="تهران",
                State="تهران",
                StreetAddress= "خیابان انقلاب-روبروی دانشگاه",
                PostalCode="655",
                PhoneNumber="021-77317731"
                },
                new Company
                {Id=6,
                Name="نی", 
                City="تهران",
                State="تهران",
                StreetAddress= "خیابان کریم خان-روبروی ایرانشهر",
                PostalCode="412",
                PhoneNumber="021-22343421"
                },
                new Company
                {Id=7,
                Name="ارمغان", 
                City="رشت",
                State="رشت",
                StreetAddress= "ژاندارمری-خیابان اول",
                PostalCode="212",
                PhoneNumber="021-44766781"
                }
            );




            modelBuilder.Entity<Product>().HasData(
                new Product{
                    Id=1,
                    Title="محاکمه",
                    Description="ژوزف ک را به جرمی که نمیدادیم گرفته اند",
                    Author="فرانتس کافکا",
                    Publisher="مروارید",
                    ListPrice=30,
                    Price=40,
                    Price50=25,
                    Price100=20,
                    CategoryId = 1,
                    ImageUrl ="",
                },
                new Product{
                    Id=2,
                    Title="مسخ",
                    Description="گرگور زامزا از خواب بیدار می شود",
                    Author="فرانتس کافکا",
                    Publisher="مروارید",
                    ListPrice=25,
                    Price=35,
                    Price50=22,
                    Price100=19,
                    CategoryId = 1,
                    ImageUrl ="",

                },
                new Product{
                    Id=3,
                    Title="میزانسن و سبک فیلم",
                    Description="بررسی میزانسن از سینمای کلاسیک تا معاصر",
                    Author="آدرین مارتین",
                    Publisher="بیدگل",
                    ListPrice=90,
                    Price=100,
                    Price50=85,
                    Price100=75,
                    CategoryId = 6,
                    ImageUrl ="",

                },
                new Product{
                    Id=4,
                    Title="مراقبت و تنبیه",
                    Description="تولد زندان",
                    Author="میشل فوکو",
                    Publisher="نی",
                    ListPrice=88,
                    Price=100,
                    Price50=80,
                    Price100=73,
                    CategoryId = 4,
                    ImageUrl ="",

                },
                new Product{
                    Id=5,
                    Title="رویکردهایی به نظریه اجرا",
                    Description="مجموعه مقالات",
                    Author="علی اکبر علیزاد",
                    Publisher="بیدگل",
                    ListPrice=130,
                    Price=150,
                    Price50=120,
                    Price100=99,
                    CategoryId = 5,
                    ImageUrl ="",

                },
                new Product{
                    Id=6,
                    Title="در",
                    Description="درها و حرف ها",
                    Author="ماگدا سابو",
                    Publisher="بیدگل",
                    ListPrice=45,
                    Price=50,
                    Price50=39,
                    Price100=32,
                    CategoryId = 1,
                    ImageUrl ="",

                },
                new Product{
                    Id=7,
                    Title="کافکا در ساحل",
                    Description="رمان جریان ساز",
                    Author="هاروکی موراکامی",
                    Publisher="چشمه",
                    ListPrice=80,
                    Price=100,
                    Price50=75,
                    Price100=70,
                    CategoryId = 1,
                    ImageUrl ="",

                },
                new Product{
                    Id=8,
                    Title="نیروی خشونت گریز",
                    Description="تحولات اجتماعی",
                    Author="جودیت باتلر",
                    Publisher="نی",
                    ListPrice=59,
                    Price=70,
                    Price50=49,
                    Price100=45,
                    CategoryId = 4,
                    ImageUrl ="",

                },
                new Product{
                    Id=9,
                    Title="ریاضیات برای کودکان",
                    Description="اصول ابتدایی",
                    Author="ون دایکسترا",
                    Publisher="ارمغان",
                    ListPrice=40,
                    Price=45,
                    Price50=35,
                    Price100=30,
                    CategoryId = 10,
                    ImageUrl ="",

                },
                new Product{
                    Id=10,
                    Title="نقد عقل محض",
                    Description="اثر سترگ ایمانوئل کانت",
                    Author="ایمانوئل کانت",
                    Publisher="نی",
                    ListPrice=100,
                    Price=120,
                    Price50=110,
                    Price100=99,
                    CategoryId = 3,
                    ImageUrl ="",

                }
            );
        }
        
    }
}