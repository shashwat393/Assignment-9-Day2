using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class Result: Test
    {
        public void Display()
        {
            base.Get();
            Console.WriteLine($" totla score is {this.score+ this.test_total_score}:");
        }
        public void Set()
        {
            base.Set();
        }
       
    }
}
