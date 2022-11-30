using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Switch
{
    class SwitchDemoadd
    {
        static void Main(string[] args)
        {
            int a, b;
            char ch;
            Console.WriteLine("Enter the num1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Operator");
            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("(+)Addition");
            Console.WriteLine("(-)Substraction");
            Console.WriteLine("(*)Multiplication");
            Console.WriteLine("(/)Division");
            Console.WriteLine("Enter The Operator (Sign)for Operaton");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '+':Console.WriteLine("Add=:" + (a + b));
                    break;
                case '-':
                    Console.WriteLine("Substraction=:" + (a - b));
                    break;
                case '*':
                    Console.WriteLine("Multiplication:=" + (a * b));
                    break;
                case '/':
                    Console.WriteLine("Division:=" + (a / b));
                    break;
                default:Console.WriteLine("Wrong Choice The Menu");
                    break;
            }
        }
    }
}
