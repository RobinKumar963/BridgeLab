using BusinessManager.Interface;
using Common.Models.CollabratorModels;
using Common.Models.LabelledNoteModels;
using Common.Models.NoteModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager
{
    public class NoteManagerProxy : INoteManager
    {
        public Task<string> Add(NoteModel noteModel)
        {
            throw new NotImplementedException();
        }

        public Task<string> Add(CollabratorModel collabratorModel)
        {
            throw new NotImplementedException();
        }

        public Task<string> Add(LabelledNote labelNote)
        {
            throw new NotImplementedException();
        }

        public Task<string> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<NoteModelView>> GetByID(string email)
        {
            throw new NotImplementedException();
        }

        public Task<string> ImageUpload(IFormFile file, int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> Updates(int id, string newValue, string attribute)
        {
            throw new NotImplementedException();
        }
    }
}
