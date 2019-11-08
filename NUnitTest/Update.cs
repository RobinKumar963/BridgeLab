// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Update.cs" company="Bridgelabz">
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
    /// <summary>
    /// Unit test for updating employee
    /// </summary>
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
            ////Comparing actualResponse with expectedResponse
            Assert.That(actualResponse, Is.EqualTo(expectedResponse));
            //Assert.Pass();
        }
    }
}
