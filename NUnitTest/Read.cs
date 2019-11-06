// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Read.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------



using EmployeeManagementCRUD.Model;
using EmployeeManagementCRUD.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    class Read
    {
        IEmpRepository repos = new EmpRepository();
        Employee expectedResponse;
        Employee actualResponse;
        bool expected = true;
        bool actual = false;

        [SetUp]
        public void Setup()
        {
            
            
            expected = true;
            expectedResponse = new Employee();
            expectedResponse.EmpID = "robbhood123@gmail.com";
            expectedResponse.Password = "123";
            expectedResponse.EmpName = "Robin Kumar";
            expectedResponse.EmpCity = "Ghato";
            expectedResponse.EmpAddress = "Ranc";
            
            actualResponse = repos.ReadEmployee(expectedResponse.EmpID,expectedResponse.Password);
            actual = expectedResponse.CompareTo(actualResponse);
        }

        [Test]
        public void ReadTest()
        {
            ////Need to use value objects here instead of CompareTO
            Assert.That(actual, Is.EqualTo(expected));
            //Assert.Pass();
        }
    }
}
