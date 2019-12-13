using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models.Admin
{
    public class AdminModel
    {
        private string AdminEmail;
        private string Password;
        private string AdminName;
        private string ProfileImage;

        [Key]
        [Required]
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


        [Required]
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

        [Required]
        public string ADMINNAME
        {
            get
            {
                return AdminName;
            }
            set
            {
                AdminName = value;
            }
        }
        
        public string PROFILEIMAGE
        {
            get
            {
                return ProfileImage;
            }
            set
            {
                ProfileImage = value;
            }
        }

    }
}
