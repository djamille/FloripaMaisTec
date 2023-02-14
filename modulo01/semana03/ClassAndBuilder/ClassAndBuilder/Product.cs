using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndBuilder
{
    public class Product
    {
        public string name;
        public float price;
        public int quantity;

        public Product(string name, float price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public Product()
        {
            name = "Unnamed";
            price = 0;
            quantity = 0;
        }
    }
}
