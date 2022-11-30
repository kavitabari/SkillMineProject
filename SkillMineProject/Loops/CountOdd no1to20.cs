using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Loops
{
    class CountOdd_no1to20
    {
        static void Main(string []args)
        {
            int count = 0;
            for(int i=1;i<=20;i++)
            {
                if (i % 2 != 0)  //if (i % 2 != 0)
                {
                    count++;
                }
                
            }
            Console.WriteLine("Number Of  Odd Number:=" +count);
        }
    }

    class CountOdd_no1to201
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 1)  //if (i % 2 != 0)
                {
                    count++;
                }

            }
            Console.WriteLine("Number Of  Odd Number:=" + count);
        }
    }
}
