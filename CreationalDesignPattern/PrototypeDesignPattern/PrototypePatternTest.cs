// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PrototypePatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;


namespace Bridgelabz.DesignPattern.CreationalDesignPattern.PrototypeDesignPattern
{
    /// <summary>
    /// Get the clone object from employee providing cloning feature
    /// </summary>
    class PrototypePatternTest
    {

        public static void Main(String[] args)
        {
            Employee emps = new Employee();
            emps.LoadData();

            ////Use the clone method to get the Employee object
            Employee empsNew = emps.ShallowCopy();
            Employee empsNew1 = emps.ShallowCopy();
            List<String> list = empsNew.GetEmpList();
            list.Add("John");
            List<String> list1 = empsNew1.GetEmpList();
            list1.Remove("Pankaj");

            Console.WriteLine("emps List: " + emps.GetEmpList());
            Console.WriteLine("empsNew List: " + list);
            Console.WriteLine("empsNew1 List: " + list1);
        }
       
    }
}
