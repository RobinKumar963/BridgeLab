// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------

using BusinessManager.Interface;
using Common.Constants;
using Common.Helper;
using Common.Helper.Bucket;
using Common.Models.CollabratorModels;
using Common.Models.LabelledNoteModels;
using Common.Models.NoteModels;
using Common.Models.UserModels;
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
        private readonly ILabelRepository labelRepository;

        public NoteManager(INoteRepository repository,IAccountRepository accountRepository,ILabelRepository labelRepository)
        {
            this.repository = repository;
            this.accountRepository = accountRepository;
            this.labelRepository = labelRepository;
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
            ////Updating Cache
            
            //Getting Unique Id for Note
            string noteKey = accountRepository.FindByEmailAsync(noteModel.USEREMAIL).Result.USERID
                + "FundooKeepNotes";
            //Getting Current NoteModelView List from cache
            var currentNoteModelViewList= Bucket.NotesBucket.Get("localhost", noteKey);


            //Mapping current noteModel To newNoteModelView which is to be added to cache notemodelview list


            ////Configuring Mapper
            var config = new AutoMapper.MapperConfiguration(cfg => {
                cfg.CreateMap<NoteModel,NoteModelView>();
            });

            ////Using Mapper
            AutoMapper.IMapper iMapper = config.CreateMapper();
            var destination = iMapper.Map<NoteModel,NoteModelView>(noteModel);
            
            destination.LABELS = null;
            destination.COLLABRATORS = null;
            currentNoteModelViewList.Add(destination);
            Bucket.NotesBucket.Save("localhost", noteKey,currentNoteModelViewList);
            
            //var newNoteModelViews = Bucket.NotesBucket.Get("localhost", noteKey);
            
            return await Task.Run(() => "Note Added Succesfully");
        
        }

        /// <summary>
        /// Adds Label To Note
        /// </summary>
        /// <param name="labelNote"></param>
        /// <returns></returns>
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

            ////Updating Cache
            var userEmail = await this.repository.GetUserEmailByNoteID(labelNote.NOTEID);
            string noteKey = accountRepository.FindByEmailAsync(userEmail).Result.USERID + "FundooKeepNotes";
            //var res = this.repository.GetByID(userEmail);
            var res = Bucket.NotesBucket.Get("localhost", noteKey);
            foreach(NoteModelView noteModelView in res)
            {
                if (noteModelView.NOTEID == labelNote.NOTEID)
                    noteModelView.LABELS.Add(await this.labelRepository.GetLabelNameByLabelID(labelNote.LABELID));
            }
            Bucket.NotesBucket.Save("localhost", noteKey, res);

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






            ////Updating Cache
            var userEmail = await this.repository.GetUserEmailByNoteID(collabratorModel.NOTEID);
            string noteKey = accountRepository.FindByEmailAsync(userEmail).Result.USERID + "FundooKeepNotes";
            //var res = this.repository.GetByID(userEmail);
            var res = Bucket.NotesBucket.Get("localhost", noteKey);
            foreach (NoteModelView noteModelView in res)
            {
                if (noteModelView.NOTEID == collabratorModel.NOTEID)
                    noteModelView.COLLABRATORS.Add(collabratorModel.RECIEVEDEMAIL);
            }
            Bucket.NotesBucket.Save("localhost", noteKey, res);
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
            
            //////Updating Cache
            //var userEmail = await this.repository.GetUserEmailByNoteID(id);
            //string noteKey = accountRepository.FindByEmailAsync(userEmail).Result.USERID + "FunKeepNotesTestsss";
            ////var res = this.repository.GetByID(userEmail);
            //var res = Bucket.NotesBucket.Get("localhost", noteKey);
            //foreach (NoteModelView noteModelView in res)
            //{
            //    if (noteModelView.NOTEID == id)
            //        noteModelView.COLLABRATORS.Add(collabratorModel.RECIEVEDEMAIL);
            //}
            //Bucket.NotesBucket.Save("localhost", noteKey, res);

            return "Image uploaded successfully ";
        }        



        public async Task<string> Updates(int id,string newValue,string attribute)
        {

            
            await this.repository.Updates(id, newValue, attribute);


            ////Updating Cache
            var userEmail = await this.repository.GetUserEmailByNoteID(id);
            string noteKey = accountRepository.FindByEmailAsync(userEmail).Result.USERID + "FundooKeepNotes";
            //var res = this.repository.GetByID(userEmail);
            var res = Bucket.NotesBucket.Get("localhost", noteKey);
            foreach (NoteModelView noteModelView in res)
            {
                if (noteModelView.NOTEID == id)
                {
                    switch (attribute)
                    {

                        case Constants.NoteDescriptionAttributeName:
                            ////Update note with Primary Key value id in data source using session(instance of DbContext)-context

                            noteModelView.DESCRIPTION = newValue;
                            break;

                        case Constants.NoteTitleAttributeName:
                            ////Update note with Primary Key value id in data source using session(instance of DbContext)-context

                            noteModelView.TITLE = newValue;
                            break;


                        case Constants.NotesPinAttributeName:
                            ////Update note with Primary Key value id in data source using session(instance of DbContext)-context

                            noteModelView.ISPIN = Convert.ToBoolean(newValue);
                            noteModelView.ISARCHIVE = false;
                            break;

                        case Constants.NotesTrashAttributeName:
                            ////Update note with Primary Key value id in data source using session(instance of DbContext)-context

                            noteModelView.ISTRASH = Convert.ToBoolean(newValue);

                            break;


                        case Constants.NotesArchiveAttributeName:
                            ////Update note with Primary Key value id in data source using session(instance of DbContext)-context

                            noteModelView.ISARCHIVE = Convert.ToBoolean(newValue);
                            noteModelView.ISPIN = false;
                            break;


                        default:
                            break;

                    }
                }
                    
            }
            Bucket.NotesBucket.Save("localhost", noteKey, res);


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
           
            string noteKey = accountRepository.FindByEmailAsync(email).Result.USERID+ "FundooKeepNotes";
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

            ////Updating Cache
            

            ////Delete cache notebucket in the below line,to be done
            return await Task.Run(() => "Note Deleted Succesfully");

        }
    }
}
