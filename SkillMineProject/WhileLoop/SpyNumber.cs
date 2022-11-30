using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.WhileLoop
{
    class SpyNumber
    {
        static void Main(string[]args)
        {
            int num,multi=1;
            int sum = 0;
            Console.WriteLine("Enter The Number");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                multi = multi * digit;
                num =num/10;
               
            }
            if (sum == multi)
            {
                Console.WriteLine("The No Is Spy:=" );
            }
            else
            {
                Console.WriteLine("The No Is NOt Spy:=" );
            }

        }
    }
}
