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
using Autofac;

namespace FundooRepos
{

   

    /// <summary>
    /// Note Repository,to set and get from data source for note entity
    /// </summary>
    /// <seealso cref="FundooRepos.Interface.INoteRepository" />
    public class NoteRepository : INoteRepository
    {

        private readonly  UserContext context;

        public NoteRepository(UserContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adds the specified note model.
        /// </summary>
        /// <param name="noteModel">The note model.</param>
        /// <returns>Task</returns>
        public Task Add(NoteModel noteModel)
        {
            ////Adding note to data source using session(instance of DbContext)-context 
            context.Notes.Add(noteModel);
            ////Save Context Changes task queued to run on thread pool
            return Task.Run(() => context.SaveChanges());

        }

        /// <summary>
        /// Deletes the note with specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task</returns>
        public Task Delete(int id)
        {
            ////Removing note from data source with primary key value id using session(instance of DbContext)-context
            context.Notes.Remove(context.Notes.Find(id));
            ////Save Context Changes task queued to run on thread pool
            return Task.Run(() => context.SaveChanges());
        }
        /// <summary>
        /// Gets all notes from Notes table in Data Source.
        /// </summary>
        /// <returns>Task</returns>
        public Task Get()
        {
            ////return task of all notes queued to run on thread pool
            return Task.Run(() => context.Notes);
        }
        /// <summary>
        /// Gets the Notes by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task<List<NoteModel>></returns>
        public Task<List<NoteModel>> GetByID(string id)
        {
            List<NoteModel> notesList = new List<NoteModel>();
            ////Getting note with USEREMAIL==id from data source using session(instance of DbContext)-context 
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
            ////return task of all notes of a user queued to run on thread pool
            return Task.Run(() => notesList);
        }
        /// <summary>
        /// Updates the note with specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="des">The DES.</param>
        /// <returns>Task</returns>
        public Task Update(int id,string des)
        {
            ////Update note with Primary Key value id in data source using session(instance of DbContext)-context
            context.Notes.Find(id).DESCRIPTION = des;
            ////Save Context Changes task queued to run on thread pool
            return Task.Run(() => context.SaveChanges());
        }




      



    }
}
