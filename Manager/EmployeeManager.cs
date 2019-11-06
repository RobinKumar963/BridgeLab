// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------


using EmployeeManagementCRUD.Model;
using EmployeeManagementCRUD.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUD.Manager
{
    public class EmployeeManager : IEmployeeManager
    {
        private IEmpRepository empRepository;
        

        public EmployeeManager(IEmpRepository empRepository)
        {
            this.empRepository = empRepository;
            
        }

      
        ////To Create Employee details
        public string CreateEmployee(Employee obj)
        {
            var context = new ValidationContext(obj, null, null);
            var validresult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, context, validresult, true);

            if(!isValid)
                throw new ArgumentException("Invalid Parameter");




            if (empRepository.CreateEmployee(obj))
                return "Employee Added Successfully";
            else
                return "Not Added successfully";

        }
        ////To Read Employees;
        public List<Employee> ReadEmployees()
        {

            return empRepository.ReadEmployees();

        }



        ////Read Employee;
        public Employee ReadEmployee(String id,String password)
        {
            if((id==null)||(password==null))
                    throw new ArgumentNullException("Null Parameter");


            return empRepository.ReadEmployee(id,password);
        }

        ////Update Employee
        public string UpdateEmployee(String id,String password,String name,String city,String address)
        {
            if ((id == null) || (password == null) || (name == null) || (city == null)  || (address==null))
                throw new ArgumentNullException("Null Parameter");



            if (empRepository.UpdateEmployee(id,password,name,city,address))
                return "Employee Updated Successfully";
            else
                return "Not Updated successfully";

        }

        ////Delete Employee
        public string DeleteEmployee(String id)
        {

            if (empRepository.DeleteEmployee(id))
                return "Employee Added Successfully";
            else
                return "Not Updated successfully";
        }
    }
}

