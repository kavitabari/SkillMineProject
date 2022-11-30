using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class UOperatorDemo

    {
        static void Main (string[]args)
        {
            //int a=10;

            //Console.WriteLine(a++);
            //Console.WriteLine(a);
            int a =2;
            int b =2;
            int x;
            //int x = ++a + b++;
            //Console.WriteLine(x + "" + a + "" + b);
            //x = a++ + b++ + a;
            //Console.WriteLine(x + "" + a + "" + b);

            x = ++a + ++b;
            Console.WriteLine(x + "" + a + "" + b);//6,3,3

            x = --a - --b;
            Console.WriteLine(x + "" + a + "" + b);

            x = a++ + b--;
            Console.WriteLine(x + "" + a + "" + b);

            x = ++a - b-- + b;
            Console.WriteLine(x + "" + a + "" + b);

            x = ++a + ++b + a;
            Console.WriteLine(x + "" + a + "" + b);

        }
    }
}
