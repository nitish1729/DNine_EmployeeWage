using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNine_EmployeeWage
{
    public class EmpPartTimeWage
    {
        int WagePerHrs = 20;
        int FullTime = 8;
        int partTime = 4;
        int NoWork = 0;

        public void display() // non- static method

        {

            Random ran = new Random();

            int AttenCheck = ran.Next(0, 9);

            if (AttenCheck == FullTime)
            {
                Console.WriteLine("Emp is Present");
                Console.WriteLine("Employee fulltime wage is :- " + (WagePerHrs * FullTime));
            }

            else if (AttenCheck == partTime)
            {
                Console.WriteLine("Emp is present for HalfDay");
                Console.WriteLine("Employee part time wage is :- " + (WagePerHrs * partTime));
            }

            else
            {
                Console.WriteLine("Emp is Absent");
                Console.WriteLine("EmpWage : " + (WagePerHrs * NoWork));
            }
        }
        public static void Main(string[] args)
        {
            EmpPartTimeWage wages = new EmpPartTimeWage();
            wages.display();
        }
    }
}
