using Common.Models.NoteModels;
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
        Task GetByID();
        Task Delete(string id);
        Task Update(string id);
    }
}
