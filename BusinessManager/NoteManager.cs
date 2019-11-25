// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------


using BusinessManager.Interface;
using Common.Helper;
using Common.Helper.Bucket;
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
        private readonly IAccountRepository accountRepository;

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
        /// Upload the image.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns>string</returns>
        public async Task<string> ImageUpload(IFormFile file, int id)
        {
            await this.repository.ImageUpload(file, id);
            ////Update in cache below lines
            return "Image uploaded successfully ";
        }        
        public async Task<string> Updates<T>(int id, T newValue, string attribute)
        {
            
            await this.repository.Updates<T>(id, newValue, attribute);

            ////Update cache NoteBucket with new notesList in the below line,to be done
            
            return await Task.Run(() => "Notes Updated Successfully");
        }

        /// <summary>
        /// Gets all notes with Email id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task<List<NoteModel>></returns>
        public async Task<List<NoteModelView>> GetByID(string email)
        {
            ////Using unique UserID+"Notes" for noteKey 
            var noteKey = accountRepository.FindByEmailAsync(email).Result.USERID + "Notes";
            ////Saving note in NoteBucket
            var notefromcache = Bucket.NotesBucket.Get("localhost", noteKey);

            //DeleteThis--var notefromcache = RedishCacheHelper.Get<List<NoteModelView>>("localhost", noteKey);

            if (notefromcache == null)
            {
                var res = this.repository.GetByID(email);

                Bucket.NotesBucket.Save("localhost", noteKey, res.Result);
                //DeleteThis--RedishCacheHelper.Save<List<NoteModelView>>("localhost", noteKey,res.Result);
                return await Task.Run(() => res);
            }

            return await Task.Run(() => notefromcache);
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
            ////Delete cache notebucket in the below line,to be done
            return await Task.Run(() => "Note Deleted Succesfully");

        }
    }
}
