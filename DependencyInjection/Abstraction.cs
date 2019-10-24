// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Abstraction.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.DependencyInjection
{
    /// <summary>
    /// Contract for abstraction
    /// </summary>
    public interface Abstraction
    {
        public void LoadService();
        public void ExecService();
        public void RemoveService();
    }
}
