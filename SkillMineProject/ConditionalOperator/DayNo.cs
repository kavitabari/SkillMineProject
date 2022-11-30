using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class DayNo
    {
        //chekthe day no from user  and display dayname as per the input   
        static void Main (string[]args)
        {
            Console.WriteLine("Enter The No");
            int dayno = int.Parse(Console.ReadLine());
            if(dayno == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (dayno == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayno == 3)
            {
                Console.WriteLine("Wensday");
            }
            else if (dayno == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayno == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (dayno == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (dayno == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid Day");
            }


        }
    }
}
