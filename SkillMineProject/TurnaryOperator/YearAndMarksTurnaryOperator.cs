using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.TurnaryOperator
{
    class YearAndMarksTurnaryOperator
    {
        static void Main(string[] arge)
        {
            int year, marks;
            Console.WriteLine("Enter The Year");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Marks");
            marks = int.Parse(Console.ReadLine());
            string ans = year == 2022 ? (marks < 60 ? "Selected" : "Not selected") : "not Selected";
            Console.WriteLine(ans);
        }
    }
}
