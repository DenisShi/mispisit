using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MISP.Rerository
{
    public class DbInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            Product p1 = new Product
            {
                Id = 1,
                Description = "Шаурма инициализации DB",
                ImagePath = $"~/App_Data/Images/temp.jpeg",
                Name = "Тестовая шаурма",
                Price = 150f
            };
            context.Products.Add(p1);

            FoodCategory fc1 = new FoodCategory()
            {
                Id = 1,
                ImagePath = $"~/App_Data/Images/temp.jpeg",
                Name = "Шаурма",
                Products = new List<Product>() { p1 }
            };
            context.FoodCategories.Add(fc1);
            base.Seed(context);
        }
    }
}