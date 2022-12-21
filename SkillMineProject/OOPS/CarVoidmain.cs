using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.OOPS
{
    class CarVoidmain
    {

        int ModelNo;
        string Name;
        int Price;
        string Color;

        static void Main(string[]args)
        {
            CarVoidmain car = new CarVoidmain();
            car.Name = "BMW";
            car.ModelNo = 10;
            car.Price = 150000;
            car.Color = "Black";
            Console.WriteLine(car.Name + "" + car.ModelNo + " " + car.Price + " " + car.Color + " ");

           // CarVoidmain car = new CarVoidmain();
            car.Name = "Swift";
            car.ModelNo = 10;
            car.Price = 120000;
            car.Color = "White";
            Console.WriteLine(car.Name + "" + car.ModelNo + " " + car.Price + " " + car.Color + " ");

            car.Name = "Marcidio";
            car.ModelNo = 10;
            car.Price = 100000;
            car.Color = "Brown";
            Console.WriteLine(car.Name + "" + car.ModelNo + " " + car.Price + " " + car.Color + " ");

        }
    }
}
