using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
	public class SalaryWorker : IWorker
	{
		//properties
		public string FirstName { get; }
		public string LastName { get; }
		public double AnnualSalary { get; }


		//constructor
		public SalaryWorker(double annualSalary, string firstName, string lastName)
		{
			AnnualSalary = annualSalary;
			FirstName = firstName;
			LastName = lastName;
		}


		//methods
		public double CalculateWeeklyPay(int hoursWorked)
		{
			return (int)AnnualSalary / 52;
		}
	}
}
