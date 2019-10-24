// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.PrototypeDesignPattern
{
    /// <summary>
    /// Employye class,provides cloning feature
    /// </summary>
    class Employee
    {
        private List<String> empList;

        public Employee()
        {
            empList = new List<String>();
        }

        public Employee(List<String> list)
        {
            this.empList = list;
        }
        public void LoadData()
        {
            ////read all employees from database and put into the list
            empList.Add("Pankaj");
            empList.Add("Raj");
            empList.Add("David");
            empList.Add("Lisa");
        }

        public List<String> GetEmpList()
        {
            return empList;
        }
        /// <summary>
        /// Provide Clone of this object.
        /// </summary>
        /// <returns></returns>
        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }


    }
}
