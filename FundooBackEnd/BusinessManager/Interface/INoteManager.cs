// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INoteManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------


using Common.Models.CollabratorModels;
using Common.Models.LabelledNoteModels;
using Common.Models.NoteModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Interface
{
    /// <summary>
    /// Contract for NoteMAnager
    /// </summary>
    public interface INoteManager
    {
        Task<string> Add(NoteModel noteModel);
        Task<string> Add(CollabratorModel collabratorModel);
        Task<string> Add(LabelledNote labelNote);
        
        Task<string> ImageUpload(IFormFile file, int id);
        Task<string> Updates(int id, string newValue, string attribute);
        
        Task<List<NoteModelView>> GetByID(string email);
        
        Task<string> Delete(int id);


    }
}
