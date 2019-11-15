// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessManager.Interface;
using Common.Models.NoteModels;
using FundooRepos.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundooAPI.Controllers
{
    /// <summary>
    /// Action Method for Note
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]"),Authorize]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteManager manager;
        private readonly IAccountManager accountManager;
        public NoteController(INoteManager manager, IAccountManager accountManager)
        {
            this.manager = manager;
            this.accountManager = accountManager;
        }



        [HttpPost]
        [Route("AddNotes")]
        [Authorize]
        public async Task<IActionResult> AddNotes(NoteModel noteModel)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                if (noteModel.USEREMAIL == Email)
                {
                    var result = await manager.Add(noteModel);
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
        [Route("ReadNotes")]
        [Authorize]
        public async Task<IActionResult> ReadNotes()
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
        [Route("UpdateNotes")]
        [Authorize]
        public async Task<IActionResult> UpdateNotes(int id,string des)
        {

            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                if (await accountManager.Check(Email))
                {
                    var result = await manager.Update(id, des);
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
        [Route("DeleteNotes")]
        [Authorize]
        public async Task<IActionResult> DeleteNotes(int id)
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
        [HttpPost]
        [Route("Upload")]
        public IActionResult ImageUpload(IFormFile file, int id)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                var result = this.manager.ImageUpload(file, id, Email);
                return Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}