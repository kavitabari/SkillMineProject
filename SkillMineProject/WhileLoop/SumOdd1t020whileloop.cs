using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.WhileLoop
{
    class SumOdd1t020whileloop
    {
        //sumo


        static void Main(string[] args)
        {
            int sum = 0;// int i=1;
            int i = 1;

            while (i <= 20)
            {

                sum = sum + i;
                i++;


            }
            Console.WriteLine("Sum Of  Odd Number:=" + sum);
        }
    }

    class SumOdd1t020whileloop11
    {
        //sumo if condition
        static void Main(string[] args)
        {
            int sum = 0;// int i=1;
            int i = 0;

            while (i <= 20)
            {
                if (i %2!= 0)
               {
                    sum = sum + i;

                }
                i++;


            }
            Console.WriteLine("Sum Of  Odd Number:=" + sum);
        }
    }
    class SumOdd
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("sumof odd no using while loop");
            Console.WriteLine("Enter The no");
            a = int.Parse(Console.ReadLine());
            while (a % 2 != 0)
            {
                Console.WriteLine("odd no" + a);
                break;

            }
            Console.ReadLine();
        }
    }
    class SumOdd11
    {
        static void Main(string[] args)
        {
           int count=0;
            Console.WriteLine("sumof odd no using while loop");
           for(int i = 0; i <= 20; i++)
            {
                while (i % 2 != 0)
                {
                    count++; 
                    Console.WriteLine("odd no" + count);
                    i++;
                }

            }

            Console.WriteLine("sum of odd no count"+count);
            Console.ReadLine();
        }
    }
}
