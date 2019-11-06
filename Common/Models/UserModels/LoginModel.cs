// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LoginModel.cs" company="Bridgelabz">
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
    /// Creating a class LoginModel that will have
    /// private string such as email,password.
    /// </summary>
    public class LoginModel
    {
        private string UserID;
        private string Password;
       
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
