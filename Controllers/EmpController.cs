using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EmployeeCRUD.Manager;
using EmployeeManagementCRUD.Model;
using EmployeeManagementCRUD.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagementCRUD.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    
    public class EmpController : Controller
    {
        IEmployeeManager EmpManager;
       
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public EmpController(IEmployeeManager EmpManager)
        {
            this.EmpManager = EmpManager;

        }

          
        [HttpPost]
        [Route("Create")]
        public IActionResult CreateEmployee(Employee obj)
        {
           
            try
            {
                 var result = EmpManager.CreateEmployee(obj);
                return Ok(new { result });

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        // GET: Employee/GetAllEmpDetails    
        [HttpGet]
        [Route("Reads")]
        public IActionResult ReadEmployees()
        {
            try
            {
                var result = EmpManager.ReadEmployees();
                return Ok( result );

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        // GET: Employee/GetAllEmpDetails    
        [HttpPost]
        [Route("Read")]
        public IActionResult ReadEmployee(string id,string password)
        {


            try
            {
                var result = EmpManager.ReadEmployee(id,password);
                return Ok(  result  );

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        // GET: Employee/EditEmpDetails
        [HttpPut]
        [Route("Update")]
        public IActionResult UpdateEmployee(string id,string password,string name,string city,string address)
        {

            try
            {
                var result = EmpManager.UpdateEmployee(id,password,name,city,address);
                return Ok(new { result });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }



        // GET: Employee/DeleteEmp/5  
        [HttpDelete]
        [Route("Delete")]
        public IActionResult DeleteEmployee(string id)
        {
            try
            {
                var result = EmpManager.DeleteEmployee(id);
                return Ok(new { result });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
