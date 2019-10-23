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
            EagerInitialization obj1 = EagerInitialization.GetInstance();
            EagerInitialization obj2 = EagerInitialization.GetInstance();
            EagerInitialization obj3;
            Type ReflectedEagerInitialization = typeof(EagerInitialization);
            MethodInfo ReflectedGetInstance = ReflectedEagerInitialization.GetMethod("GetInstance()");
            
            ConstructorInfo[] constructors = ReflectedEagerInitialization.GetConstructors();
            

            foreach(ConstructorInfo constructor in constructors)
            {
                ////Make all constructor public(Private constructor become public)
                ////Alternatively,Just invoke the private constructor
                ////This will set the instance of singleton class
                ////Defined inside singleton class with a new one   
                if (constructor.IsPrivate)
                   constructor.Invoke();

            }
            ////On intializing instance of Singleton Class with new one
            ////Invoke,
            obj3 = ReflectedGetInstance.Invoke();


            Console.WriteLine("Instance1 without reflection" + obj1.GetHashCode());
            Console.WriteLine("Instance 2 without reflection" + obj2.GetHashCode());
            Console.WriteLine("Instance without reflection" + obj3.GetHashCode());


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
