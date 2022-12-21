using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class ArrayCreation
    {
        static void Main(string[]args )
        {

            //Array Creation
           // int x = 10; //inilization
            int[] arr = { 5, 3, 2, 8 };
            int[] myarray = new int[4]; //declaration of object
            /* myarray[0] = 7;
             myarray[1] = 3;
             myarray[2] = 12;//hardcodeValue
             myarray[4] = 4;*/
            Console.WriteLine("Enter The Array Element");
            for(int i=0;i< myarray.Length; i++)
            {
                /*int x = int.Parse(Console.ReadLine());
                myarray[i] = x;*/
                 myarray[i] = int.Parse(Console.ReadLine());
                // myarray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("................................");
            //Display Of array
            for(int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
            }
            Console.WriteLine("................................");
            foreach(int element  in myarray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("................................");
            Console.WriteLine(string.Join("", myarray));
            Console.WriteLine(string.Join(",", myarray));
            Console.WriteLine(myarray);//array is object show the put is memory on hashcode system.Int32[]output

        } 
    }
}
