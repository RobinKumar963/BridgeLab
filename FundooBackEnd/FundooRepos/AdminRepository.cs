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
using Common.Models.UserModels;
using Common.Constants;

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
        public Task LogOut(string email)
        {

            return Task.Run(() => context.SaveChanges());
        }

        public Task<List<AdminUserDetailView>> UserDetails()
        {
            List<AdminUserDetailView> adminUserDetailViews = new List<AdminUserDetailView>();

            adminUserDetailViews = (from userDetail in context.Users
                                    select new AdminUserDetailView
                                    {
                                        USERNAME = userDetail.USERNAME,
                                        USEREMAIL = userDetail.USEREMAIL,
                                        SERVICE = userDetail.CARDTYPE,
                                        NOTES = context.Notes.Count(i => i.USEREMAIL == userDetail.USEREMAIL),
                                        STATUS = userDetail.STATUS



                                    }
                                    ).ToList();


            return Task.Run(() => adminUserDetailViews);



        }


        public Task<List<UserStatisticsView>> UserStatistics()
        {
            List<UserStatisticsView> userStatisticsView = new List<UserStatisticsView>();

            userStatisticsView = (from userStats in context.UserStatistics
                                  select new UserStatisticsView()
                                  {
                                      SINO = userStats.SINO,
                                      USEREMAIL = userStats.USEREMAIL,
                                      LOGINDATETIME = userStats.LOGINDATETIME,
                                      SERVICE = string.Join("-", (from user in context.Users
                                                                  where userStats.USEREMAIL == user.USEREMAIL
                                                                  select  user.CARDTYPE))


                                  }
                                  ).ToList();


            return Task.Run(() => userStatisticsView);

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

        public Task<AdminModel> FindByEmailAsync(string email)
        {
            ////Getting User with Specifed email From Data Source
            var result = context.Admin.Find(email);
            ////return of user task queued to run on thread pool
            return Task.Run(() => result);
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

    }
}
