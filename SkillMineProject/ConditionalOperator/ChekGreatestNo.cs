using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class ChekGreatestNo
    {
        static void Main(string[] args)
        {
            int year, marks;
            Console.WriteLine("Enter The Year");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Marks");
            marks = int.Parse(Console.ReadLine());

            if(year==2022)
            {
                if (marks > 60)
                {
                    Console.WriteLine("Candidate Is eligibale For The Interview");
                }
                else
                {
                    Console.WriteLine("Marks Is Less Than 60%");
                }
            }
            else
            {
                Console.WriteLine("Candidate Is  not selected");
            }
        }
    }
}
