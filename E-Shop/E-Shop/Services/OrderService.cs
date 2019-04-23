using E_Shop.Models;
using System;
using System.Collections.Generic;

namespace E_Shop.Services
{
    public static class OrderService
    {
       public static void PrintOrder(User user)
        {

            float total = 0;
            foreach (var item in user.Orders)
            {
                total = item + total;
            }
            Console.WriteLine($"Buyer: {user.Name}\n=============");
            ProductService.PrintProducts(user.Orders);
            Console.WriteLine($"===============\nTotal Price: {total}$");
        }
    }
}
