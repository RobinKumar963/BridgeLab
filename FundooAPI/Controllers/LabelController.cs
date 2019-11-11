// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------




using BusinessManager.Interface;
using Common.Models.LabelModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooAPI.Controllers
{
    /// <summary>
    /// Label Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class LabelController : ControllerBase
    {

        [Route("api/[controller]")]
        [ApiController]

        public class NoteController : ControllerBase
        {
            private readonly ILabelManager manager;

            public NoteController(ILabelManager manager)
            {
                this.manager = manager;
            }



            [HttpPost]
            [Route("AddLabel")]
            [Authorize]
            public async Task<IActionResult> AddNotes(LabelModel labelModel)
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


            [HttpGet]
            [Route("ReadLabel")]
            [Authorize]
            public async Task<IActionResult> ReadLabel(string id)
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
            [Route("UpdateLabel")]
            [Authorize]
            public async Task<IActionResult> UpdateLabel(string id, string label)
            {

                string Email = User.Claims.First(c => c.Type == "Email").Value;
                if (await manager.check(Email))
                {
                    var result = await manager.Update(id, label);
                    return Ok(new { result });
                }
                else
                    return null;



            }

            [HttpDelete]
            [Route("DeleteLabel")]
            [Authorize]
            public async Task<IActionResult> DeleteLabel(string id)
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
}
