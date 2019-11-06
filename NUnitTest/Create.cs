// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Create.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------




using EmployeeManagementCRUD.Model;
using EmployeeManagementCRUD.Repository;
using NUnit.Framework;

namespace NUnitTest
{
    public class Create
    {
        IEmpRepository repos = new EmpRepository();
        bool expectedResponse;
        Employee employee = new Employee();

        bool actualResponse;  

        [SetUp]
        public void Setup()
        {
            employee.EmpID = "robbhood123@gmail.com";
            employee.Password = "123";
            employee.EmpName = "Robin Kumar";
            employee.EmpCity = "Ghato";
            employee.EmpAddress = "Ranc";
            expectedResponse = true;
            actualResponse= repos.CreateEmployee(employee);
        }

        [Test]
        public void CreateTest()
        {
            Assert.That(actualResponse, Is.EqualTo(expectedResponse));
            //Assert.Pass();
        }


       

    }
}