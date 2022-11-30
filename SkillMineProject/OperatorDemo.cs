using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class OperatorDemo
    {
        static void Main(string[]args)
        {
            //Console.WriteLine(5 + 6 - 2 * 4 / 2);
            //<,>,<=,>=,== !=
            int a = 10;
            int b = 20;
            int c = 40;
            int d = 70;
            int e = 10;
            Console.WriteLine(d > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a == c);
            Console.WriteLine(d <= b);
            Console.WriteLine(a != b);
            Console.WriteLine(a == e);

            //logical && || !
            Console.WriteLine(d > b && b > d);
            Console.WriteLine(".........." + ((b > a) || (c > b)));

            // Assigment
            int x = 10;
            x += 2;//x= x + 2;
            Console.WriteLine(x);
            x -= 3;//x=x-2;
            Console.WriteLine(x);
            x *= 2;//x=x*2;
            Console.WriteLine(x);
            x %= 3;//x=x%2;
            Console.WriteLine(x);
            x /= 4;//x=x/4;
            Console.WriteLine(x);
           
        }
    }
}
