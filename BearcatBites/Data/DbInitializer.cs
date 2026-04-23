using BearcatBites.Models;

namespace BearcatBites.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BearcatBitesContext context)
        {
            context.Database.EnsureCreated();

            if (context.FoodItems.Any())
            {
                return;
            }

            var foodItems = new FoodItem[]
            {
                new FoodItem
                {
                    Name = "Pho",
                    Restaurant = "Pho Lang Thang",
                    Description = "Traditional Vietnamese beef noodle soup with rich, aromatic broth and fresh herbs.",
                    ImagePath = "/images/items/sample-pho.jpg",
                    Type = ItemType.Bite
                },
                new FoodItem
                {
                    Name = "Skyline Chili",
                    Restaurant = "Skyline Chili",
                    Description = "Cincinnati-style chili served over spaghetti, topped with cheese and onions.",
                    ImagePath = "/images/items/sample-skyline.jpg",
                    Type = ItemType.Bite
                },
                new FoodItem
                {
                    Name = "Boba Tea",
                    Restaurant = "Kung Fu Tea",
                    Description = "Sweet milk tea with chewy tapioca pearls, a refreshing bubble tea experience.",
                    ImagePath = "/images/items/sample-boba.jpg",
                    Type = ItemType.Sip
                },
                new FoodItem
                {
                    Name = "Craft Beer",
                    Restaurant = "Rhinegeist Brewery",
                    Description = "Local craft beer from one of Cincinnati's most popular breweries.",
                    ImagePath = "/images/items/sample-beer.jpg",
                    Type = ItemType.Sip
                }
            };

            context.FoodItems.AddRange(foodItems);
            context.SaveChanges();
        }
    }
}
