using Common.Models.Admin;
using Common.Models.UserModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper.Bucket.BucketInterfaces
{
    public interface IAdminBucket
    {
        Task CreateAdmin(AdminModel admin);
        Task ImageUpload(IFormFile file, string email);

        Task LogIn(AdminLogINModel login);
        Task LogOut(string email);

        Task<List<UserStatisticsView>> UserStatistics();
        Task<List<AdminUserDetailView>> UserDetails();

        Task ResetPassword(AdminResetPasswordModel reset);
        Task Forgot(AdminForgotPasswordModel forgot);

        Task<AdminModel> FindByEmailAsync(string email);
        Task<bool> Check(string email);
    }
}

