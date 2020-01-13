// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Common.Models.UserModels;
using FundooRepos.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FundooAPI.Controllers
{
    /// <summary>
    /// Action method for Account Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager _manager;
        
        public AccountController(IAccountManager manager)
        {
            _manager = manager;
        }
        /// <summary>
        /// Add user through UserModel
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Task</returns>
        [HttpPost]
        [Route("Register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(UserModel user)
        {
            try
            {
                var result = await _manager.Registration(user);
                return Ok(new { result });
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        [Route("UploadImage")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            ////Check if the User is Authenticated or Not
            bool isAuthenticated = User.Identity.IsAuthenticated;
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                if (await _manager.Check(Email))
                {
                    var result = await _manager.ImageUpload(file, Email);
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
        public async Task<IActionResult> LogIN(LoginModel login)
        {
            try
            {
                var result = await _manager.LogIn(login);
                if (result != null)
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim("Email", login.USEREMAIL),
                            new Claim("Service",result.CARDTYPE)
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        SigningCredentials = new SigningCredentials
                        (new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("1234567890123456")),
                        SecurityAlgorithms.HmacSha256Signature)

                    };
                    
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    return Ok(new { token,result });
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


        
        /// <summary>
        /// Reset Password
        /// </summary>
        /// <param name="reset"></param>
        /// <returns>Task</returns>
        [HttpPost]
        [Route("Reset")]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel reset)
        {
            ////Check if the User is Authenticated or Not
            bool isAuthenticated = User.Identity.IsAuthenticated;
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            
            try
            {
                if (await _manager.Check(Email) && Email == reset.USEREMAIL)
                {
                    var result = await _manager.ResetPassword(reset);
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
        public async Task<IActionResult> Forgot(ForgotPassword forgot)
        {

            try
            {
                var result = await _manager.ForgotP(forgot);
                return Ok(new { result });
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
            ////Check if the User is Authenticated or Not
            bool isAuthenticated = User.Identity.IsAuthenticated;
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                if (await _manager.Check(Email) && Email == email)
                {
                    var result = await _manager.LogOut(email);
                    return Ok(new { result });
                }
                return null;    
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }



        }
    
    }
}