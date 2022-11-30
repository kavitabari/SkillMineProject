using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class AreaOfRectangle
    {
        //hradcode
        static void Main(string[] args)
        {
            int length = 4;
            int breath = 3;
            int area;
            area = length * breath;
            Console.WriteLine("Area Of Rectangle:=" + area);


        }
    }

    //UserInput
    class AreaOfRectangle1
    {
        
        static void Main(string[] args)
        {
           // int length = 4;
             //int breath = 3;
            int area;
            Console.WriteLine("Enter The Length Of Rectangle");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Breath Of Rectangle");
            int b = int.Parse(Console.ReadLine());
            area = l * b;
            Console.WriteLine("Area Of Rectangle:=" + area);


        }
    }
}
