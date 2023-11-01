using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class Test : Sports    
    {
        List<int> subjects = new List<int>();
        public int test_total_score;
        public void Set()
        {
            base.Set();
            Console.WriteLine("Enter  number of subjects : ");
            int no_sub = Byte.Parse(Console.ReadLine());
            for (byte i = 0; i < no_sub; i++)
            {
                Console.WriteLine($"Enter marks of sub{i+1} : ");
                subjects.Add(Byte.Parse(Console.ReadLine()));
            }   
        }
        public void Get()
        {
            base.Get();
            test_total_score = GetTotalScore();
            Console.WriteLine("Subject Total Score  is : " + test_total_score); 
        }
        public int GetTotalScore()
        {
            return subjects.ToList().Sum();
        }



    }
}
