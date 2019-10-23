// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SerializationAndSingleton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System.Runtime.Serialization;


namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    class SerializationAndSingleton : ISerializable
    {
        private static  long serialVersionUID = -7604766932017737115L;

        private SerializationAndSingleton() { }

        private static class SingletonHelper
        {
            public static SerializationAndSingleton instance = new SerializationAndSingleton();
        }

        public static SerializationAndSingleton GetInstance()
        {
            return SingletonHelper.instance;
        }
        /// <summary>
        /// On,Serialization and than Deserialization different instance is obtained.
        /// </summary>
        /// <returns></returns>
        protected SerializationAndSingleton ReadResolve()
        {
            ////On,Serialization and than Deserialization(reading object from stream)different instance is obtained.
            ////This,resolves it

            return GetInstance();
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            
            
        }
    }
}
