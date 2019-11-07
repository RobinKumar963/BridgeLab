// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ResetPasswordModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------



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

        private string UserID;
        private string oldpassword;
        private string newpassword;
        private string confirmpassword;
        
        public string USERID
        {
            get
            {
                return UserID;
            }
            set
            {
                UserID = value;
            }
        }
        public string OLDPASSWORD
        {
            get
            {
                return this.oldpassword;
            }
            set
            {
                this.oldpassword = value;
            }
        }
        public string NEWPASSWORD
        {
            get
            {
                return this.newpassword;
            }
            set
            {
                this.newpassword = value;
            }
        }
        public string CONFIRMPASSWORD
        {
            get
            {
                return this.confirmpassword;
            }
            set
            {
                this.confirmpassword = value;
            }
        }
    }
}
