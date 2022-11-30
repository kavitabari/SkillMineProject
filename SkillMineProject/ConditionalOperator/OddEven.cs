using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class OddEven
    {
       static void Main(string [] agrs)
        {
            int num;
            Console.WriteLine("Enter the number");
            //n = Convert.ToInt32(Console.ReadLine());
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The no is even");

            }
            else
            {
                Console.WriteLine("the no is  Odd");
            }
        }

    }
}
