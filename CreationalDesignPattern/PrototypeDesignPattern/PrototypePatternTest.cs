using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.PrototypeDesignPattern
{
    class PrototypePatternTest
    {

        public static void Main(String[] args)
        {
            Employee emps = new Employee();
            emps.LoadData();

            ////Use the clone method to get the Employee object
            Employee empsNew = (Employee)emps.ShallowCopy();
            Employee empsNew1 = (Employee)emps.ShallowCopy();
            List<String> list = empsNew.getEmpList();
            list.Add("John");
            List<String> list1 = empsNew1.getEmpList();
            list1.Remove("Pankaj");

            Console.WriteLine("emps List: " + emps.getEmpList());
            Console.WriteLine("empsNew List: " + list);
            Console.WriteLine("empsNew1 List: " + list1);
        }
       
    }
}
