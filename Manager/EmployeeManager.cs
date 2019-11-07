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
    /// <summary>
    /// Employee Manager(Uses Employee Repository and includes validation for models) 
    /// </summary>
    public class EmployeeManager : IEmployeeManager
    {
        private IEmpRepository empRepository;
        

        public EmployeeManager(IEmpRepository empRepository)
        {
            this.empRepository = empRepository;
            
        }

      
        /// <summary>
        /// Create Employee
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>string</returns>
        public string CreateEmployee(Employee obj)
        {
            ////Defining Context object for validation
            var context = new ValidationContext(obj, null, null);

            ////For storing all error messages,if any
            var validresult = new List<ValidationResult>();

            ////Running validation
            bool isValid = Validator.TryValidateObject(obj, context, validresult, true);

            if(!isValid)
                throw new ArgumentException("Invalid Parameter");




            if (empRepository.CreateEmployee(obj))
                return "Employee Added Successfully";
            else
                return "Not Added successfully";

        }
        /// <summary>
        /// Read Employees
        /// </summary>
        /// <returns>List<Employee></returns>
        public List<Employee> ReadEmployees()
        {

            return empRepository.ReadEmployees();

        }



        /// <summary>
        /// Read Employee
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <returns>Employee</returns>
        public Employee ReadEmployee(String id,String password)
        {
            if((id==null)||(password==null))
                    throw new ArgumentNullException("Null Parameter");
            if (empRepository.ReadEmployee(id, password) == null)
                throw new NullReferenceException("Null value referenced");

            return empRepository.ReadEmployee(id,password);
        }

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="city"></param>
        /// <param name="address"></param>
        /// <returns>string</returns>
        public string UpdateEmployee(String id,String password,String name,String city,String address)
        {
            if ((id == null) || (password == null) || (name == null) || (city == null)  || (address==null))
                throw new ArgumentNullException("Null Parameter");



            if (empRepository.UpdateEmployee(id,password,name,city,address))
                return "Employee Updated Successfully";
            else
                return "Not Updated successfully";

        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns>string</returns>
        public string DeleteEmployee(String id)
        {

            if (empRepository.DeleteEmployee(id))
                return "Employee Added Successfully";
            else
                return "Not Updated successfully";
        }
    }
}

