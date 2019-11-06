using EmployeeManagementCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUD.Manager
{
    public interface IEmployeeManager
    {
        string CreateEmployee(Employee obj);
        List<Employee> ReadEmployees();
        Employee ReadEmployee(String id,String password);
        string UpdateEmployee(String id, String password, String name, String city, String address);
        string DeleteEmployee(String id);
    }
}
