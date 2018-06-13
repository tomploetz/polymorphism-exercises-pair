using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
	public class HourlyWorker : IWorker
	{
		//properties
		public string FirstName { get; }
		public string LastName { get; }
		public double HourlyRate { get; }
		


		//constructor
		public HourlyWorker(double hourlyRate, string firstName, string lastName)
		{
			HourlyRate = hourlyRate;
			FirstName = firstName;
			LastName = lastName;
		}


		//methods
		public double CalculateWeeklyPay(int hoursWorked)
		{
			double pay = HourlyRate * hoursWorked;

			if (hoursWorked > 40)
			{
				int overtime = hoursWorked - 40;
				pay = pay + (HourlyRate * overtime * 0.5);
			}
			else if (hoursWorked < 0)
			{
				pay = 0;
			}
			
			return (int)pay;
		}
	}
}
