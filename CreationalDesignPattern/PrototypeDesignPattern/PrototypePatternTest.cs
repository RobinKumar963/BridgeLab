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
