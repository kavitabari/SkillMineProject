using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class DivisibleBy5
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            //n = Convert.ToInt32(Console.ReadLine());
            num = int.Parse(Console.ReadLine());
            if (num % 5 == 0) 
            {
                Console.WriteLine("The no is  divisible By 5 ");
            }
            else 

            {
                Console.WriteLine("It is  not divisible 5");
            }

        }

    }
}
