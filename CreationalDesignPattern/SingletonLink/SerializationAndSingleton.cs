

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

        public static SerializationAndSingleton getInstance()
        {
            return SingletonHelper.instance;
        }
        /// <summary>
        /// On,Serialization and than Deserialization different instance is obtained.
        /// </summary>
        /// <returns></returns>
        protected SerializationAndSingleton ReadResolve()
        {

            return getInstance();
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ////SingletonHelper.instance;
        }
    }
}
