// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Common.Models.UserModels;
using FundooRepos.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FundooAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager _manager;

        public AccountController(IAccountManager manager)
        {
            _manager = manager;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Register(UserModel user)
        {
            
            
                var result = await _manager.Registration(user);
                return Ok(new { result });
            
            
        }


       [HttpPost]
       [Route("LogIn")]
        public async Task<IActionResult> LogIn(LoginModel login)
        {
            var result = await _manager.LogIn(login);
            return Ok(new { result });
        }
        [HttpPost]
        [Route("Reset")]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel reset)
        {
            var result = await _manager.ResetPassword(reset);
            return Ok(new { result });
        }
        [HttpPost]
        [Route("Forgot")]
        public async Task<IActionResult> Forgot(ForgotPassword forgot)
        {
            
            var result = await _manager.ForgotP(forgot);
            return Ok(new { result });
        }
        [HttpPost]
        [Route("log")]
        public async Task<IActionResult> Log(LoginModel login)
        {
            var result = await _manager.LogIn(login);
            if (result != null)
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                       new Claim("Email", login.USERID)
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(5),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("1234567890123456")), SecurityAlgorithms.HmacSha256Signature)

                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token });
            }
            else
            {
                return BadRequest(new { message = "TOken Not Genrated" });
            }
        }




    }
}