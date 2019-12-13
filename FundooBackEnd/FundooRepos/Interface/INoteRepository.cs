// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INoteRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------



using Common.Models.CollabratorModels;
using Common.Models.LabelledNoteModels;
using Common.Models.NoteModels;
using Microsoft.AspNetCore.Http;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepos.Interface
{
    /// <summary>
    /// Contract for NoteRepository
    /// </summary>
    public interface INoteRepository
    {
        Task Add(NoteModel noteModel);
        Task Add(CollabratorModel collabratorModel);
        Task Add(LabelledNote labelNote);
        
        Task ImageUpload(IFormFile file, int id);
        Task Updates(int id, string newValue, string attribute);
        
        Task<List<NoteModelView>> GetByID(string email);
        
        Task Delete(int id);
        
    }
}
