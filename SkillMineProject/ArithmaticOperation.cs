using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class ArithmaticOperation
    {
        static void Main(string[] args)
        {
            int num1=10;
            int num2 = 20;
            int result = num1 + num2;
            Console.WriteLine("Addition Is:=" + result);
            result = num1 + num2;
            Console.WriteLine("Substraction Is:=" + result);
            result = num1 - num2;
            Console.WriteLine("Multiplication Is:=" + result);
            result = num1 * num2;
            Console.WriteLine("Division Is:=" + result);
            result = num1 / num2;
        }
    }

    class ArithmaticOperation1
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Enter The Fisrt Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            int num2 = int.Parse(Console.ReadLine()); ;
            int Addition = num1 + num2;
            Console.WriteLine("Addition Is:=" + Addition);
            int Substraction = num1 - num2;
            Console.WriteLine("Substraction Is:=" + Substraction);
            int Multiplication = num1 * num2;
            Console.WriteLine("Multiplication Is:=" + Multiplication);
            int Division = num1 / num2;
            Console.WriteLine("Division Is:=" + Division);


        }

        }
    }
