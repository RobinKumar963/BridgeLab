// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementCRUD.Model
{
    /// <summary>
    /// Model(Employee)
    /// </summary>
    public class Employee 
    {
        [Display(Name = "Id")]
        [Key]
        [Required(ErrorMessage = "ID is required.")]
        [StringLength(100,ErrorMessage ="Not more than 100")]
        public String EmpID { get; set; }

        
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(64, ErrorMessage = "Required length not more than 64")]
        public String Password { get; set; }

        [Display(Name = "EmpName")]
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(30, ErrorMessage = "Required length not more than 30")]
        public String EmpName { get; set; }

        [Display(Name = "Id")]
        [Required(ErrorMessage = "City is required.")]
        [StringLength(40, ErrorMessage = "Required length not more than 40")]
        public String EmpCity { get; set; }


        [Display(Name = "City")]
        [Required(ErrorMessage = "Address is required.")]
        [StringLength(50, ErrorMessage = "Required length not more than 50")]
        public String EmpAddress { get; set; }

        public Boolean CompareTo(Employee obj)
        {
            if ((obj.EmpID == this.EmpID) &&
                    (obj.Password == this.Password) &&
                    (obj.EmpName == this.EmpName) &&
                    (obj.EmpCity == this.EmpCity) &&
                    (obj.EmpAddress == this.EmpAddress))

                return true;

            return false;
        }



       
    }
}
