using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Switch
{
    class OddEvenSwitch
    {
        static void Main (string[]args)
        {
            Console.WriteLine("Enter The no");
            int num = int.Parse(Console.ReadLine());
            switch (num % 2 == 0)
            {
                  case true:Console.WriteLine(" even");
                        break;
                  case false: Console.WriteLine(" odd");
                        break;
            }
        }
    }
}
