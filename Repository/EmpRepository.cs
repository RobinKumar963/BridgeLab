// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmpRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------


using EmployeeCRUD.Helper;
using EmployeeManagementCRUD.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementCRUD.Repository
{
    /// <summary>
    /// Reterive and set data in data source
    /// </summary>
    public class EmpRepository : IEmpRepository
    {


       
        private SqlConnection con;
        
        public EmpRepository()
        {
            con = null;
        }
        public void Conncetion()
        {
            ////Getting Connection String From Web.Config
            //String constr = configration.GetSection("ConnectionStrings").GetSection("Employees").Value;

            ////Setting Connection String(Hard Coded)
            String constr = "Server=(Localdb)\\MSSQLLocalDB;Database=Employee;Integrated Security=True;";
            con = new SqlConnection(constr);
            
        }

      





        /// <summary>
        /// Create emloyee
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public bool CreateEmployee(Employee obj)
        {
            ////For creating unique EmpID
            //long unique = 1;
            //foreach (byte b in Guid.NewGuid().ToByteArray())
            //{
            //unique *= ((int)b + 1);
            //}
            //string empid =string.Format("{0:x}", unique - DateTime.Now.Ticks);

            //obj.SetEmpID(empid);

            ////Encrypting Password
            string password = Encryption.MD5Hash(obj.Password);
            Conncetion();
            SqlCommand create = new SqlCommand("CreateEmployee", con);
            create.CommandType = CommandType.StoredProcedure;
            create.Parameters.AddWithValue("@EmpID", obj.EmpID);
            create.Parameters.AddWithValue("@Password", password);
            create.Parameters.AddWithValue("@EmpName", obj.EmpName);
            create.Parameters.AddWithValue("@EmpCity", obj.EmpCity);
            create.Parameters.AddWithValue("@EmpAddress", obj.EmpAddress);

            con.Open();
            int i = create.ExecuteNonQuery();
            con.Close();
            return i >= 1;


        }

        /// <summary>
        /// Read Employees
        /// </summary>
        /// <returns>List<Employee></returns>
        public List<Employee> ReadEmployees()
        {

            Conncetion();
            List<Employee> EmpList = new List<Employee>();
            SqlCommand details = new SqlCommand("ReadEmployees", con);
            details.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(details);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            ////Bind EmpModel generic list using LINQ 
            EmpList = (from DataRow dr in dt.Rows

                       select new Employee()
                       {
                           EmpID= Convert.ToString(dr["EmpID"]),
                           Password = Convert.ToString(dr["Password"]),
                           EmpName = Convert.ToString(dr["EmpName"]),
                           EmpCity = Convert.ToString(dr["EmpCity"]),
                           EmpAddress=Convert.ToString(dr["EmpAddress"])

                       }
                       
                       
                       
                       )
                       .ToList();
            


            return EmpList;

        }




        /// <summary>
        /// Read Employee
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <returns>Employee</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public Employee ReadEmployee(String id,String password)
        {
            
            Conncetion();
            ////Encrypting Password to check with data source password
            password = Encryption.MD5Hash(password);


            SqlCommand detail = new SqlCommand("ReadEmployee", con);
            detail.CommandType = CommandType.StoredProcedure;
            detail.Parameters.AddWithValue("@EmpID",id);
            detail.Parameters.AddWithValue("@Password",password);
            SqlDataAdapter da = new SqlDataAdapter(detail);
            DataTable emp = new DataTable();
            con.Open();
            da.Fill(emp);
            con.Close();










            ////Bind EmpModel generic list using LINQ
            
            Employee empobj=new Employee();
            foreach(DataRow row in emp.Rows)
            {
                empobj.EmpID = row["EmpID"].ToString();
                empobj.Password = row["Password"].ToString();
                empobj.EmpName = row["EmpName"].ToString();
                empobj.EmpCity = row["EmpCity"].ToString();
                empobj.EmpAddress = row["EmpAddress"].ToString();
            }

                            
                return empobj;
            
            
        }

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="city"></param>
        /// <param name="address"></param>
        /// <returns>bool</returns>
        public bool UpdateEmployee(string id, string password, string name, string city, string address)
        {

            Conncetion();
            SqlCommand updateemployee = new SqlCommand("UpdateEmployee", con);
            updateemployee.CommandType = CommandType.StoredProcedure;
            updateemployee.Parameters.AddWithValue("@EmpID",id);
            updateemployee.Parameters.AddWithValue("@Password", password);
            updateemployee.Parameters.AddWithValue("@EmpName", name);
            updateemployee.Parameters.AddWithValue("@EmpCity", city);
            updateemployee.Parameters.AddWithValue("@EmpAddress", address);
            SqlDataAdapter da = new SqlDataAdapter(updateemployee);
            DataTable dt = new DataTable();
            con.Open();
            int i = updateemployee.ExecuteNonQuery();
            con.Close();
            return i >= 1;

        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns>bool</returns>
        public bool DeleteEmployee(string id)
        {
            Conncetion();
            SqlCommand deleteemployee = new SqlCommand("DeleteEmployee", con);
            deleteemployee.CommandType = CommandType.StoredProcedure;
            deleteemployee.Parameters.AddWithValue("@EmpID", id);
            SqlDataAdapter da = new SqlDataAdapter(deleteemployee);
            con.Open();
            int i = deleteemployee.ExecuteNonQuery();
            con.Close();
            return i >= 1;


        }
    }
}
