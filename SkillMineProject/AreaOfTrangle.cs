using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class AreaOfTrangle
    {
        static void Main(string[]args)
        {
            int h, b, AreaTrangle;
            Console.WriteLine("Enter The Value  Trangle");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value Base");
            b = int.Parse(Console.ReadLine());
            AreaTrangle = ((1 / 2) * b * h);
            Console.WriteLine("Area Of Trangle:=" + AreaTrangle);


        }
    }
}
