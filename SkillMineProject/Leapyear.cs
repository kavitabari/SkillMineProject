using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class Leapyear
    {
        static void Main(string []args)
        { 
            Console.WriteLine("Enter  the Year");
            int y = int.Parse(Console.ReadLine());
            {
               if((y % 4 ==0 && y % 100==0) || ((y % 100 == 0 && y % 400 == 0)))
                {
                    Console.WriteLine("is leap year" + y);
                }
                else
                {
                    Console.WriteLine("is leap  not year" + y);
                }
            }
           
        }
    }
}
