// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MobileChargerSocket.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    /// <summary>
    /// Contract for client
    /// </summary>
    interface MobileChargerSocket
    {
        Voltage GetVolt();
    }
}
