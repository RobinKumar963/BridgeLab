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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundooAPI.Controllers
{
    /// <summary>
    /// Note Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    
    public class NoteController : ControllerBase
    {
        private readonly INoteManager manager;

        public NoteController(INoteManager manager)
        {
            this.manager = manager;
        }



        [HttpPost]
        [Route("AddNotes")]
        [Authorize]
        public async Task<IActionResult> AddNotes(NoteModel noteModel)
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


        [HttpGet]
        [Route("ReadNotes")]
        [Authorize]
        public async Task<IActionResult> ReadNotes(string id)
        {

            string Email = User.Claims.First(c => c.Type == "Email").Value;
            if (await manager.check(Email))
            {
                var result = await manager.GetByID(id);
                return Ok(new { result });
            }
            else
                return null;



        }
        [HttpPut]
        [Route("UpdateNotes")]
        [Authorize]
        public async Task<IActionResult> UpdateNotes(string id,string des)
        {

            string Email = User.Claims.First(c => c.Type == "Email").Value;
            if (await manager.check(Email))
            {
                var result = await manager.Update(id,des);
                return Ok(new { result });
            }
            else
                return null;



        }

        [HttpDelete]
        [Route("DeleteNotes")]
        [Authorize]
        public async Task<IActionResult> DeleteNotes(string id)
        {

            string Email = User.Claims.First(c => c.Type == "Email").Value;
            if (await manager.check(Email))
            {
                var result = await manager.Delete(id);
                return Ok(new { result });
            }
            else
                return null;



        }




    }
}