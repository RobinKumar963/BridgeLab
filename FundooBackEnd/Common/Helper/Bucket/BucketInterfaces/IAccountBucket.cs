using Common.Models.UserModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper.Bucket.BucketInterfaces
{
    public interface IAccountBucket
    {
        Task  Create(UserModel user);
        Task SocialSignUP(SocialUser user);
        Task<string> ImageUpload(IFormFile file,string email);

        Task<UserModelView> LogIn(LoginModel login);
        Task SocialLogIN(LoginModel login);

        Task ResetPassword(ResetPasswordModel reset);
        Task Forgot(ForgotPassword forgot);

        Task LogOut(string email);

        Task<UserModel> FindByEmailAsync(string email);
        Task<bool> Check(string email);
    }
}
