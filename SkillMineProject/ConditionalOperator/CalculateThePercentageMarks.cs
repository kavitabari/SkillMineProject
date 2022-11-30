using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    //using nested If
    class CalculateThePercentageMarks
    {
        static void Main(string[]args)
        {
            double per;
            Console.WriteLine("Enter The 1st subject Mark");
            double eng = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The 2nd subject Mark");
            double phy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The 3rd subject Mark");
            double che = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The 4th subject Mark");
            double math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The 5th subject Mark");
            double bio = int.Parse(Console.ReadLine());
            per = (eng + phy + che + math + bio) * 100 / (500);
            Console.WriteLine("Percentage" + per);
            if (per >= 70)
            {
                Console.WriteLine("Distinction");
            }
            else if (per >= 60)
            {
                if (per <= 69)
                {
                    Console.WriteLine("First Class");
                }
                
            }
            else if (per >= 50)
            {
                if (per <= 59)
                {
                    Console.WriteLine("Second Class");
                }

            }
            else if (per >= 35)
            {
                if (per <= 49)
                {
                    Console.WriteLine("Pass");
                }

            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
