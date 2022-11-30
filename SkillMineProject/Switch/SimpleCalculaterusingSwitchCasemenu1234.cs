using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Switch
{
    //write code simple calculater  using switch case create menu 1,2,3,4
    class SimpleCalculaterusingSwitchCasemenu1234
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char ope;
            Console.WriteLine("Enter the num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Operator ");
            ope = Convert.ToChar(Console.ReadLine());
            //menu
            Console.WriteLine("(1)Addition");
            Console.WriteLine("(2)Substraction");
            Console.WriteLine("(3)Multiplication");
            Console.WriteLine("(4)Division");

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
