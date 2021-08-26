using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportShop.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Каяк",
                        Description = "Одноместная лодка",
                        Category = "Водный спорт",
                        Price = 27500
                    },
                    new Product
                    {
                        Name = "Спасательный жилет",
                        Description = "Защитный и модный",
                        Category = "Водный спорт",
                        Price = 480.95m
                    },
                    new Product
                    {
                        Name = "Футбольный мяч",
                        Description = "Размер и вес одобренные FIFA",
                        Category = "Футбол",
                        Price = 190.50m
                    },
                    new Product
                    {
                        Name = "Угловые флажки",
                        Description = "Придайте своему игровому полю профессиональный вид",
                        Category = "Футбол",
                        Price = 340.95m
                    },
                    new Product
                    {
                        Name = "Настольный футбол",
                        Description = "Идеальный вариант, чтобы весело и интересно провести время с ребенком или с друзьями",
                        Category = "Футбол",
                        Price = 7950
                    },
                    new Product
                    {
                        Name = "GT Avalanche 2.0",
                        Description = "Идеальный вариант для любителей пересеченной местности",
                        Category = "Велосипеды",
                        Price = 47500
                    },
                    new Product
                    {
                        Name = "Насос",
                        Description = "Высокотехнологичный телескопический насос не занимающий много места в рюкзаке",
                        Category = "Велосипеды",
                        Price = 640.75m
                    },
                    new Product
                    {
                        Name = "Шины Schwalbe Hurricane",
                        Description = "Отличная полусликовая шина для ценителей немецкого качества",
                        Category = "Велосипеды",
                        Price = 2750.30m
                    },
                    new Product
                    {
                        Name = "Перчатки ProGloves-7000",
                        Description = "Профессиональные перчатки для фрирайда",
                        Category = "Велосипеды",
                        Price = 1200
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
