// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------



using Common.Helper;
using Common.Models.NoteModels;
using Common.Models.UserModels;
using FundooRepos;
using FundooRepos.Interface;
using Microsoft.AspNetCore.Http;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager
{
    /// <summary>
    /// Manage Account,Use validation to validate all models
    /// </summary>
    public class AccountManager : IAccountManager
    {
        private readonly IAccountRepository _repository;
        private readonly INoteRepository noteRepository;

        public AccountManager(IAccountRepository repository,INoteRepository noteRepository)
        {
            _repository = repository;
            this.noteRepository = noteRepository;
        }

        /// <summary>
        /// Register user 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Task operation</returns>
        public async Task<string> Registration(UserModel user)
        {
            ////Creating a context object
            var context = new ValidationContext(user, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(user, context, validresult, true);
            ////On,Validation Failure Throw Exception
            if (!isValid)
                throw new ArgumentException("Invalid Parameter");
            
            await _repository.Create(user);

            return await Task.Run(() => "Account Created Succesfully");
            
        }
        public Task<string> SocialSignUP(SocialUser user)
        {
            return Task.Run(() => "");
        }
        /// <summary>
        /// Upload profile image.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="email">The email.</param>
        public async Task<string> ImageUpload(IFormFile file, string email)
        {
            string image= await _repository.ImageUpload(file, email);
            ////Maybe need to updsate redish cache bucket for user
            return await Task.Run(() => image);
        }
        
        /// <summary>
        /// LogIN user
        /// </summary>
        /// <param name="login"></param>
        /// <returns>Task</returns>
        public async Task<UserModelView> LogIn(LoginModel login)
        {
            ////Creating a context object
            var context = new ValidationContext(login, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(login, context, validresult, true);
            ////On,Validation Failure Throw Exception
            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            UserModelView userModelView = await _repository.LogIn(login);

           
            //Task<List<NoteModelView>> notefromcache = RedishCacheHelper.Get<Task<List<NoteModel>>>("localhost",noteModelKey);

            //ConnectionMultiplexer connectionMultiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            //IDatabase database = connectionMultiplexer.GetDatabase();

            //database.(noteModelKey, noteModelValue);
            //database.StringGet(noteModelKey);
           

            return await Task.Run(() => userModelView);


           
        }
        public Task<string> SocialLogIN(LoginModel login)
        {
            return Task.Run(() => "");
        }
        
        /// <summary>
        /// Reset Password
        /// </summary>
        /// <param name="reset"></param>
        /// <returns>Task</returns>
        public async Task<string> ResetPassword(ResetPasswordModel reset)
        {
            ////Creating a context object
            var context = new ValidationContext(reset, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(reset, context, validresult, true);
            ////On,Validation Failure Throw Exception
            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await _repository.ResetPassword(reset);
            return await Task.Run(() => "Password Resetted Succesfully");
        }
        /// <summary>
        /// Forgot Password
        /// </summary>
        /// <param name="forgot"></param>
        /// <returns>Task</returns>
        public async Task<string> ForgotP(ForgotPassword forgot)
        {
            ////Creating a context object
            var context = new ValidationContext(forgot, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(forgot, context, validresult, true);
            ////On,Validation Failure Throw Exception
            if (!isValid)
                throw new ArgumentException("Invalid Parameter");



            await _repository.Forgot(forgot);
            return await Task.Run(() => "Password Resetted Succesfully");
        }

        public async Task<string> LogOut(string email)
        {
            await this._repository.LogOut(email);
            return await Task.Run(() => "Admin LoggedOut Succesfully");
        }


        /// <summary>
        /// Finds the user with email identifier.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>Task<UserModel></returns>
        public async Task<UserModel> FindByEmailAsync(string email)
        {
            var result = await _repository.FindByEmailAsync(email);
            return await Task.Run(() => result);
        }
        /// <summary>
        /// Checks the specified email for existence in User Table in Data Source.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>Task<bool></returns>
        public async Task<bool> Check(string email)
        {
            var result = await _repository.Check(email);
            return await Task.Run(() => result);
        }        
      
    }
}
