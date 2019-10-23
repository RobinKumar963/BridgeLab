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
    public interface Abstraction
    {
        public void LoadService();
        public void ExecService();
        public void RemoveService();
    }
}
