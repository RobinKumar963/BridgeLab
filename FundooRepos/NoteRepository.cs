// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------
using Common.Models.NoteModels;
using FundooRepos.Context;
using FundooRepos.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace FundooRepos
{
    /// <summary>
    /// Note Repository,to set and get from data source for note entity
    /// </summary>
    /// <seealso cref="FundooRepos.Interface.INoteRepository" />
    public class NoteRepository : INoteRepository
    {

  
        private readonly UserContext context;

        public NoteRepository(UserContext context)
        {
            this.context = context;
        }


        public Task Add(NoteModel noteModel)
        {
            ////Perform action on Data source
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
            var list = context.Notes;
            
            return Task.Run(() => list);

        }

        public Task<NoteModel> GetByID(string id)
        {
            NoteModel note = context.Notes.Find(id);
            return Task.Run(() => note);
        }

        public Task Update(string id,string label)
        {
            context.Labels.Find(id).LABEL = label;
            return Task.Run(() => context.SaveChanges());
        }

       
    }
}
