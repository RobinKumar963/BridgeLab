// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IAccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------


using Common.Models.UserModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepos.Interface
{
    /// <summary>
    /// Contract for Account Repository
    /// </summary>
    public interface IAccountRepository
    {
        Task Create(UserModel user);
        Task SocialSignUP(SocialUser user);

        Task LogIn(LoginModel login);
        Task SocialLogIN(LoginModel login);


        Task ResetPassword(ResetPasswordModel reset);
        Task Forgot(ForgotPassword forgot);
        Task ImageUpload(IFormFile file,string email);
        Task LogOut(string email);


        Task<UserModel> FindByEmailAsync(string email);
        Task<bool> Check(string email);
        
    }
}
