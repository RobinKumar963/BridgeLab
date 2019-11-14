// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------


using BusinessManager.Interface;
using Common.Models.NoteModels;
using FundooRepos.Interface;
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

      

        public async Task<string> Delete(int id)
        {
            await this.repository.Delete(id);
            return await Task.Run(() => "Note Deleted Succesfully");

        }

        public async Task<string> Get()
        {

            var res= this.repository.Get();
            if(res!=null)
                return await Task.Run(() => "Successfull");
            else
                return await Task.Run(() => "Failure");



        }

        public async Task<List<NoteModel>> GetByID(string id)
        {
            var res = this.repository.GetByID(id);
            return await Task.Run(() => res);
            
        }

        public async Task<string> Update(int id,string description)
        {
            await this.repository.Update(id,description);
            return "Note Updated Succesfully";

        }
    }
}
