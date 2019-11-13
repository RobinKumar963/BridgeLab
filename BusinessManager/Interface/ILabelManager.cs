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
        Task<string> Get();
        Task<string> Add(LabelModel noteModel);
        Task<List<LabelModel>> GetByID(string id);
        Task<string> Delete(string id);
        Task<string> Update(string id, string label);
        
    }
}
