using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.OOPS
{
    class Car
    {
        //write code  create car  modelno,modelname,display data for  threeclass
            int CarModelNo; //local varible
            string CarName;
            string CarPrice;
            string CarColor;

         public void AcceptDetails(int CarModelNo, string CarName, string CarPrice, string CarColor)
        {
            this.CarModelNo = CarModelNo; //local varible same as refer the instance variable
            this.CarName = CarName;
            this.CarPrice = CarPrice;
            this.CarColor = CarColor;


        }
        public void Display()
        {
            Console.WriteLine("Car Model No Is::=" + CarModelNo);
            Console.WriteLine("Car Name No Is::=" + CarName);
            Console.WriteLine("Car Price No Is::=" + CarPrice);
            Console.WriteLine("Car Color No Is::=" + CarColor);
        }
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.AcceptDetails(13456, "BMW", "Black", "25lakh");
            c1.Display();
            Console.WriteLine("........................");

            Car c2 = new Car();
            c1.AcceptDetails(13456, "Swift", "Red", "20lakh");
            c1.Display();
            Console.WriteLine("........................");

            Car c3 = new Car();
            c1.AcceptDetails(13456, "Hondai", "White", "26lakh");
            c1.Display();
            Console.WriteLine("........................");

        }


    }
}
