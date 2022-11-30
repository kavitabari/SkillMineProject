using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.WhileLoop
{
    class DigitSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The No");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while(num>0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num % 10;
            }
            Console.WriteLine("Sum Of Digit" + sum);
        }
    }
}
