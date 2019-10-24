// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DB.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.FacadeDesignPattern
{
    /// <summary>
    /// Contract for super interface
    /// </summary>
    interface DB
    {
        public Connection GetConnection();
        public void GenerateHTMLReport();
        public void GeneratePDFReport();
    }
}
