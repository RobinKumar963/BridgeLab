using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Models.UserModels
{
    public class UserStatistics
    {
        private int SiNo;
        private string UserEmail;
        private DateTime? LoginDateTime;
        
        [Key]
        [Required]
        public int SINO { get { return SiNo; } set { SiNo = value; } }
        
        [Required]
        [ForeignKey("UserModel")]
        public string USEREMAIL { get { return UserEmail; } set { UserEmail = value; } }
        
        public DateTime? LOGINDATETIME { get { return LoginDateTime; } set { LoginDateTime = value; } }

    }
}
