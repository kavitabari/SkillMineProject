using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class DivisibleBy39
    {
        static void Main(string[]args)
        {
            int n;
            Console.WriteLine("Enter the number");
            //n = Convert.ToInt32(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            if ((n % 3==0)) /*|| (n % 9 == 0)*/
            {
                Console.WriteLine("The no is  divisible By 3 ");
            }
           else if(n % 9==0)
            
            {
                Console.WriteLine("It is  not divisible By  9");
            }
            else if (n % 2 == 0)
            {

                Console.WriteLine("It is  not divisible ");
            }

        }
        


    }
}
