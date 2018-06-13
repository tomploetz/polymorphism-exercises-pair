using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll.Classes;

namespace Polymorphism.Tests
{
	[TestClass]
	public class VolunteerWorkerTest
	{
		[TestMethod]
		public void CalculateWeeklyPay()
		{
			VolunteerWorker newtest = new VolunteerWorker("test", "test");

			Assert.AreEqual(0, newtest.CalculateWeeklyPay(0), "input : 0");
			Assert.AreEqual(0, newtest.CalculateWeeklyPay(50), "input : 50");
			Assert.AreEqual(0, newtest.CalculateWeeklyPay(-30), "input : -30");
			Assert.AreEqual(0, newtest.CalculateWeeklyPay(3000), "input : 3000");
		}
	}
}
