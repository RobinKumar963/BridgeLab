// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ILabelManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------


using Common.Models.LabelModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Interface
{
    /// <summary>
    /// Contract for LabelManager
    /// </summary>
    public interface ILabelManager
    {
        Task<string> Add(LabelModel labelModel);

        
        Task<string> Updates(int id, string newValue, string attribute);

        Task<List<LabelModel>> GetByID(string email);

        Task<string> Delete(int id);

    }
}
