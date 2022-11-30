using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class PositiveNegative
    {
        static void Main(string[] args) 
        {
            

                int num;
                Console.WriteLine("Enter the number");
            //n = Convert.ToInt32(Console.ReadLine());
            num = int.Parse(Console.ReadLine());
                if ((num > 0)) 
                {
                    Console.WriteLine("The no is positive");
                }
                else if (num < 0)

                {
                    Console.WriteLine("It is  neative");
                }
                else if (num == 0)
            {

                    Console.WriteLine("no i szero ");
                }

            
        }

    }
}
