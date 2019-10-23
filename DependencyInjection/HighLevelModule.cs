// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HighLevelModule.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.DependencyInjection
{
    public class HighLevelModule
    {
        Abstraction highLevelModuleAbstraction;
        public HighLevelModule()
        {
            this.highLevelModuleAbstraction = new LowLevelModule();
        }
        /// <summary>
        /// Constructor Injection<see cref="HighLevelModule"/> class.
        /// </summary>
        /// <param name="highLevelModuleAbstraction">The high level module abstraction.</param>
        public HighLevelModule(Abstraction highLevelModuleAbstraction)
        {
            this.highLevelModuleAbstraction = highLevelModuleAbstraction;
        }

        public void ExecService()
        {
            highLevelModuleAbstraction.ExecService();
        }

        public void LoadService()
        {
            highLevelModuleAbstraction.LoadService();
        }
    }
}
