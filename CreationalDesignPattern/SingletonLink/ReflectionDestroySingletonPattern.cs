using System;
using System.Reflection;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    class ReflectionDestroySingletonPattern
    {

        public static void ReflectAndDestroySingleton()
        {
            Type EagerInitializationReflection = typeof(EagerInitialization);

            MethodInfo EagerInitialization = EagerInitializationReflection.GetMethod("EagerInitialization",
            new Type[] { });





        }

        public static void DestroySingletonUsingReflection()
        {
            EagerInitialization instanceOne = EagerInitialization.GetInstance();
            EagerInitialization instanceTwo = null;

            string path = @"C:\Users\Bridgelabz\source\repos\BridgeLabz\bin\Debug\netcoreapp3.0\Bridgelabz.dll";

            ////Get the assembly from specified assembly path          
            Assembly assembly = Assembly.LoadFile(path);

            ////Getting All types(Classes) in array of TYpe
            Type[] types = assembly.GetTypes();

            foreach (var type in types)
            {
                if(type.Name == "EagerInitialization")
                {
                    ////Change the constructor from priuvate to public
                    
                    
                }
            }

        }
        public static void GetReflection()
        {
            string path = @"C:\Users\Bridgelabz\source\repos\BridgeLabz\bin\Debug\netcoreapp3.0\Bridgelabz.dll";

            ////Get the assembly from specified assembly path          
            Assembly assembly = Assembly.LoadFile(path);
            
            ////Getting All types(Classes) in array of TYpe
            Type[] types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine("...................");
                Console.WriteLine("Class:" + type.Name);
                ////Getting all method name of above class
                MethodInfo[] methods = type.GetMethods();

                foreach (var method in methods)
                {
                    Console.WriteLine("\tMethods: " + method.Name);
                    ////Getting all parameter name in same class
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var param in parameters)
                    {
                        Console.WriteLine("\tParameter: " + param.Name);
                        Console.WriteLine("\tType of Parameter: " + param.ParameterType);
                    }
                }
            }
        }
    }

}
