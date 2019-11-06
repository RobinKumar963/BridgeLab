using EmployeeManagementCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementCRUD.Repository
{
    public interface IEmpRepository
    {
        
        bool CreateEmployee(Employee obj);
        List<Employee> ReadEmployees();
        Employee ReadEmployee(string id,string password);
        bool UpdateEmployee(string id,string password,string name,string city,string address);
        bool DeleteEmployee(string id);

    }
}
