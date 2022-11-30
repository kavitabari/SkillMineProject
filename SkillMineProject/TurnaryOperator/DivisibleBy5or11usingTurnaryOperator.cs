using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.TurnaryOperator
{
    class DivisibleBy5or11usingTurnaryOperator
    {
        static void Main(string[] arge)
        {
            Console.WriteLine("Enter Any No");
            int num = int.Parse(Console.ReadLine());
            string result = num %5== 0 ? ("Divisible") : num %11== 0 ? ("Divisible") : "Not Divisible";
            Console.WriteLine(result);
        }
    }
}
