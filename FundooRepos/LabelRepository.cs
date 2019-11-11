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

        public Task check(string email)
        {
            var result = context.Notes.Find(email);
            return Task.Run(() => result);
        }

        public Task Delete(string id)
        {
            context.Labels.Remove(context.Labels.Find(id));
            ////Execute query and save any changes in DBcontext UserContext
            return Task.Run(() => context.SaveChanges());
        }

        public Task Get()
        {

            var list = context.Labels;
            return Task.Run(() => list);
        }

        public Task GetByID(string id)
        {
            LabelModel label = context.Labels.Find(id);
            return Task.Run(() => label);
        }

        public Task Update(string id, string label)
        {
            context.Labels.Find(id).LABEL = label;
            return Task.Run(() => context.SaveChanges());
        }
    }
}
