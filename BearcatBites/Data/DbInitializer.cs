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
                    Name = "Pho Tai",
                    Restaurant = "Pho Lang Thang",
                    Description = "Traditional Vietnamese beef noodle soup with rich, aromatic broth and fresh herbs.",
                    ImagePath = "/images/items/086a4fa3-b957-45c2-8c5f-7f2f19009c30.png",
                    Type = ItemType.Bite
                },
                new FoodItem
                {
                    Name = "Vietnamese Spring Rolls",
                    Restaurant = "Pho Kimmy",
                    Description = "Rice noodles with beef, shrimp, and spring vegetables wrapped in a rice paper. Served with nouc mam dipping sauce",
                    ImagePath = "/images/items/2bf3b1cc-4abf-4487-815a-0b1bcf2f0ce8.png",
                    Type = ItemType.Bite
                },
                new FoodItem
                {
                    Name = "Osmanthus Tea",
                    Restaurant = "Kung Fu Tea",
                    Description = "Fragrant Floral Tea, served hot.",
                    ImagePath = "/images/items/26e04506-aef8-42ba-a7ab-bd401a25b02c.png",
                    Type = ItemType.Sip
                },
                new FoodItem
                {
                    Name = "Panipuri",
                    Restaurant = "Masala Theory Indian Restaurant",
                    Description = "Hollow, crispy fried shell (puri) filled with a mixture of spiced potatoes, chickpeas, and onions, then submerged in tangy, flavored water (pani)",
                    ImagePath = "/images/items/542548a3-24c2-4716-a38c-e5d4217acbf3.png",
                    Type = ItemType.Bite
                }
            };

            context.FoodItems.AddRange(foodItems);
            context.SaveChanges();
        }
    }
}
