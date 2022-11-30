using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.WhileLoop
{
    class SumOfOddDigit1to20
    {
        static void Main(string[] arge)
        {
            int sum = 0;
            int i = 1;
            while (i <= 20)
            {
               // i++;
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                    
                }
                i++;
                Console.WriteLine("Sum Of Odd Number Id:="+sum);
            }
        }
    }
}
