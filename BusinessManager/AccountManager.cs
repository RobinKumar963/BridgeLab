// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------



using Common.Models.UserModels;
using FundooRepos.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager
{
    public class AccountManager : IAccountManager
    {
        private readonly IAccountRepository _repository;

        public AccountManager(IAccountRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Registration(UserModel user)
        {
            var context = new ValidationContext(user, null, null);
            var validresult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(user, context, validresult, true);

            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await _repository.Create(user);
            return "Account Created Succesfully";
        }


        public async Task<string> LogIn(LoginModel login)
        {
            var context = new ValidationContext(login, null, null);
            var validresult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(login, context, validresult, true);

            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await _repository.LogIn(login);
            return "Login Successfull";
        }

        public async Task<string> ResetPassword(ResetPasswordModel reset)
        {
            var context = new ValidationContext(reset, null, null);
            var validresult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(reset, context, validresult, true);

            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await _repository.ResetPassword(reset);
            return "Successfully Reset the Password";
        }
        public async Task<string> ForgotP(ForgotPassword forgot)
        {
            var context = new ValidationContext(forgot, null, null);
            var validresult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(forgot, context, validresult, true);

            if (!isValid)
                throw new ArgumentException("Invalid Parameter");



            await _repository.Forgot(forgot);
            return "You sucessfully recieved Email for changing Password";
        }
    }
}
