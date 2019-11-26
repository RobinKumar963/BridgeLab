using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BusinessManager.Interface;
using Common.Models.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FundooAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AdminController : ControllerBase
    {
        private readonly IAdminManager adminManager;

        public AdminController(IAdminManager adminManager)
        {
            this.adminManager = adminManager;
        }
        /// <summary>
        /// Add user through UserModel
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Task</returns>
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(AdminModel adminModel)
        {
            ////Add method shouldnt be allowed anonymously
            ////As anyone can register as admin
            try
            {
                var result = await adminManager.CreateAdmin(adminModel);
                return Ok(new { result });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        [Route("UploadImage")]
        public async Task<IActionResult> UploadImage(IFormFile file, string email)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                if (await adminManager.Check(Email) && Email == email)
                {
                    var result = await adminManager.ImageUpload(file, email);
                    return Ok(new { result });
                }
                return null;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        /// <summary>
        /// LogIN Model
        /// </summary>
        /// <param name="login"></param>
        /// <returns>Task</returns>
        [HttpPost]
        [Route("LogIN")]
        [AllowAnonymous]
        public async Task<IActionResult> LogIN(AdminLogINModel adminLogINModel)
        {
            try
            {
                var result = await adminManager.LogIn(adminLogINModel);
                if (result != null)
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim("Email", adminLogINModel.ADMINEMAIL)
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        SigningCredentials = new SigningCredentials
                        (new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("1234567890123456")),
                        SecurityAlgorithms.HmacSha256Signature)

                    };








                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    return Ok(new { token });




                }
                else
                {
                    return BadRequest(new { message = "Token Not Genrated" });
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }


        }


        [HttpPost]
        [Route("LogOut")]
        public async Task<IActionResult> LogOut(string email)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                if (await adminManager.Check(Email) && Email == email)
                {
                    var result = await adminManager.LogOut(email);
                    return Ok(new { result });
                }
                return null;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }



        }

        [HttpGet]
        [Route("GetUserStatistics")]
        public async Task<IActionResult> GetUserStatistics()
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                if (await adminManager.Check(Email))
                {
                    var result = await adminManager.UserStatistics();
                    return Ok(new { result });
                }
                return null;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpGet]
        [Route("GetUserDetails")]
        public async Task<IActionResult> GetUserDetails()
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                if (await adminManager.Check(Email))
                {
                    var result = await adminManager.UserDetails();
                    return Ok(new { result });
                }
                return null;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
























        /// <summary>
        /// Reset Password
        /// </summary>
        /// <param name="reset"></param>
        /// <returns>Task</returns>
        [HttpPost]
        [Route("Reset")]
        public async Task<IActionResult> ResetPassword(AdminResetPasswordModel reset)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;

            try
            {
                if (await adminManager.Check(Email) && Email == reset.ADMINEMAIL)
                {
                    var result = await adminManager.ResetPassword(reset);
                    return Ok(new { result });

                }
                return null;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }




        }

        /// <summary>
        /// Forgot password
        /// </summary>
        /// <param name="forgot"></param>
        /// <returns>Forgot</returns>
        [HttpPost]
        [Route("Forgot")]
        [AllowAnonymous]
        public async Task<IActionResult> Forgot(AdminForgotPasswordModel forgot)
        {

            try
            {
                var result = await adminManager.Forgot(forgot);
                return Ok(new { result });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }



        }

       
    }
}