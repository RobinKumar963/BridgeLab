// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------





using FundooRepos.Interface;
using BusinessManager.Interface;
using Common.Models.LabelModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessManager
{
    /// <summary>
    /// Manage Label
    /// </summary>
    /// <seealso cref="BusinessManager.Interface.ILabelManager" />
    class LabelManager : ILabelManager
    {
        private readonly ILabelRepository repository;

        public LabelManager(ILabelRepository repository)
        {
            this.repository = repository;
        }
        public async Task<string> Add(LabelModel labelModel)
        {
            ////Creating a context object
            var context = new ValidationContext(labelModel, null, null);
            ////To store error messages
            var validresult = new List<ValidationResult>();
            ////Running Validator
            bool isValid = Validator.TryValidateObject(labelModel, context, validresult, true);

            if (!isValid)
                throw new ArgumentException("Invalid Parameter");

            await this.repository.Add(labelModel);
            return "label Added Succesfully";
        }

        public Task<bool> check(string email)
        {
            var res = this.repository.check(email);
            if (res == null)
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
            return "results";
        }

        public async Task<string> GetByID(string id)
        {
            await this.repository.GetByID(id);
            return "Label returned Succesfully";
        }

        public async Task<string> Update(string id, string label)
        {
            await this.repository.Update(id, label);
            return "label Updated Succesfully";
        }
    }
}
