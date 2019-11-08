using Common.Models.NoteModels;
using FundooRepos.Context;
using FundooRepos.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepos
{
    public class NoteRepository : INoteRepository
    {

        private readonly UserContext context;

        public NoteRepository(UserContext context)
        {
            this.context = context;
        }


        public Task Add(NoteModel noteModel)
        {
           
            context.Notes.Add(noteModel);
            ////Execute query and save any changes in DBcontext UserContext
            return Task.Run(() => context.SaveChanges());

        }

        public Task Delete(string id)
        {
            context.Notes.Remove(context.Notes.Find(id));
            ////Execute query and save any changes in DBcontext UserContext
            return Task.Run(() => context.SaveChanges());
        }

        public Task Get()
        {
            List<NoteModel> list = new List<NoteModel>();
            list = context.Notes;
            return Task.Run(() => context.SaveChanges());
        }

        public Task GetByID()
        {
            NoteModel note = context.Notes.Find();
            return Task.Run(() => context.SaveChanges());
        }

        public Task Update(string id)
        {
            return Task.Run(() => context.SaveChanges());
        }
    }
}
