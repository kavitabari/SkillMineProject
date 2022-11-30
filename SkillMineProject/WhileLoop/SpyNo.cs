using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.WhileLoop
{
    class SpyNo
    {
        static void Main(string[] args)
        {
            int a, sum = 0, digit = 1;
            Console.WriteLine("Enter The No");
            a = int.Parse(Console.ReadLine());
            while(a>0)
            {
                int num = a % 10;
                sum = sum + num;
                digit = digit + num;
                a = a / 10;
            }
            Console.WriteLine(sum);
            Console.WriteLine(digit);
            if (sum == digit)
            {
                Console.WriteLine("The No Is Spy");
            }
            else
            {
                Console.WriteLine("The No Is not Spy");
            }
        }
        
    }
}
