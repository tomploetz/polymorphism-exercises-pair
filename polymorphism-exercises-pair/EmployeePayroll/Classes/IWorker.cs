using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
	public interface IWorker
	{
		//properties
		string FirstName { get; }
		string LastName { get; }


		//methods
		double CalculateWeeklyPay(int hoursWorked);
	}
}
