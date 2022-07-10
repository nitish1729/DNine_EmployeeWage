using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNine_EmployeeWage
{
    public class EmpPresAbs
    {
        int present = 1;
        void display()
        {
			Random ran = new Random();
			int AttenCheck = ran.Next(0, 2);
			if (AttenCheck == present) 
			{
				Console.WriteLine("Emp is Present");
			}
			else
			{
				Console.WriteLine("Emp is Absent");
			}
		}
		public static void Main()
		{
			EmpPresAbs check = new EmpPresAbs();
			check.display();
		}

	}
    
}
