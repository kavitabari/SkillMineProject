using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Switch
{
    class DayNoSwitch
    {
        static  void Main(string[]args)
        {
            
            int dayno;
            Console.WriteLine("Enter The Day No ");
            dayno = int.Parse(Console.ReadLine());
            switch(dayno)
            {
                case 1:  Console.WriteLine("Monday");
                break;
                case 2:
                    Console.WriteLine("Tusday");
                    break;
                case 3:
                    Console.WriteLine("WensDay");
                    break;

                case 4:
                   Console.WriteLine("ThursDay");
                   break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid The No");
                    break;

            }

        }
    }
}
