using EmployeeManagementCRUD.Model;
using EmployeeManagementCRUD.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    class Update
    {

        IEmpRepository repos = new EmpRepository();
        bool expectedResponse;
        

        bool actualResponse;

        [SetUp]
        public void Setup()
        {
            
            string id = "robbhood123@gmail.com";
            string Password = "12345";
            string name = "Robin Kumar";
            string city = "Ghato";
            string address = "Ranc";

            expectedResponse = true;
            actualResponse = repos.UpdateEmployee(id, Password, name, city, address);
        }

        [Test]
        public void UpdateTest()
        {
            Assert.That(actualResponse, Is.EqualTo(expectedResponse));
            //Assert.Pass();
        }
    }
}
