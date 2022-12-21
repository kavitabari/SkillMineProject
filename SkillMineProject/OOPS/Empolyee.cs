using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.OOPS
{
    class Empolyee
    {
        int eid;
        string ename;
        int salary;
        static void Main(string[] args)
        {
            Empolyee emp = new Empolyee();
            emp.eid = 200;
            emp.ename = "kavita";
            emp.salary = 89000;
            Console.WriteLine(emp.eid + "" + emp.ename + " " + emp.salary);

            Empolyee emp2 = new Empolyee();
            emp.eid = 300;
            emp.ename = "Rina";
            emp.salary = 80000;
            Console.WriteLine(emp.eid + "" + emp.ename + " " + emp.salary);
        }

    }
}
