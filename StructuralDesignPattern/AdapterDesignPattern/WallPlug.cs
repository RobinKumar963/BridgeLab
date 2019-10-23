// --------------------------------------------------------------------------------------------------------------------
// <copyright file=WallPlug.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    class WallPlug : MobileChargerSocket
    {
        public Voltage GetVolt()
        {
            return new Voltage(120);
        }
    }
}
