using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
	public class VolunteerWorker : IWorker
	{
		//properties
		public string FirstName { get; }
		public string LastName { get; }


		//constructor
		public VolunteerWorker(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}


		//methods
		public double CalculateWeeklyPay(int hoursWorked)
		{
			return (int)hoursWorked * 0.00;
		}
	}
}
