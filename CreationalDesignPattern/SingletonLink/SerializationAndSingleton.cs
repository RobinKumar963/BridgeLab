using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    class SerializationAndSingleton
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

    }
}
