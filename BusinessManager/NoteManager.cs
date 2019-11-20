﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------


using BusinessManager.Interface;
using Common.Helper;
using Common.Models.CollabratorModels;
using Common.Models.LabelledNoteModels;
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


        public async Task<string> Add(LabelledNote labelNote)
        {
            ////Creating a context object
            var context = new ValidationContext(labelNote, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(labelNote, context, validresult, true);

            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await this.repository.Add(labelNote);
            return await Task.Run(() => "Label added to note Succesfully");
        }

        /// <summary>
        /// Adds the specified collabrator model to the note.
        /// </summary>
        /// <param name="collabratorModel">The collabrator model.</param>
        /// <returns>Task<string></returns>
        /// <exception cref="ArgumentException">Invalid Parameter</exception>
        public async Task<string> Add(CollabratorModel collabratorModel)
        {
            ////Creating a context object
            var context = new ValidationContext(collabratorModel, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(collabratorModel, context, validresult, true);

            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await this.repository.Add(collabratorModel);
            return await Task.Run(() => "Collabrator added to notes Succesfully");
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
        public async Task<List<NoteModelView>> GetByID(string email)
        {
            var noteKey = "note";

            Task<List<NoteModelView>> notefromcache = RedishCacheHelper.Get<Task<List<NoteModelView>>>("localhost", noteKey);

            if(notefromcache==null)
            {
                var res = this.repository.GetByID(email);
                RedishCacheHelper.Save<Task<List<NoteModelView>>>("localhost", noteKey,res);
                return await Task.Run(() => res);
            }

            return await Task.Run(() => notefromcache);




        }

        /// <summary>
        /// Gets the archive notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>Task<List<NoteModelView></returns>
        public async Task<List<NoteModelView>> GetArchiveNotes(string email)
        {
            var archivenoteKey = "archivenotekey";

            Task<List<NoteModelView>> notefromcache = RedishCacheHelper.Get<Task<List<NoteModelView>>>("localhost", archivenoteKey);

            if (notefromcache == null)
            {
                var res = this.repository.GetArchiveNotes(email);
                RedishCacheHelper.Save<Task<List<NoteModelView>>>("localhost", archivenoteKey, res);
                return await Task.Run(() => res);
            }

            return await Task.Run(() => notefromcache);
        }

        /// <summary>
        /// Gets the trash notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>Task<List<NoteModelView>></returns>
        public async Task<List<NoteModelView>> GetTrashNotes(string email)
        {

            var trashnoteKey = "trashnotekey";

            Task<List<NoteModelView>> notefromcache = RedishCacheHelper.Get<Task<List<NoteModelView>>>("localhost", trashnoteKey);

            if (notefromcache == null)
            {
                var res = this.repository.GetTrashNotes(email);
                RedishCacheHelper.Save<Task<List<NoteModelView>>>("localhost", trashnoteKey, res);
                return await Task.Run(() => res);
            }

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
            this.repository.ImageUpload(file, id);
            //return await Task.Run(() => result);
            return "Image uploaded successfully ";
        }

       
    }
}
