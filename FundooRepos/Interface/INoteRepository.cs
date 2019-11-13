// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INoteRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------



using Common.Models.NoteModels;
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
        Task<List<NoteModel>> GetByID(string id);
        Task Delete(string id);
        Task Update(string id,string notes);
       
    }
}
