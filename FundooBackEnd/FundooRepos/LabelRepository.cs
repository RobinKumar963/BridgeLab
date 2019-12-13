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
using Common.Constants;

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
        /// Updated update operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="newValue"></param>
        /// <param name="attribute"></param>
        /// <returns>Task</returns>
        public Task Updates(int id, string newValue, string attribute)
        {



            switch (attribute)
            {

                case Constants.LabelNameAttributeName:
                    ////Update note with Primary Key value id in data source using session(instance of DbContext)-context

                    context.Labels.Find(id).LABEL = newValue;
                    return Task.Run(() => context.SaveChanges());

              

                default:
                    break;

            }

            ////Save Context Changes task queued to run on thread pool
            return Task.Run(() => context.SaveChanges());
        }

        /// <summary>
        /// Gets Label  by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task<List<LabelModel>></returns>
        public Task<List<LabelModel>> GetByID(string email)
        {
            List<LabelModel> labelList = new List<LabelModel>();
            ////Getting label with USEREMAIL==id from data source using session(instance of DbContext)-context
            labelList = (from label in context.Labels
                         where label.USEREMAIL == email
                         select new LabelModel()
                         {
                             LABELID = label.LABELID,
                             LABEL = label.LABEL,
                             USEREMAIL = label.USEREMAIL
                         }
                         ).ToList();
            ////return task of all labels of a user queued to run on thread pool
            return Task.Run(() => labelList);


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
    
    }
}
