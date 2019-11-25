using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessManager.Interface;
using Common.Models.LabelModels;
using FundooRepos.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundooAPI.Controllers
{
    /// <summary>
    /// Action Method for label
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]"),Authorize]
    [ApiController]
    public class LabelController : ControllerBase
    {
        private readonly ILabelManager manager;
        private readonly IAccountManager accountManager;

        public LabelController(ILabelManager manager, IAccountManager accountManager)
        {
            this.manager = manager;
            this.accountManager = accountManager;
        }



        [HttpPost]
        [Route("AddLabel")]
        [Authorize]
        public async Task<IActionResult> AddLabel(LabelModel labelModel)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                if (labelModel.USEREMAIL == Email)
                {
                    var result = await manager.Add(labelModel);
                    return Ok(new { result });
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpGet]
        [Route("ReadLabel")]
        [Authorize]
        public async Task<IActionResult> ReadLabel()
        {


            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                if (await accountManager.Check(Email))
                {
                    var result = await manager.GetByID(Email);
                    return Ok(new { result });
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("UpdateLabel")]
        [Authorize]
        public async Task<IActionResult> UpdateLabel<T>(int id,T newValue,string labelAttribute)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                if (await accountManager.Check(Email))
                {
                    var result = await manager.Updates(id,newValue,labelAttribute);
                    return Ok(new { result });
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteLabel")]
        [Authorize]
        public async Task<IActionResult> DeleteLabel(int id)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                if (await accountManager.Check(Email))
                {
                    var result = await manager.Delete(id);
                    return Ok(new { result });
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}