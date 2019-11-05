﻿using Common.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepos.Interface
{
    public interface IAccountManager 
    {
        Task<string> Registration(UserModel user);

        Task<string> LogIn(LoginModel login);
        Task<string> ResetPassword(ResetPasswordModel reset);
        Task<string> ForgotP(ForgotPassword forgot);

    }
}
