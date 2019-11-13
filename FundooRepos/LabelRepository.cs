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

        public Task Add(LabelModel labelModel)
        {
            ////Perform action on Data source
            context.Labels.Add(labelModel);
            ////Execute query and save any changes in DBcontext UserContext
            return Task.Run(() => context.SaveChanges());
        }

       

        public Task Delete(string id)
        {
            context.Labels.Remove(context.Labels.Find(id));
            ////Execute query and save any changes in DBcontext UserContext
            return Task.Run(() => context.SaveChanges());
        }

        public Task Get()
        {
            return Task.Run(() => context.Labels);
        }

        public Task<List<LabelModel>> GetByID(string id)
        {
            List<LabelModel> labelList = new List<LabelModel>();

            labelList = (from label in context.Labels
                         where label.USEREMAIL == id
                         select new LabelModel()
                         {
                             LABELID=label.LABELID,
                             LABEL=label.LABEL,
                             USEREMAIL=label.USEREMAIL
                         }
                         ).ToList();

            return Task.Run(() => labelList);


        }

        public Task Update(string id, string label)
        {
            context.Labels.Find(id).LABEL = label;
            return Task.Run(() => context.SaveChanges());
        }
    }
}
