using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePayroll.Classes;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
			Random rnd = new Random();
			List<IWorker> workers = new List<IWorker>();
			SalaryWorker ally = new SalaryWorker(70000, "Ally", "Hurt");
			SalaryWorker eli = new SalaryWorker(100000, "Eli", "Reynolds");
			HourlyWorker tom = new HourlyWorker(20.00, "Tom", "Ploetz");
			HourlyWorker dan = new HourlyWorker(50.00, "Dan", "Ridell");
			VolunteerWorker austin = new VolunteerWorker("Austin", "De");
			VolunteerWorker jon = new VolunteerWorker("Jon", "Bedell");
			

			int totalHours = 0;
			int totalPay = 0;

			workers.Add(ally);
			workers.Add(tom);
			workers.Add(austin);
			workers.Add(eli);
			workers.Add(jon);
			workers.Add(dan);


			Console.WriteLine("Employee \t Hours Worked \t Pay");
			foreach(var worker in workers)
			{
				int hoursWorked = rnd.Next(1, 50);
				totalHours += hoursWorked;
				Console.WriteLine(worker.LastName + ", " + worker.FirstName + " \t " + hoursWorked + "\t" + "\t" + " " + worker.CalculateWeeklyPay(hoursWorked).ToString("c"));
				totalPay += (int)worker.CalculateWeeklyPay(hoursWorked);
			}
			Console.WriteLine();
			Console.WriteLine("Total hours worked: " + totalHours);
			Console.WriteLine("Total pay: " + totalPay.ToString("c"));

			Console.ReadKey();
		}
    }
}
