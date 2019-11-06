// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------





using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models.UserModels
{
    public class UserModel
    {
        private string UserID;
        private string Password;
        private string UserName;
        private string cardType;
        
        [Key]
        [Required]
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

        
        public string CARDTYPE
        {
            get
            {
                return cardType;
            }
            set
            {
                cardType = value;
            }
        }




    }
}
