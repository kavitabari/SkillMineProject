using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.TurnaryOperator
{
    class PositiveAndNegativeTurnary
    {
        static void Main(string[]arge)
        {
            Console.WriteLine("Enter Any No");
            int num = int.Parse(Console.ReadLine());
            string result = num > 0 ? ("Positive") : num < 0 ? ("Negative") : "Num Is Zaro";
            Console.WriteLine(result);
        }
    }
}
