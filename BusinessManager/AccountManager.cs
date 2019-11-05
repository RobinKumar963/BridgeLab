using Common.Models.UserModels;
using FundooRepos.Interface;
using System;
using System.Collections.Generic;
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

            await _repository.Create(user);
            return "Account Created Succesfully";
        }


        public async Task<string> LogIn(LoginModel login)
        {
            await _repository.LogIn(login);
            return "Login Successfull";
        }

        public async Task<string> ResetPassword(ResetPasswordModel reset)
        {
            await _repository.ResetPassword(reset);
            return "Successfully Reset the Password";
        }
        public async Task<string> ForgotP(ForgotPassword forgot)
        {
            await _repository.Forgot(forgot);
            return "You sucessfully recieved Email for changing Password";
        }
    }
}
