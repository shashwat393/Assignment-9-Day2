using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class Student
    {
        public int rn;
        public String name;
        public void  Set()
        {
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Roll no: ");
            rn = Byte.Parse(Console.ReadLine());
        }
        public void  Get()
        {
            Console.WriteLine("Name is : "+ name);
            Console.WriteLine("Roll No is  : "+rn );
        }
    }
}
