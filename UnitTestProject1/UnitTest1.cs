using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmployeeBaseSalary()
        {
            //Arrange
            Employee e1 = new Employee(1, "Poul", "Gade 123", "1212121");
            int expectedSalary = 25000;
            //Act

            //Assert
            Assert.AreEqual(expectedSalary, e1.CalculateSalary());

        }

        [TestMethod]
        public void TestTEacherSalary()
        {
            //Arrange
            Teacher e1 = new Teacher(1, "Poul", "Gade 123", "1212121", "SWC");
            int expectedSalary = 27500;
            //Act

            //Assert
            Assert.AreEqual(expectedSalary, e1.CalculateSalary());

        }

    }
}
