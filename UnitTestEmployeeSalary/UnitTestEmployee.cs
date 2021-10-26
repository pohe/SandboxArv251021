using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sandbox;

namespace UnitTestEmployeeSalary
{
    [TestClass]
    public class UnitTestEmployee
    {
        [TestMethod]
        public void TestMethodEmployeeSalary()
        {
            //Arrange
            Employee e1 = new Employee(1, "Poul", "Gade 123", "1212121");

            //Act 
            int expectedSalary = 25000;
            int actualSalary = e1.CalculateSalary();

            //Assert
            Assert.AreEqual(expectedSalary , actualSalary);


        }

        [TestMethod]
        public void TestMethodTeacherSWDSalary()
        {
            //Arrange
            Teacher t1 = new Teacher(2, "Charlotte", "Street 123", "1212323", "Database");
            //Act 
            t1.Subject = "SWD";
            int expectedSalary = 27500;
            int actualSalary = t1.CalculateSalary();

            //Assert
            Assert.AreEqual(expectedSalary, actualSalary);


        }

        [TestMethod]
        public void TestMethodTeacherSWCSalary()
        {
            //Arrange
            Teacher t1 = new Teacher(2, "Charlotte", "Street 123", "1212323", "Database");
            //Act 
            t1.Subject = "SWC";
            int expectedSalary = 25000;
            int actualSalary = t1.CalculateSalary();

            //Assert
            Assert.AreEqual(expectedSalary, actualSalary);


        }
    }
}
