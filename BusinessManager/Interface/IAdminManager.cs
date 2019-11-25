using Common.Models.Admin;
using Common.Models.UserModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Interface
{
    public interface IAdminManager
    {
        Task<string> CreateAdmin(AdminModel admin);
        Task<string> LogIn(AdminLogINModel login);
        Task<string> ResetPassword(AdminResetPasswordModel reset);
        Task<string> Forgot(AdminForgotPasswordModel forgot);
        Task<string> ImageUpload(IFormFile file, string email);
        Task<string> LogOut(string email);



        Task<List<UserStatisticsView>> UserStatistics();
        Task<List<AdminUserDetailView>> UserDetails();

        Task<AdminModel> FindByEmailAsync(string email);
        Task<bool> Check(string email);


    }
}
