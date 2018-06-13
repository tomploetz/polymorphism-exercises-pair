using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll.Classes;

namespace Polymorphism.Tests
{
	[TestClass]
	public class HourlyWorkerTest
	{
		[TestMethod]
		public void CalculateWeeklyPay()
		{

			HourlyWorker test = new HourlyWorker(20, "test", "test");

			Assert.AreEqual(0, test.CalculateWeeklyPay(0), "input : 0");
			Assert.AreEqual(1100, test.CalculateWeeklyPay(50), "input : 50");
			Assert.AreEqual(0, test.CalculateWeeklyPay(-30), "input : -30");
			Assert.AreEqual(89600, test.CalculateWeeklyPay(3000), "input : 3000");
		}
	}
}
