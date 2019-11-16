﻿// --------------------------------------------------------------------------------------------------------------------
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
using Microsoft.AspNetCore.Http;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Common.Models.CollabratorModels;
using Common.Helper;

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
        /// Adds the specified collabrator model.
        /// </summary>
        /// <param name="collabratorModel">The collabrator model.</param>
        /// <returns>Task</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task Add(CollabratorModel collabratorModel)
        {
            ////Adding collabrator of Note to data source using session(instance of DbContext)-context 
            context.Collabration.Add(collabratorModel);
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
        /// Gets the archived notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>Task<List<NoteModel>></returns>
        public Task<List<NoteModel>> GetArchiveNotes(string email)
        {
            List<NoteModel> notesList = new List<NoteModel>();
            ////Getting note with USEREMAIL==id and ISARCHIVE==true from data source using session(instance of DbContext)-context 
            notesList = (from note in context.Notes
                         where note.USEREMAIL == email && note.ISARCHIVE == true
                         && note.ISTRASH == false
                         select new NoteModel()
                         {
                             NOTEID = note.NOTEID,
                             USEREMAIL = note.USEREMAIL,
                             TITLE = note.TITLE,
                             DESCRIPTION = note.DESCRIPTION,
                             CREATEDDATE = note.CREATEDDATE,
                             MODIFIEDDATA = note.MODIFIEDDATA,
                             IMAGES = note.IMAGES,
                             REMINDER = note.REMINDER,
                             ISARCHIVE = note.ISARCHIVE,
                             ISTRASH = note.ISTRASH,
                             ISPIN = note.ISPIN,
                             COLOR = note.COLOR
                         }
                         ).ToList();
            ////return task of all notes of a user queued to run on thread pool
            return Task.Run(() => notesList);
        }

        /// <summary>
        /// Gets the trash notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>Task<List<NoteModel>></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<NoteModel>> GetTrashNotes(string email)
        {
            List<NoteModel> notesList = new List<NoteModel>();
            ////Getting note with USEREMAIL==id and ISARCHIVE==true from data source using session(instance of DbContext)-context 
            notesList = (from note in context.Notes
                         where note.USEREMAIL == email && note.ISARCHIVE == false
                         && note.ISTRASH == true
                         select new NoteModel()
                         {
                             NOTEID = note.NOTEID,
                             USEREMAIL = note.USEREMAIL,
                             TITLE = note.TITLE,
                             DESCRIPTION = note.DESCRIPTION,
                             CREATEDDATE = note.CREATEDDATE,
                             MODIFIEDDATA = note.MODIFIEDDATA,
                             IMAGES = note.IMAGES,
                             REMINDER = note.REMINDER,
                             ISARCHIVE = note.ISARCHIVE,
                             ISTRASH = note.ISTRASH,
                             ISPIN = note.ISPIN,
                             COLOR = note.COLOR
                         }
                         ).ToList();
            ////return task of all notes of a user queued to run on thread pool
            return Task.Run(() => notesList);
        }

        /// <summary>
        /// Gets the collbration notes.
        /// </summary>
        /// <returns>Task<List<CollabratorModel>></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<CollabratedNotes>> GetCollbrationNotes(string email)
        {
            List<CollabratorModel> collabratorModelList = new List<CollabratorModel>();
            List<CollabratedNotes> collabratedNotesList = new List<CollabratedNotes>();
          


           
            
            collabratorModelList = (from collabratedNote in context.Collabration
                                    where collabratedNote.RECIEVEDEMAIL == email
                                    select new CollabratorModel()
                                    {
                                        COLLABRATIONID=collabratedNote.COLLABRATIONID,
                                        NOTEID=collabratedNote.NOTEID,
                                        SENDEREMAIL=collabratedNote.SENDEREMAIL,
                                        RECIEVEDEMAIL=collabratedNote.RECIEVEDEMAIL
                                    }
                                    ).ToList();

            List<String> reciever = new List<String>();

            
            foreach (CollabratorModel collabratorModel in collabratorModelList)
            {
                var results = context.Notes.Where(i => i.NOTEID == collabratorModel.NOTEID).FirstOrDefault();


                reciever = (from collabrator in context.Collabration
                            where collabrator.NOTEID == collabratorModel.NOTEID
                            select new String(collabrator.RECIEVEDEMAIL)
                           
                            ).ToList();




                collabratedNotesList.Add(new CollabratedNotes()
                {
                        DESCRIPTION = results.DESCRIPTION,
                        NOTEID = results.NOTEID,
                        IMAGE = results.IMAGES,
                        SENDEREMAIL = results.USEREMAIL,
                        RECIEVEREMAIL = reciever
                });
                
                

            }

            ////return task of all notes of a user queued to run on thread pool
            return Task.Run(() => collabratedNotesList);
            












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

        /// <summary>
        /// Upload Image in cloudnary.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns>Task</returns>
        /// <exception cref="Exception"></exception>
        public Task ImageUpload(IFormFile file,int id)
        {
            
            ////Uploading image and storing the ImageUploadResult(object) in uploadResult
            var uploadresult = ImageUploader.UploadImage(file);

            ////If UploadResult property Error is not null
            ////Throws an exception
            if (uploadresult.Error != null)
                throw new Exception(uploadresult.Error.Message);

            ////Getting note with USEREMAIL==Email and NOTEID==id from data source using session(instance of DbContext)-context
            var result = context.Notes.Where(i => i.NOTEID == id).FirstOrDefault();

            ////On finding result
            if (result != null)
            {
                if (result.NOTEID.Equals(id))
                {
                    ////Setting Note field IMAGES with uploadresult url
                    result.IMAGES = uploadresult.Uri.ToString();
                    return Task.Run(() => context.SaveChanges());
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }


        


    }
}
