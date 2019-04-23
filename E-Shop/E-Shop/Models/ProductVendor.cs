using System.Collections.Generic;

namespace E_Shop.Models
{
    public class ProductVendor
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public ProductVendor()
        {
            Products = new List<Product>();
        }
    }
}
