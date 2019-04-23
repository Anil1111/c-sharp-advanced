using E_Shop.Models;
using E_Shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace E_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = ProductService.GetProducts();

            ProductVendor anhoch = new ProductVendor();
            anhoch.Name = "Anhoch";
            anhoch.Products = products.Take(12).ToList();

            ProductVendor setec = new ProductVendor
            {
                Name = "Setec",
                Products = products.Skip(23).ToList()
            };

            ProductVendor riverSoft = new ProductVendor
            {
                Name = "River Soft",
                Products = products.Skip(12).Reverse().Skip(12).ToList()
            };

            SortedDictionary<string, List<Product>> productVendors = new SortedDictionary<string, List<Product>>
            {
                {anhoch.Name, anhoch.Products },
                {setec.Name, setec.Products },
                {riverSoft.Name, riverSoft.Products },
            };
            string input;
            string inputOption;
            while (true)
            {
                Console.WriteLine("Hello dear guest.\nPlease enter your name:");
                User user = new User { Name = Console.ReadLine(), Orders = new List<Product>()};
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Welcome to our shop " + user.Name + "\nChoose a vendor to shop from:\n");

                    
                    while (true)
                    {
                        for (int i = 0; i < productVendors.Count; i++)
                        {
                            Console.WriteLine($"Press {i + 1}. for {productVendors.ElementAt(i).Key}");
                        }
                        input = Console.ReadLine();
                        if ((input == "1" || input == "2" || input == "3"))
                        {
                            Console.Clear();
                            ProductService.PrintProducts(productVendors, input);
                            if (user.Orders.Count == 0)
                            {
                                Console.WriteLine("If you want to add product to shopping cart enter it's product code...\n=================\nType \"exit\" to exit app or \"back\" to list the vendors");

                            }

                            inputOption = Console.ReadLine().ToLower();

                            while (true)
                            {
                                if (inputOption == "back" || inputOption == "exit")
                                {
                                    break;
                                }
                                if (int.TryParse(inputOption, out int a))
                                {
                                    var productToAdd = productVendors.ElementAtOrDefault(int.Parse(input) - 1).Value.FirstOrDefault(x => x.ProductCode == int.Parse(inputOption));
                                    if (productToAdd != null)
                                    {
                                        user.Orders.Add(productToAdd);
                                        Console.WriteLine(productToAdd.Name + " has been successfuly added to your shoping cart");
                                    }
                                }
                                
                                
                                Console.WriteLine("Type \"c\" to checkout\nType \"exit\" to exit app or \"back\" to list the vendors\nEnter product code to add another product...");
                                inputOption = Console.ReadLine().ToLower();
                                if (inputOption == "c")
                                {
                                    Console.Clear();
                                    OrderService.PrintOrder(user);
                                    Console.WriteLine("==============\nType product code to remove from cart");
                                }
                            }

                            if (inputOption == "exit" || inputOption == "back")
                            {
                                Console.Clear();
                                break;
                            }
                        }
                        Console.Clear();
                    }
                    if (inputOption == "exit")
                    {
                        Console.Clear();
                        Console.WriteLine($"Goodbye {user.Name}.\nHope to see you again.");
                        Thread.Sleep(3000);
                        break;
                    }

                }
                break;
                
            }

        }
    }
}
