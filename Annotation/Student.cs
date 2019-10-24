// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Student.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------








namespace Bridgelabz.DesignPattern.Annotation
{
    class Student
    {
        // Private fields of class Student 
        private int rollNo; 
        private string stuName; 
        private double marks; 
  
        // The attribute MyAttribute is applied  
        // to methods of class Student 
        // Providing details of their utility 
        [MyAttributes("Modifier", "Assigns the Student Details")] 
        public void setDetails(int r, string sn, double m) 
        { 
            rollNo = r; 
            stuName = sn; 
            marks = m; 
        } 
  
        [MyAttributes("Accessor", "Returns Value of rollNo")] 
        public int getRollNo() 
        { 
            return rollNo; 
        } 
  
        [MyAttributes("Accessor", "Returns Value of stuName")] public string getStuName() 
        { 
            return stuName; 
        } 
  
        [MyAttributes("Accessor", "Returns Value of marks")] public double getMarks() 
        { 
            return marks; 
        } 
    }
}
