using Common.Models.Admin;
using FundooRepos.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepos
{
    /// <summary>
    /// Handles Admin Data Source
    /// </summary>
    public class AdminRepository : IAdminRepository
    {
       

        public Task CreateAdmin(AdminModel admin)
        {
            var res = 0;
            return Task.Run(() => res);
        }

        public Task LogIn(AdminLogINModel login)
        {
            var res = 0;
            return Task.Run(() => res);
        }


        public Task LogOut(string email)
        {
            var res = 0;
            return Task.Run(() => res);
        }

        public Task ImageUpload(IFormFile file, string email)
        {
            var res = 0;
            return Task.Run(() => res);
        }


       


        public Task UserDetails()
        {
            var res = 0;
            return Task.Run(() => res);
        }

        public Task UserStatistics()
        {
            var res = 0;
            return Task.Run(() => res);
        }




        public Task Forgot(AdminForgotPasswordModel forgot)
        {
            var res = 0;
            return Task.Run(() => res);
        }



        public Task ResetPassword(AdminResetPasswordModel reset)
        {
            var res = 0;
            return Task.Run(() => res);
        }
        
        public Task<bool> Check(string email)
        {
            bool res = true;
            return Task.Run(() => res);
        }

        public Task<AdminModel> FindByEmailAsync(string email)
        {
            AdminModel adminModel = new AdminModel();
            return Task.Run(() => adminModel);
        }
    
    }
}
