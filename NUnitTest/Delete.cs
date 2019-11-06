using EmployeeManagementCRUD.Model;
using EmployeeManagementCRUD.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    class Delete
    {
        IEmpRepository repos = new EmpRepository();
        bool expectedResponse;
        Employee employee = new Employee();

        bool actualResponse;
        [SetUp]
        public void Setup()
        {
            String EmpID = "robbhood123@gmail.com";
         
            expectedResponse = true;
            actualResponse = repos.DeleteEmployee(EmpID);
        }

        [Test]
        public void DeleteTest()
        {
            Assert.That(actualResponse, Is.EqualTo(expectedResponse));
            //Assert.Pass();
        }
    }
}
