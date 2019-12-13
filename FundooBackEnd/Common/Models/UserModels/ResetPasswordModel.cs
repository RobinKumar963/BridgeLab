// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ResetPasswordModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.UserModels
{
    /// <summary>
    /// Creating a class ResetPasswordModel that will have
    /// private string such as email,oldpassword etc.,
    /// </summary>
    public class ResetPasswordModel
    {

        private string UserEmail;
        private string OldPassword;
        private string NewPassword;
        private string ConfirmPassword;
       
        public string USEREMAIL
        {
            get
            {
                return UserEmail;
            }
            set
            {
                UserEmail = value;
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
