// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------


using BusinessManager.Interface;
using Common.Models.NoteModels;
using FundooRepos.Interface;
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
            return "Note Added Succesfully";
        }

        public Task<bool> check(string email)
        {
              var res = this.repository.check(email);
              if(res==null)
                return Task.Run(() => false);
            return Task.Run(() => true);

        }

        public async Task<string> Delete(string id)
        {
            await this.repository.Delete(id);
            return "Note Delete Succesfully";

        }

        public async Task<string> Get()
        {
            await this.repository.Get();
            return  "results";
        }

        public async Task<string> GetByID(string id)
        {
            await this.repository.GetByID(id);
            return "Note returned Succesfully";
        }

        public async Task<string> Update(string id,string description)
        {
            await this.repository.Update(id,description);
            return "Note Updated Succesfully";

        }
    }
}
