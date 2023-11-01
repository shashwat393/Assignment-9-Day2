using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class Sports: Student
    {
        public String sports_name;
        public int score;
        public void Set()
        {
            base.Set();
            Console.WriteLine("Enter Sports Name: ");
             sports_name= Console.ReadLine();
            Console.WriteLine("Enter Score : ");
            score = Byte.Parse(Console.ReadLine());
        }
        public void Get()
        {
            base.Get();
            Console.WriteLine("Sports Name is : " + sports_name);
            Console.WriteLine("Sports Score is  : " + score);
        }
    }
}
