using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.Admin
{
    public class AdminResetPasswordModel
    {
        private string AdminEmail;
        private string OldPassword;
        private string NewPassword;
        private string ConfirmPassword;

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
        public string OLDPASSWORD
        {
            get
            {
                return this.OldPassword;
            }
            set
            {
                this.OldPassword = value;
            }
        }
        public string NEWPASSWORD
        {
            get
            {
                return this.NewPassword;
            }
            set
            {
                this.NewPassword = value;
            }
        }
        public string CONFIRMPASSWORD
        {
            get
            {
                return this.ConfirmPassword;
            }
            set
            {
                this.ConfirmPassword = value;
            }
        }
    }
}
