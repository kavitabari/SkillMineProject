using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class CalculateFiveSubjectMarks
    {
        static void Main(string[] args)
        {
            int phy, che, Math, Bio, Eng;
            Console.WriteLine("Enter The 1st subject Mark");
            phy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The 2nd subject Mark");
            che = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The 3rd subject Mark");
            Math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The 4th subject Mark");
            Bio = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The 5th subject Mark");
            Eng = int.Parse(Console.ReadLine());
            int  result = (phy + phy + che + Math + Bio) * 100 / (500);
            Console.WriteLine("result:=" + result);
            if (result >= 75)
            {
                Console.WriteLine("Distinction");
            }
            else if (result > 60 && result > 75)
            {
                Console.WriteLine("First Class");
            }

            else if (result > 50 && result > 65)
            {
                Console.WriteLine("Second Class");
            }
            else if (result > 35 && result > 50)
            {
                Console.WriteLine(" Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
