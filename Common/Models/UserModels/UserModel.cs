// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------------------------
 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models.UserModels
{
    public class UserModel
    {
        private string UserEmail;
        private string Password;
        private string UserName;
        private string CardType;
        private string ProfileImage;
        private string Status;

        [Key]
        [Required]
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
                return CardType;
            }
            set
            {
                CardType = value;
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
