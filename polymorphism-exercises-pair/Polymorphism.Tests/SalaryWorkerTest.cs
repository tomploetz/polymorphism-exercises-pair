using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll.Classes;

namespace Polymorphism.Tests
{
	[TestClass]
	public class SalaryWorkerTest
	{
		[TestMethod]
		public void CalculateWeeklyPay()
		{
			SalaryWorker newtest = new SalaryWorker(100000,"test","test");

			Assert.AreEqual(1923, newtest.CalculateWeeklyPay(0), "input : 0");
			Assert.AreEqual(1923, newtest.CalculateWeeklyPay(50), "input : 50");
			Assert.AreEqual(1923, newtest.CalculateWeeklyPay(-30), "input : -30");
			Assert.AreEqual(1923, newtest.CalculateWeeklyPay(3000), "input : 3000");
		}
	}
}
