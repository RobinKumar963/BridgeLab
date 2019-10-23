// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ReflectionDestroySingletonPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Reflection;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    class ReflectionDestroySingletonPattern
    {

        public static void ReflectAndDestroySingleton()
        {
            Type ReflectedEagerInitialization = typeof(EagerInitialization);

            ConstructorInfo[] constructors = ReflectedEagerInitialization.GetConstructors();
            

            foreach(ConstructorInfo constructor in constructors)
            {
                ////Make all constructor public(Private constructor become public)
                
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
