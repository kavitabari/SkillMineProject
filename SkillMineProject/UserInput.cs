using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class UserInput
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter The Value");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);

            int num1;
            Console.WriteLine("Enter The Value");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);

           
            Console.WriteLine("Enter The Value Percentage");
            float per  = float.Parse(Console.ReadLine());
            Console.WriteLine("per"+per);

           
            Console.WriteLine("Enter The Value Double");
            double var = double.Parse(Console.ReadLine());
            Console.WriteLine("double" + var);

            char ch;
            Console.WriteLine("Enter The Value Char");
            ch  = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(ch);
        }
    }
}
