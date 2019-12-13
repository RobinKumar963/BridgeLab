// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ILabelRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------



using Common.Models.LabelModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepos.Interface
{
    /// <summary>
    /// Contract for LabelRepository
    /// </summary>
    public interface ILabelRepository
    {
        Task Add(LabelModel labelModel);

        Task Updates(int id, string newValue, string attribute);

        Task<List<LabelModel>> GetByID(string email);
        
        Task Delete(int id);
    }
}
