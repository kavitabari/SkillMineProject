using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Switch
{
    class SwitchCharTypeAddition
    {
        static void Main(string[] args)
        {
            int num1, num2 ;
            char ope;
            Console.WriteLine("Enter the num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Operator ");
            ope = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("(+)Addition");
            Console.WriteLine("(-)Substraction");
            Console.WriteLine("(*)Multiplication");
            Console.WriteLine("(/)Division");
           

            Console.WriteLine("Enter The Operator (Sign)for Operaton");
            ope = Convert.ToChar(Console.ReadLine());

            switch (ope)
            {
                case '+':
                    Console.WriteLine("Add=:" + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Substraction=:" + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication:=" + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Division:=" + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid!!");
                    break;
            }
        }
    }
}
