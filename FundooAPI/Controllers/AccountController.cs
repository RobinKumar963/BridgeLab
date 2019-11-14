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
    /// Account Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
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
        [Route("Add")]
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

        /// <summary>
        /// LogIN
        /// </summary>
        /// <param name="login"></param>
        /// <returns>Task</returns>
        //[HttpPost]
        //[Route("LogIn")]
        //public async Task<IActionResult> LogIn(LoginModel login)
        //{


        //    try
        //    {
        //        var result = await _manager.LogIn(login);
        //        return Ok(new { result });
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }


           
        //}

        /// <summary>
        /// Reset Password
        /// </summary>
        /// <param name="reset"></param>
        /// <returns>Task</returns>
        [HttpPost]
        [Route("Reset")]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel reset)
        {
            try
            {
                var result = await _manager.ResetPassword(reset);
                return Ok(new { result });
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

        /// <summary>
        /// LogIN Model
        /// </summary>
        /// <param name="login"></param>
        /// <returns>Task</returns>
        [HttpPost]
        [Route("LogIN")]
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
                       new Claim("Email", login.USEREMAIL)
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



        [HttpGet,Authorize]
        [Route("reg")]
        public async Task<object> GetDetails()
        {

            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                var result = await _manager.FindByEmailAsync(Email);
                return new
                {
                    result.USEREMAIL,
                    result.USERNAME,
                    result.CARDTYPE


                };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
           
        }

       


    }
}