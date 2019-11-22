using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.Admin
{
    public class AdminForgotPasswordModel
    {
        private string AdminEmail;


        public string ADMINEMAIL
        {
            get
            {
                return AdminEmail;
            }
            set
            {
                AdminEmail = value;
            }
        }
    }
}
