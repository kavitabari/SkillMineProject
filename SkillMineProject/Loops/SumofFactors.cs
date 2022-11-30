using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Loops
{
    class SumofFactors
    {
        static void  Main (string[]args)
        {
            int sum=0;
            Console.WriteLine("Enter The  no");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)//(num % 2 == 0)
                {
                    sum = sum + i;
                }
                Console.WriteLine("Sum Of  Factors :=" + sum);
            }
        }
    }
}
