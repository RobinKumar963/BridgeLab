// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DependencyInjectionTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.DependencyInjection
{
    class DependencyInjectionTest
    {
       public static void Main(String[] args)
        {
            ////Dependency Injection
            HighLevelModule highLevelmodule = new HighLevelModule(new LowLevelModule());
            highLevelmodule.LoadService();
            highLevelmodule.ExecService();
        }
        
    }
}
