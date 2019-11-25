using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessManager.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundooAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly IAdminManager _manager;

        public AdminController(IAdminManager manager)
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
                var result = await _manager(user);
                return Ok(new { result });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }




        }


        [HttpPost]
        [Route("UploadImage")]
        [Authorize]
        public async Task<IActionResult> UploadImage(IFormFile file, string email)
        {

            string Email = User.Claims.First(c => c.Type == "Email").Value;


            try
            {
                if (await _manager.Check(Email))
                {
                    var result = await _manager.ImageUpload(file, email);
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



        [HttpGet, Authorize]
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