using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.Admin
{
    public class AdminUserDetailView
    {
        private string UserName;
        private string UserEmail;
        private string Service;
        private int Notes;
        private string Status;


        public string USERNAME
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }


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


        
        public string SERVICE
        {
            get
            {
                return Service;
            }
            set
            {
                Service = value;
            }
        }

        
        public int NOTES
        {
            get
            {
                return Notes;
            }
            set
            {
                Notes = value;
            }
        }

        public string STATUS
        {
            get
            {
                return Status;
            }
            set
            {
                Status = value;
            }
        }



    }
}
