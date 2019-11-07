// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------







using Common.Helper;
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
    /// <summary>
    /// Connect data source for Account 
    /// </summary>
    public class AccountRepository : IAccountRepository
    {
        private readonly UserContext _context;

        public AccountRepository(UserContext context)
        {
            _context = context;
        }


   



        /// <summary>
        /// Create a User Account
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Task</returns>
        public Task Create(UserModel user)
        {
            user.PASSWORD = Encryption.MD5Hash(user.PASSWORD);
            UserModel userm = new UserModel()
            {
                USERID = user.USERID,
                PASSWORD = user.PASSWORD,
                USERNAME=user.USERNAME,
                CARDTYPE=user.CARDTYPE
            };
            _context.users.Add(userm);
            ////Execute query and save any changes in DBcontext UserContext
            return Task.Run(() => _context.SaveChanges());
        }

        /// <summary>
        /// Perform LogIN
        /// </summary>
        /// <param name="login"></param>
        /// <returns>Task</returns>
        public Task LogIn(LoginModel login)
        {
            ////Encrypting Password to check with password from data source
            login.PASSWORD = Encryption.MD5Hash(login.PASSWORD);
            var result = _context.users.Where(i => i.USERID == login.USERID && i.PASSWORD == login.PASSWORD).FirstOrDefault();
            if (result != null)
            {
                ////Execute query and save any changes in DBcontext UserContext
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Perform Resetting of password
        /// </summary>
        /// <param name="reset"></param>
        /// <returns>Task</returns>
        public Task ResetPassword(ResetPasswordModel reset)
        {
            ////Encrypting Password
            reset.NEWPASSWORD = Encryption.MD5Hash(reset.NEWPASSWORD);
            reset.CONFIRMPASSWORD = Encryption.MD5Hash(reset.CONFIRMPASSWORD);
            var result = _context.users.Where(i => i.USERID == reset.USERID && i.PASSWORD == reset.OLDPASSWORD).FirstOrDefault();
            if (result != null)
            {
                result.PASSWORD = reset.NEWPASSWORD;
                ////Execute query and save any changes in DBcontext UserContext
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }


        
        /// <summary>
        /// Helps,to reset password,in case password is forgotten
        /// </summary>
        /// <param name="forgot"></param>
        /// <returns>Task</returns>
        public Task Forgot(ForgotPassword forgot)
        {

            var result = _context.users.Where(i => i.USERID == forgot.USERID).FirstOrDefault();
            if (result != null)
            {
                SendResetPasswordEmail.SendPasswordResetEmail(forgot.USERID, result.USERNAME);
                ////Execute query and save any changes in DBcontext UserContext
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }














    }
}
