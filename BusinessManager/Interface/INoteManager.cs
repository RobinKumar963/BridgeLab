// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INoteManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------


using Common.Models.NoteModels;
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
        Task<string> Get();
        Task<string> Add(NoteModel noteModel);
        Task<List<NoteModel>> GetByID(string id);
        Task<string> Delete(string id);
        Task<string> Update(string id,string description);
      
    }
}
