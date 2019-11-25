using BusinessManager.Interface;
using Common.Models.Admin;
using Common.Models.UserModels;
using FundooRepos.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager
{
    public class AdminManager : IAdminManager
    {
        private readonly IAdminRepository adminRepository;

        public AdminManager(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        public async Task<string> CreateAdmin(AdminModel admin)
        {
            ////Creating a context object
            var context = new ValidationContext(admin, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(admin, context, validresult, true);
            ////On,Validation Failure Throw Exception
            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await adminRepository.CreateAdmin(admin);

            return await Task.Run(() => "Admin Account Created Succesfully");
        }
        public async Task<string> ImageUpload(IFormFile file, string email)
        {
            await adminRepository.ImageUpload(file, email);
            ////maybe need to up[date redish cache bucket for admin bucket which is not yet created
            return await Task.Run(() => "Image Uploaded Succesfully");
        }

        public async Task<string> LogIn(AdminLogINModel login)
        {
            ////Creating a context object
            var context = new ValidationContext(login, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(login, context, validresult, true);
            ////On,Validation Failure Throw Exception
            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await adminRepository.LogIn(login);

            return await Task.Run(() => "Login Succesfully");

        }
        public async Task<string> LogOut(string email)
        {
            await adminRepository.LogOut(email);
            return await Task.Run(() => "Admin LoggedOut Succesfully");
        }

        public Task<List<UserStatisticsView>> UserStatistics()
        {
            return Task.Run(() => adminRepository.UserStatistics());
        }
        public Task<List<AdminUserDetailView>> UserDetails()
        {
            return Task.Run(() => adminRepository.UserDetails());
        }
        
        public async Task<string> ResetPassword(AdminResetPasswordModel reset)
        {
            ////Creating a context object
            var context = new ValidationContext(reset, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(reset, context, validresult, true);
            ////On,Validation Failure Throw Exception
            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await adminRepository.ResetPassword(reset);
            return await Task.Run(() => "Password Resetted Succesfully");
        }
        public async Task<string> Forgot(AdminForgotPasswordModel forgot)
        {
            ////Creating a context object
            var context = new ValidationContext(forgot, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(forgot, context, validresult, true);
            ////On,Validation Failure Throw Exception
            if (!isValid)
                throw new ArgumentException("Invalid Parameter");



            await adminRepository.Forgot(forgot);
            return await Task.Run(() => "Password Resetted Succesfully");
        }
        
        public async Task<AdminModel> FindByEmailAsync(string email)
        {
            var result = await adminRepository.FindByEmailAsync(email);
            return await Task.Run(() => result);
        }
        public async Task<bool> Check(string email)
        {
            var result = await adminRepository.Check(email);
            return await Task.Run(() => result);
        }
    
    }
}
