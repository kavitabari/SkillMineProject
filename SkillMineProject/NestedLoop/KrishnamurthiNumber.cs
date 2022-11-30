using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoopDemo
{
    class KrishnamurthiNumber
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while(num>0)
            {
                int digit = num % 10;
                int fact = 1;
                for(int i=1;i<=digit;i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            // Console.WriteLine(sum);
            if (temp == sum)
            {
                Console.WriteLine("Num Is KrishnamurthiNumber");
            }
            else
            {
                Console.WriteLine("Numb Is  Not KrishnamurthiNumber");
            }
        }
    }
}
