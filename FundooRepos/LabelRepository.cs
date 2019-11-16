// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------

using Common.Models.LabelModels;
using Common.Models.NoteModels;
using FundooRepos.Context;
using FundooRepos.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace FundooRepos
{
    /// <summary>
    /// LabelRepository to get data from data source
    /// </summary>
    /// <seealso cref="FundooRepos.Interface.INoteRepository" />
    public class LabelRepository : ILabelRepository
    {
        private readonly UserContext context;

        public LabelRepository(UserContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adds the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns>Task</returns>
        public Task Add(LabelModel labelModel)
        {
            ////Adding label to data source using session(instance of DbContext)-context
            context.Labels.Add(labelModel);
            ////Save Context Changes task queued to run on thread pool
            return Task.Run(() => context.SaveChanges());
        }


        /// <summary>
        /// Deletes the Label with specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task</returns>
        public Task Delete(int id)
        {
            ////Removing label from data source with primary key value id using session(instance of DbContext)-context
            context.Labels.Remove(context.Labels.Find(id));
            ////Save Context Changes task queued to run on thread pool
            return Task.Run(() => context.SaveChanges());
        }

        /// <summary>
        /// Gets  all label from Label table in Data source.
        /// </summary>
        /// <returns></returns>
        public Task Get()
        {
            ////return task of all labels queued to run on thread pool
            return Task.Run(() => context.Labels);
        }

        /// <summary>
        /// Gets Label  by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task<List<LabelModel>></returns>
        public Task<List<LabelModel>> GetByID(string id)
        {
            List<LabelModel> labelList = new List<LabelModel>();
            ////Getting label with USEREMAIL==id from data source using session(instance of DbContext)-context
            labelList = (from label in context.Labels
                         where label.USEREMAIL == id
                         select new LabelModel()
                         {
                             LABELID=label.LABELID,
                             LABEL=label.LABEL,
                             USEREMAIL=label.USEREMAIL
                         }
                         ).ToList();
            ////return task of all labels of a user queued to run on thread pool
            return Task.Run(() => labelList);


        }
        
        /// <summary>
        /// Updates the Label with specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="label">The label.</param>
        /// <returns>Task</returns>
        public Task Update(int id, string label)
        {
            ////Update Label with Primary Key value id in data source using session(instance of DbContext)-context
            context.Labels.Find(id).LABEL = label;
            ////Save Context Changes task queued to run on thread pool
            return Task.Run(() => context.SaveChanges());
        }
    }
}
