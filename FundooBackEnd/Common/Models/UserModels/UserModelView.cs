using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.UserModels
{
    public class UserModelView
    {
        private string UserEmail;
        private string UserID;
       
        private string UserName;
        private string CardType;
        private string ProfileImage;
      

        
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








       
       
        public string USERID { get { return UserID; } set { UserID = value; } }

       

        
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


    }
}
