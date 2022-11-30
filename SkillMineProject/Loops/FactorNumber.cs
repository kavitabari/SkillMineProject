using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Loops
{
    class FactorNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The no");
            int num = int.Parse(Console.ReadLine()); 
            Console.WriteLine(" The Factor Number Is:="  +num);
            for (int i = 1; i <= 1; i++)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
           

        }
      
    }
}
