
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SendResetPasswordEmail.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Common.Helper
{
    /// <summary>
    /// Mail sender Helper
    /// </summary>
    public class SendResetPasswordEmail
    {
        public static void SendPasswordResetEmail(string ToEmail, string UserName)
        {
            ////MailMessage class is present is System.Net.Mail namespace
            MailMessage mailMessage = new MailMessage("robbhood123@gmail.com", ToEmail);
            ////StringBuilder class is present in System.Text namespace
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
                Password = "iamsonofgodp12ocb2slim9012"
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }
    }
}
