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
    public class LabelManager : ILabelManager
    {
        private readonly  ILabelRepository repository;

        public LabelManager(ILabelRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adds the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns>Task</returns>
        /// <exception cref="ArgumentException">Invalid Parameter</exception>
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


            return await Task.Run(() => "Label Added Succesfully");
        }


        /// <summary>
        /// Deletes the label with specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task<string></returns>
        public async Task<string> Delete(int id)
        {
            await this.repository.Delete(id);
            return await Task.Run(() => "Label Deleted Succesfully");
        }

        /// <summary>
        /// Get all labels.
        /// </summary>
        /// <returns>Task<string></returns>
        public async Task<string> Get()
        {
            var res = this.repository.Get();
            if (res != null)
                return await Task.Run(() => "Successfull");
            else
                return await Task.Run(() => "Failure");
        }

        /// <summary>
        /// Gets labels by identifier label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<List<LabelModel>> GetByID(string email)
        {
            var res = this.repository.GetByID(email);
            return await Task.Run(() => res);
        }

        /// <summary>
        /// Updates the label with specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="label">The label.</param>
        /// <returns></returns>
        public async Task<string> Update(int id, string label)
        {
            await this.repository.Update(id, label);
            return "label Updated Succesfully";
        }
    }
}
