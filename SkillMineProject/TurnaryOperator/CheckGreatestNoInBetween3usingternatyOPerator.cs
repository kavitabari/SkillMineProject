using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.TurnaryOperator
{
    //check greast no  in between  3 number using ternary operator
    class CheckGreatestNoInBetween3usingternatyOPerator
    {
        static void Main(string[]args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter the num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num3");
            num3 = int.Parse(Console.ReadLine());
            int result = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
            Console.WriteLine("Is Greast No:=" + result);


        }
    }
}
