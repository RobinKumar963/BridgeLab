using Common.Models.Admin;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepos.Interface
{
    /// <summary>
    /// Contract for AdminRepository
    /// </summary>
    public interface IAdminRepository
    {
        Task CreateAdmin(AdminModel admin);
        Task LogIn(AdminLogINModel login);
        Task ResetPassword(AdminResetPasswordModel reset);
        Task Forgot(AdminForgotPasswordModel forgot);
        Task ImageUpload(IFormFile file, string email);
        Task LogOut(string email);



        Task UserStatistics();
        Task UserDetails();
























        Task<AdminModel> FindByEmailAsync(string email);
        Task<bool> Check(string email);

    }
}
