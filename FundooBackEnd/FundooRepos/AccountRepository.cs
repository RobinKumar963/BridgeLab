// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------
using Common.Constants;
using Common.Helper;
using Common.Models.UserModels;
using FundooRepos.Context;
using FundooRepos.Interface;
using Microsoft.AspNetCore.Http;
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
    /// Connect Data Source for Account 
    /// </summary>
    public class AccountRepository : IAccountRepository
    {
        private readonly UserContext context;

        public AccountRepository(UserContext context) 
        {
            this.context = context;
        }

        /// <summary>
        /// Create a User Account
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Task</returns>
        public Task Create(UserModel user)
        {
            ////Encrypting Password
            user.PASSWORD = Encryption.MD5Hash(user.PASSWORD);
            ////Generating unique UserID
            user.USERID = UniqueIDGenerator.GenerateUniqueString();
            ////Adding user to data source using session(instance of DbContext)-context 
            context.Users.Add(user);
            ////Save Context Changes task queued to run on thread pool 
            return Task.Run(() => context.SaveChanges());
        }        

        public Task SocialSignUP(SocialUser user)
        {
            return Task.Run(() => context.SaveChanges());
        }

        /// <summary>
        /// Upload Profile Image in Cloudnary.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="email">The email.</param>
        /// <returns>Task</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<string> ImageUpload(IFormFile file, string email)
        {
            ////Uploading image and storing the ImageUploadResult(object) in uploadResult
            var uploadresult = ImageUploader.UploadImage(file);

            ////If UploadResult property Error is not null
            ////Throws an exception
            if (uploadresult.Error != null)
                throw new Exception(uploadresult.Error.Message);

            ////Getting user with USEREMAIL == Email and from data source using session(instance of DbContext)-context
            var result = context.Users.Where(i => i.USEREMAIL == email).FirstOrDefault();

            ////On finding result
            if (result != null)
            {
                ////Setting Note field IMAGES with uploadresult url
                result.PROFILEIMAGE = uploadresult.Uri.ToString();
                context.SaveChanges();
                return Task.Run(() => result.PROFILEIMAGE);



            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Perform LogIN
        /// </summary>
        /// <param name="login"></param>
        /// <returns>Task</returns>
        public Task<UserModelView> LogIn(LoginModel login)
        {
            ////Encrypting Password to check with password from data source
            login.PASSWORD = Encryption.MD5Hash(login.PASSWORD);

            ////Getting value from Data Source
            var result = context.Users.Where(i => i.USEREMAIL == login.USEREMAIL && i.PASSWORD == login.PASSWORD).FirstOrDefault();
            if (result != null)
            {
                context.Users.Find(login.USEREMAIL).STATUS = Constants.userStatusActive;
                ////Add UserStatistics in data source 
                UserStatistics userStatistics = new UserStatistics
                {
                    USEREMAIL=login.USEREMAIL,
                    LOGINDATETIME=DateTime.Now

                };
                context.UserStatistics.Add(userStatistics);
                context.SaveChanges();

                UserModelView userModelView = new UserModelView
                {
                    USEREMAIL = result.USEREMAIL,
                    USERID = result.USERID,
                    USERNAME = result.USERNAME,
                    CARDTYPE = result.CARDTYPE,
                    PROFILEIMAGE = result.PROFILEIMAGE
                };


                ////Save Context Changes task queued to run on thread pool  
                return Task.Run(() => userModelView);
            }
            else
            {
                return null;
            }
        }
        public Task SocialLogIN(LoginModel login)
        {
            return Task.Run(() => context.SaveChanges());
        }

        /// <summary>
        /// Perform Resetting of password
        /// </summary>
        /// <param name="reset"></param>
        /// <returns>Task</returns>
        public Task ResetPassword(ResetPasswordModel reset)
        {
            ////Encrypting Password
            reset.OLDPASSWORD = Encryption.MD5Hash(reset.OLDPASSWORD);
            reset.NEWPASSWORD = Encryption.MD5Hash(reset.NEWPASSWORD);
            reset.CONFIRMPASSWORD = Encryption.MD5Hash(reset.CONFIRMPASSWORD);
            ////Checking If newpassword and confirmpassword matches
            if (reset.CONFIRMPASSWORD != reset.NEWPASSWORD)
                return Task.Run(() => "Wrong password");
            ////Getting User with specified email and password from Data Source 
            var result = context.Users.Where(i => i.USEREMAIL == reset.USEREMAIL && i.PASSWORD == reset.OLDPASSWORD).FirstOrDefault();

            if (result != null)
            {
                ////resetting password for user reterived from data source
                result.PASSWORD = reset.NEWPASSWORD;
                ////Save Context Changes task queued to run on thread pool
                return Task.Run(() => context.SaveChanges());
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
            ////Getting User with specified email from  Data Source
            var result = context.Users.Where(i => i.USEREMAIL == forgot.USEREMAIL).FirstOrDefault();
            if (result != null)
            {
                ////Sending Resetting Password Link To User reterieved from Data Source
                SendResetPasswordEmail.SendPasswordResetEmail(forgot.USEREMAIL, result.USERNAME);
                ////Save Context Changes task queued to run on thread pool
                return Task.Run(() => context.SaveChanges());
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Log out user.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public Task LogOut(string email)
        {
            context.Users.Find(email).STATUS = Constants.userStatusInActive;
            return Task.Run(() => context.SaveChanges());
        }

        /// <summary>
        /// Check for specified Email in Data Source.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>Task<UserModel></returns>
        public Task<UserModel> FindByEmailAsync(string email)
        {
            UserModel userModel = context.Users.Find(email);

            return Task.Run(()=>userModel);
        }
        
        /// <summary>
        /// Checks the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>Task<bool></returns>
        public Task<bool> Check(string email)
        {
            ////Checking for User with Specifed Email From Data Source
            ////On,True this value is queued to run on thread pool
            if (context.Users.Find(email)!=null)
                return Task.Run(() => true);
           else
                return Task.Run(() => false);
        }

        

        
    }
}
