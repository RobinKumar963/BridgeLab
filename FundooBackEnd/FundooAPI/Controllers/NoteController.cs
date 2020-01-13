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
using Common.Helper;
using Common.Models.CollabratorModels;
using Common.Models.LabelledNoteModels;
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
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NoteController : ControllerBase
    {
        private readonly INoteManager manager;
        private readonly IAccountManager accountManager;
        private readonly INoteManager noteManagerProxy;

        public NoteController(INoteManager manager, IAccountManager accountManager,INoteManager noteManagerProxy)
        {
            this.manager = manager;
            this.accountManager = accountManager;
            this.noteManagerProxy = noteManagerProxy;
        }



        [HttpPost]
        [Route("AddNotes")]
        public async Task<IActionResult> AddNotes(NoteModel noteModel)
        {
            
            ////Check if the User is Authenticated or Not
            bool isAuthenticated = User.Identity.IsAuthenticated;
            var result="/0";
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                string serviceType = User.Claims.First(c=>c.Type== "Service").Value;
                if (noteModel.USEREMAIL == Email)
                {
                    if (serviceType == "B")
                    { 
                        result = await noteManagerProxy.Add(noteModel); 
                    }
                    else
                    {
                        result = await manager.Add(noteModel);
                    }
                        

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
        [Route("AddCollabaratorNotes")]
        public async Task<IActionResult> AddCollabaratorNotes(CollabratorModel collabratorNoteModel)
        {
            ////Check if the User is Authenticated or Not
            bool isAuthenticated = User.Identity.IsAuthenticated;
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                if (collabratorNoteModel.SENDEREMAIL == Email)
                {
                    var result = await manager.Add(collabratorNoteModel);
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
        [Route("AddLabelledNotes")]
        public async Task<IActionResult> AddLabelledNotes(LabelledNote labelledNote)
        {
            ////Check if the User is Authenticated or Not
            bool isAuthenticated = User.Identity.IsAuthenticated;
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                if (await accountManager.Check(Email))
                {
                    var result = await manager.Add(labelledNote);
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
            ////Check if the User is Authenticated or Not
            bool isAuthenticated = User.Identity.IsAuthenticated;
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                var result = this.manager.ImageUpload(file, id);
                return Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        
        [HttpPatch]
        [Route("UpdateNotes")]
        public async Task<IActionResult> UpdateNotes(NoteUpdateModel noteUpdateModel)
        {
            ////Check if the User is Authenticated or Not
            bool isAuthenticated = User.Identity.IsAuthenticated;

            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                if (await accountManager.Check(Email))
                {
                    var result = await manager.Updates(noteUpdateModel.id, noteUpdateModel.newValue, noteUpdateModel.noteAttributeName);
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
        public async Task<IActionResult> ReadNotes()
        {
            ////Check if the User is Authenticated or Not
            bool isAuthenticated = User.Identity.IsAuthenticated;

            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                if (await accountManager.Check(Email))
                {
                    var res = await manager.GetByID(Email);
                    return Ok(new { res });
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
        public async Task<IActionResult> DeleteNotes(int id)
        {
            ////Check if the User is Authenticated or Not
            bool isAuthenticated = User.Identity.IsAuthenticated;
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