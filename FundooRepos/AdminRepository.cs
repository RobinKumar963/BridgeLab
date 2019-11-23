using Common.Helper;
using Common.Models.Admin;
using FundooRepos.Context;
using FundooRepos.Interface;
using Microsoft.AspNetCore.Http;
using System.Linq;
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
        private readonly UserContext context;

        public AdminRepository(UserContext context)
        {
            this.context = context;
        }

        public Task CreateAdmin(AdminModel admin)
        {
            ////Encrypting Password
            admin.PASSWORD = Encryption.MD5Hash(admin.PASSWORD);
            ////Adding user to data source using session(instance of DbContext)-context 
            context.Admin.Add(admin);
            ////Save Context Changes task queued to run on thread pool 
            return Task.Run(() => context.SaveChanges());
        }

        public Task LogIn(AdminLogINModel login)
        {
            ////Encrypting Password to check with password from data source
            login.PASSWORD = Encryption.MD5Hash(login.PASSWORD);

            ////Getting value from Data Source
            var result = context.Admin.Where(i => i.ADMINEMAIL == login.ADMINEMAIL && i.PASSWORD == login.PASSWORD).FirstOrDefault();
            if (result != null)
            {
                ////Save Context Changes task queued to run on thread pool  
                return Task.Run(() => context.SaveChanges());
            }
            else
            {
                return null;
            }
        }


        public Task ResetPassword(AdminResetPasswordModel reset)
        {
            ////Encrypting Password
            reset.OLDPASSWORD = Encryption.MD5Hash(reset.OLDPASSWORD);
            reset.NEWPASSWORD = Encryption.MD5Hash(reset.NEWPASSWORD);
            reset.CONFIRMPASSWORD = Encryption.MD5Hash(reset.CONFIRMPASSWORD);
            ////Checking If newpassword and confirmpassword matches
            if (reset.CONFIRMPASSWORD != reset.NEWPASSWORD)
                return Task.Run(() => "Wrong password");
            ////Getting User with specified email and password from Data Source 
            var result = context.Admin.Where(i => i.ADMINEMAIL == reset.ADMINEMAIL && i.PASSWORD == reset.OLDPASSWORD).FirstOrDefault();

            if (result != null)
            {
                ////resetting password for user reterived from data source
                result.PASSWORD = reset.NEWPASSWORD;
                ////Save Context Changes task queued to run on thread pool
                return Task.Run(() => context.SaveChanges());
            }
            else
            {
                return null;
            }
        }

        public Task LogOut(string email)
        {
            return Task.Run(() => "Log out");
        }

        public Task ImageUpload(IFormFile file, string email)
        {
            ////Uploading image and storing the ImageUploadResult(object) in uploadResult
            var uploadresult = ImageUploader.UploadImage(file);

            ////If UploadResult property Error is not null
            ////Throws an exception
            if (uploadresult.Error != null)
                throw new Exception(uploadresult.Error.Message);

            ////Getting user with USEREMAIL == Email and from data source using session(instance of DbContext)-context
            var result = context.Admin.Where(i => i.ADMINEMAIL == email).FirstOrDefault();

            ////On finding result
            if (result != null)
            {
                ////Setting Note field IMAGES with uploadresult url
                result.PROFILEIMAGE = uploadresult.Uri.ToString();
                return Task.Run(() => context.SaveChanges());



            }
            else
            {
                return null;
            }
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
            ////Getting User with specified email from  Data Source
            var result = context.Admin.Where(i => i.ADMINEMAIL == forgot.ADMINEMAIL).FirstOrDefault();
            if (result != null)
            {
                ////Sending Resetting Password Link To User reterieved from Data Source
                SendResetPasswordEmail.SendPasswordResetEmail(forgot.ADMINEMAIL, result.ADMINNAME);
                ////Save Context Changes task queued to run on thread pool
                return Task.Run(() => context.SaveChanges());
            }
            else
            {
                return null;
            }
        }



     
        
        public Task<bool> Check(string email)
        {
            ////Checking for User with Specifed Email From Data Source
            ////On,True this value is queued to run on thread pool
            if (context.Admin.Find(email) != null)
                return Task.Run(() => true);
            else
                return Task.Run(() => false);
        }

        public Task<AdminModel> FindByEmailAsync(string email)
        {
            ////Getting User with Specifed email From Data Source
            var result = context.Admin.Find(email);
            ////return of user task queued to run on thread pool
            return Task.Run(() => result);
        }
    
    }
}
