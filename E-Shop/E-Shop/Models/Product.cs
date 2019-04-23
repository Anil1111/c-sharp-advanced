

using System;

namespace E_Shop.Models
{
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int? Quantity { get; set; }
        public int ProductCode { get; set; }

        public static float operator *(Product a, int q)
        {
            return a.Price * q;
        }

        public static float operator +(Product a, float total)
        {
            return a.Price + total;
        }

        public void Print()
        {
            Console.WriteLine($"Product name: {Name}\nPrice: {Price}\nProduct code: {ProductCode}\n===================");
        }
    }
}
