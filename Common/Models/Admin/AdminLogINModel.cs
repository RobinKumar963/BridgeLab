using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.Admin
{
    public class AdminLogINModel
    {
        private string AdminEmail;
        private string Password;

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
        public string PASSWORD
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
    }
}
