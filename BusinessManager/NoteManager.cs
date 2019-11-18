// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------


using BusinessManager.Interface;
using Common.Helper;
using Common.Models.NoteModels;
using FundooRepos.Interface;
using Microsoft.AspNetCore.Http;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager
{
    /// <summary>
    /// Implementation of NoteManager
    /// </summary>
    /// <seealso cref="BusinessManager.Interface.INoteManager" />
    public class NoteManager : INoteManager
    {
        private readonly INoteRepository repository;

        public NoteManager(INoteRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adds the specified note model.
        /// </summary>
        /// <param name="noteModel">The note model.</param>
        /// <returns>Task<string></returns>
        /// <exception cref="ArgumentException">Invalid Parameter</exception>
        public async Task<string> Add(NoteModel noteModel)
        {
            ////Creating a context object
            var context = new ValidationContext(noteModel, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(noteModel, context, validresult, true);

            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await this.repository.Add(noteModel);
            return await Task.Run(() => "Note Added Succesfully"); 
        }


        /// <summary>
        /// Deletes the note model with specified identifier.
        /// </summary>
        /// <param name="noteModel">The note model.</param>
        /// <returns>Task<string></returns>
        /// <exception cref="ArgumentException">Invalid Parameter</exception>
        public async Task<string> Delete(int id)
        {
            await this.repository.Delete(id);
            return await Task.Run(() => "Note Deleted Succesfully");

        }

        /// <summary>
        /// Gets all Notes.
        /// </summary>
        /// <returns></returns>
        public async Task<string> Get()
        {
            var res= this.repository.Get();
            if(res!=null)
                return await Task.Run(() => "Successfull");
            else
                return await Task.Run(() => "Failure");
        }

        /// <summary>
        /// Gets all notes with Email id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task<List<NoteModel>></returns>
        public async Task<List<NoteModelView>> GetByID(string id)
        {
            var noteModelKey = id;
            Task<List<NoteModelView>> notefromcache = RedishCacheHelper.Get<Task<List<NoteModelView>>>("localhost", noteModelKey);
            //var res = this.repository.GetByID(id);
            return await Task.Run(() => notefromcache);
            
        }

        /// <summary>
        /// Updates the Notes with specified identifier id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="description">The description.</param>
        /// <returns></returns>
        public async Task<string> Update(int id,string description)
        {
            await this.repository.Update(id,description);
            return "Note Updated Succesfully";

        }

        /// <summary>
        /// Upload the image.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns>string</returns>
        public  string ImageUpload(IFormFile file, int id)
        {
            var result = this.repository.ImageUpload(file, id);
            //return await Task.Run(() => result);
            return "Image uploaded successfully ";
        }

        public async Task<List<NoteModelView>> GetArchiveNotes(string email)
        {
            var noteModelKey = email;
            Task<List<NoteModelView>> notefromcache = RedishCacheHelper.Get<Task<List<NoteModelView>>>("localhost", noteModelKey);
            //var res = this.repository.GetByID(id);
            return await Task.Run(() => notefromcache);
        }

        public async Task<List<NoteModelView>> GetTrashNotes(string email)
        {
            var noteModelKey = email;
            Task<List<NoteModelView>> notefromcache = RedishCacheHelper.Get<Task<List<NoteModelView>>>("localhost", noteModelKey);
            //var res = this.repository.GetByID(id);
            return await Task.Run(() => notefromcache);
        }
    }
}
