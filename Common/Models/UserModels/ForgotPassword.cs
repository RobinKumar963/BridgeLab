
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.UserModels
{
    /// <summary>
    /// Creating a class ForgotPassword that will have
    /// private string such as email.
    /// </summary>
    public class ForgotPassword
    {
        private string UserID;
        

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
        

    }
}
