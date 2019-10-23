// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Anagram.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Runtime.CompilerServices;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    class ThreadSafeSingleton
    {
        internal class ThreadSafeSingletonUsingSynchronization
        {
            private static ThreadSafeSingletonUsingSynchronization instance;

            private ThreadSafeSingletonUsingSynchronization() { }

            /// <summary>
            /// GPA To Create object.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.Synchronized)]
            public static ThreadSafeSingletonUsingSynchronization GetInstanceBySynchronization()
            {
                if (instance == null)
                {
                    instance = new ThreadSafeSingletonUsingSynchronization();
                }
                return instance;
            }
        }

        internal class ThreadSafeSingletonUsingLock
        {
            private static ThreadSafeSingletonUsingLock instance;
            private static readonly object padlock = new object();

            private ThreadSafeSingletonUsingLock() { }

            public static ThreadSafeSingletonUsingLock Instance
            {
                get
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafeSingletonUsingLock();
                        }
                        return instance;
                    }
                }
            }
        }




        internal class ThreadSafeSingletonUsingDoubleLock
        {
            ThreadSafeSingletonUsingDoubleLock()
            {

            }
            private static readonly object padlock = new object();
            private static ThreadSafeSingletonUsingDoubleLock instance = null;
            public static ThreadSafeSingletonUsingDoubleLock Instance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (padlock)
                        {
                            if (instance == null)
                            {
                                instance = new ThreadSafeSingletonUsingDoubleLock();
                            }
                        }
                    }
                    return instance;
                }
            }
        }










    }
}
