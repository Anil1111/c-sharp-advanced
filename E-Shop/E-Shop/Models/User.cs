using System.Collections.Generic;

namespace E_Shop.Models
{
    public class User
    {
        public string Name { get; set; }
        public List<Product> Orders { get; set; }

    }
}
