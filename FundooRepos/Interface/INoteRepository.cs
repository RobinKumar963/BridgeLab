// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INoteRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------



using Common.Models.CollabratorModels;
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
        
        Task Get();
        Task Add(NoteModel noteModel);
        Task Add(CollabratorModel collabratorModel);
        

        Task<List<CollabratedNotes>> GetCollbrationNotes(string email);
        Task<List<NoteModel>> GetByID(string id);
        Task<List<NoteModel>> GetArchiveNotes(string email);
        Task<List<NoteModel>> GetTrashNotes(string email);
       
        Task Delete(int id);
        Task Update(int id,string notes);
        Task ImageUpload(IFormFile file, int id, string Email);


    }
}
