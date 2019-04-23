using E_Shop.Models;
using System.Collections.Generic;
using System.Linq;

namespace E_Shop.Services
{
    public static class ProductService
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product{Name = "Monitor", Price = 110},
                new Product{Name = "Motherboard", Price = 110},
                new Product{Name = "CPU", Price = 50},
                new Product{Name = "GPU", Price = 150},
                new Product{Name = "RAM", Price = 40},
                new Product{Name = "Mouse", Price = 5},
                new Product{Name = "Keyboard", Price = 8},
                new Product{Name = "Monitor", Price = 105},
                new Product{Name = "Motherboard", Price = 160},
                new Product{Name = "CPU", Price = 72},
                new Product{Name = "GPU", Price = 124},
                new Product{Name = "RAM", Price = 55},
                new Product{Name = "Mouse", Price = 4},
                new Product{Name = "Keyboard", Price = 10},
                new Product{Name = "Monitor", Price = 190},
                new Product{Name = "Motherboard", Price = 290},
                new Product{Name = "CPU", Price = 94},
                new Product{Name = "GPU", Price = 269},
                new Product{Name = "RAM", Price = 75},
                new Product{Name = "Mouse", Price = 15},
                new Product{Name = "Keyboard", Price = 20},
                new Product{Name = "Monitor", Price = 290},
                new Product{Name = "Motherboard", Price = 140},
                new Product{Name = "CPU", Price = 54},
                new Product{Name = "GPU", Price = 174},
                new Product{Name = "RAM", Price = 50},
                new Product{Name = "Mouse", Price = 20},
                new Product{Name = "Keyboard", Price = 15},
                new Product{Name = "Monitor", Price = 160},
                new Product{Name = "Motherboard", Price = 142},
                new Product{Name = "CPU", Price = 82},
                new Product{Name = "GPU", Price = 452},
                new Product{Name = "RAM", Price = 35},
                new Product{Name = "Mouse", Price = 7},
                new Product{Name = "Keyboard", Price = 9}
            };

            for (int i = 0; i < products.Count; i++)
            {
                products[i].ProductCode = i + 1;
            }

            return products;
        }

        public static void PrintProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                product.Print();
            }
        }

        public static void PrintProducts(SortedDictionary<string, List<Product>> vendors, string input)
        {
            List<Product> products = vendors.ElementAt(int.Parse(input) - 1).Value.ToList();

            PrintProducts(products);
        }


    }
}
