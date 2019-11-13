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
            return Task.Run(() => context.Notes);
        }

        public Task<List<NoteModel>> GetByID(string id)
        {
            List<NoteModel> notesList = new List<NoteModel>();

            notesList = (from note in context.Notes
                         where note.USEREMAIL == id && note.ISARCHIVE == false
                         && note.ISTRASH == false
                         select new NoteModel()
                         {
                             NOTEID=note.NOTEID,
                             LABELID=note.LABELID,
                             USEREMAIL=note.USEREMAIL,
                             TITLE=note.TITLE,
                             DESCRIPTION=note.DESCRIPTION,
                             CREATEDDATE=note.CREATEDDATE,
                             MODIFIEDDATA=note.MODIFIEDDATA,
                             IMAGES=note.IMAGES,
                             REMINDER=note.REMINDER,
                             ISARCHIVE=note.ISARCHIVE,
                             ISTRASH=note.ISTRASH,
                             ISPIN=note.ISPIN,
                             COLOR=note.COLOR
                         }
                         ).ToList();

            return Task.Run(() => notesList);
        }

        public Task Update(string id,string des)
        {
            context.Notes.Find(id).DESCRIPTION = des;
            return Task.Run(() => context.SaveChanges());
        }

       
    }
}
