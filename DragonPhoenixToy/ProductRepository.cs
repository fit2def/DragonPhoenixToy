using System.Collections.Generic;

namespace DragonPhoenixToy
{
    public static class ProductRepository
    {
        public static List<Product> GetProducts() =>
            new List<Product>
            {
                new Product{ ID = "1", Description = "A product", Name = "a name", OnHand = 0, Price = 0, UnitSold = 0 },
                new Product{ ID = "2", Description = "A product", Name = "a name", OnHand = 0, Price = 0, UnitSold = 0 },
                new Product{ ID = "3", Description = "A product", Name = "a name", OnHand = 0, Price = 0, UnitSold = 0 },
            };
    }
}

