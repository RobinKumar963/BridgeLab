using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.UserModels
{
    public class UserStatisticsView
    {
        private int SiNo;
        private string UserEmail;
        private DateTime? LoginDateTime;
        private string Service;
        
        public int SINO { get { return SiNo; } set { SiNo = value; } }

       
        public string USEREMAIL { get { return UserEmail; } set { UserEmail = value; } }

        public DateTime? LOGINDATETIME { get { return LoginDateTime; } set { LoginDateTime = value; } }


        public string SERVICE { get { return Service; } set { Service = value; } }
    }
}
