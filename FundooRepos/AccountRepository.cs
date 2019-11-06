// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------







using Common.Models.UserModels;
using FundooRepos.Context;
using FundooRepos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepos
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserContext _context;

        public AccountRepository(UserContext context)
        {
            _context = context;
        }


        ////To encrypt password
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }




        public Task Create(UserModel user)
        {
            user.PASSWORD = MD5Hash(user.PASSWORD);
            UserModel userm = new UserModel()
            {
                USERID = user.USERID,
                PASSWORD = user.PASSWORD,
                USERNAME=user.USERNAME,
                CARDTYPE=user.CARDTYPE
            };
            _context.users.Add(userm);
            return Task.Run(() => _context.SaveChanges());
        }


        public Task LogIn(LoginModel login)
        {
            login.PASSWORD = MD5Hash(login.PASSWORD);
            var result = _context.users.Where(i => i.USERID == login.USERID && i.PASSWORD == login.PASSWORD).FirstOrDefault();
            if (result != null)
            {
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }
        public Task ResetPassword(ResetPasswordModel reset)
        {
            reset.NEWPASSWORD = MD5Hash(reset.NEWPASSWORD);
            reset.CONFIRMPASSWORD = MD5Hash(reset.CONFIRMPASSWORD);
            var result = _context.users.Where(i => i.USERID == reset.USERID && i.PASSWORD == reset.OLDPASSWORD).FirstOrDefault();
            if (result != null)
            {
                result.PASSWORD = reset.NEWPASSWORD;
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }


        private void SendPasswordResetEmail(string ToEmail, string UserName)
        {
            // MailMessage class is present is System.Net.Mail namespace
            MailMessage mailMessage = new MailMessage("robbhood123@gmail.com", ToEmail);
            // StringBuilder class is present in System.Text namespace
            StringBuilder sbEmailBody = new StringBuilder();
            sbEmailBody.Append("Dear " + UserName + ",<br/><br/>");
            sbEmailBody.Append("Please click on the following link to reset your password");
            sbEmailBody.Append("<br/>");
            sbEmailBody.Append("http://localhost/WebApplication1/Registration/ChangePassword.aspx?uid=");
            sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("<b>BRIDGELABZ</b>");
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = sbEmailBody.ToString();
            mailMessage.Subject = "Reset Your Password";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "robbhood123@gmail.com",
                Password = "p12ocb2slim9012"
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }

        public Task Forgot(ForgotPassword forgot)
        {
            var result = _context.users.Where(i => i.USERID == forgot.USERID).FirstOrDefault();
            if (result != null)
            {
                SendPasswordResetEmail(forgot.USERID, result.USERNAME);
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }














    }
}
