// --------------------------------------------------------------------------------------------------------------------
// <copyright file=WallPlug.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    /// <summary>
    /// Concrete implementation of source
    /// </summary>
    /// <seealso cref="Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern.WallSocket" />
    class WallPlug : WallSocket
    {
        public Voltage GetVolt()
        {
            return new Voltage(120);
        }
    }
}
