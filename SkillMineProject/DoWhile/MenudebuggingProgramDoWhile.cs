using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.DoWhile
{
    class MenudebuggingProgramDoWhile
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Char ch;
            do
            {
                Console.WriteLine("Enter The No");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter The no");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter The choice From Following  Menu");
                Console.WriteLine("1.Addition \n 2.Substraction \n 3.Multiplication \n 4.Division");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition =" + num1 + num2);
                        break;
                    case 2:
                        Console.WriteLine("Substraction =" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication =" + num1 * num2);
                        break;
                    case 4:
                        Console.WriteLine("Division =" + num1 + num2);
                        break;

                }
                Console.WriteLine("Do You Want To Continue............");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'Y' || ch == 'y');
        }
    }
}
