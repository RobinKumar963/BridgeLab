// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IAccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------


using Common.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepos.Interface
{
    public interface IAccountRepository
    {
        Task Create(UserModel user);
        Task LogIn(LoginModel login);
        Task ResetPassword(ResetPasswordModel reset);
        Task Forgot(ForgotPassword forgot);
    }
}
