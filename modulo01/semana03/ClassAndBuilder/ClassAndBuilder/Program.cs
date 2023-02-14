using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassAndBuilder;

namespace ClassAndBuilder
{
    public class Program1
    {
        static void Main(string[] args)
        {
            Product product = new Product("Notebook", 990.00f, 2);
            Product product1 = new Product();

            Console.WriteLine("Product name: {0}\nProduct price: $ {1}\nProduct quantity: {2}", product.name, product.price, product.quantity);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Product name: {0}\nProduct price: $ {1}\nProduct quantity: {2}", product1.name, product1.price, product1.quantity);
        }

    }
}

//Product product1 = new Product("Calculator", 5.75f, 199);
//Product product2 = new Product();


//Console.WriteLine("Product name: {0}\nProduct price: $ {1}\nProduct quantity: {2}", product1.name, product1.price, product1.quantity);
//Console.WriteLine("----------------------------------");
//Console.WriteLine("Product name: {0}\nProduct price: $ {1}\nProduct quantity: {2}", product2.name, product2.price, product2.quantity);

//Program1 product = new Program1("Notebook", 990.00f, 2);
//Program1 product3 = new Program1();


//Console.WriteLine("Product name: {0}\nProduct price: $ {1}\nProduct quantity: {2}", product.name, product.price, product.quantity);
//Console.WriteLine("----------------------------------");
//Console.WriteLine("Product name: {0}\nProduct price: $ {1}\nProduct quantity: {2}", product3.name, product3.price, product3.quantity);