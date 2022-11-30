using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class SumOfFactorsNestedLoop
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter The No");
            int num = int.Parse(Console.ReadLine());
            int fact = 1, i = 1, j = 1;
            int sum = 0;
                while(i<=num)
            {
                j = 1;
                fact = 1;
                while(j<=i)
                {
                    fact = fact * j;
                    j++;
                }
                Console.WriteLine(fact);
                sum = sum + fact;
                i++;
            }
            Console.WriteLine("Sum Of Factorial:=" + sum);
        }

    }
}
