using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class AreaOfCircle
    {
        //hardcode
        static void Main(string[]args)
        {
            double area;
            double pi = 3.14;
            int r = 5;
            area = pi * r * r;
            Console.WriteLine("Area Of circle Is:=" + area);
        }
    }

    class AreaOfCircle1
    {
        //UserInput
        static void Main(string[] args)
        {
            double area;
           
            Console.WriteLine("Enter The radius of circle");
            double r = Convert.ToDouble(Console. ReadLine());
            area = 3.14 * r * r;
            Console.WriteLine("Area Of circle Is:=" + area);
        }
    }
}
