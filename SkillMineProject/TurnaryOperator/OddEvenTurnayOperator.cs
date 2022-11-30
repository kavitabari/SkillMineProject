using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.TurnaryOperator
{
    class OddEvenTurnayOperator
    {
        static void Main(string[] arge)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());
            string result = num %2== 0 ? "Even" : "Odd";
            Console.WriteLine(result);
        }
    }
}
