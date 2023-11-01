using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerDemo
{
    internal class Product
    {
        readonly int pcode;
        String pname;
        int qty_in_stock;
        int discount_allowed;
        static String brand;
        public Product(int pcode ,String pname, int qty_in_stock, int discount_allowed)
        {
            this.pcode = pcode;
            this.pname = pname;
            this.qty_in_stock = qty_in_stock;
            this.discount_allowed = discount_allowed;
        }
        static Product()
        {
            Console.WriteLine("Enter Brand : ");
            brand = Convert.ToString(Console.ReadLine());
        }
        public Product()
        {
            
        }

    }
}
