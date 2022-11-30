using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Loops
{
    class Calculate
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter The  base");
            int basenumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The  exponent");
            int expo = int.Parse(Console.ReadLine());
            int power = 1;
            for (int i = 1; i <= expo; i++)
            {
                power = power * basenumber;
            }
            Console.WriteLine(power);
        }
    }
}
