// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------



using Common.Models.UserModels;
using FundooRepos;
using FundooRepos.Interface;
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

        public AccountManager(IAccountRepository repository)
        {
            _repository = repository;
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

            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await _repository.Create(user);
            return "Account Created Succesfully";
        }

        /// <summary>
        /// LogIN user
        /// </summary>
        /// <param name="login"></param>
        /// <returns>Task</returns>
        public async Task<string> LogIn(LoginModel login)
        {
            ////Creating a context object
            var context = new ValidationContext(login, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(login, context, validresult, true);

            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await _repository.LogIn(login);
            return "Login Successfull";
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

            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await _repository.ResetPassword(reset);
            return "Successfully Reset the Password";
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

            if (!isValid)
                throw new ArgumentException("Invalid Parameter");



            await _repository.Forgot(forgot);
            return "You sucessfully recieved Email for changing Password";
        }


        public async Task<UserModel> FindByEmailAsync(string email)
        {
            var result = await _repository.FindByEmailAsync(email);
            return result;
        }
    }
}
