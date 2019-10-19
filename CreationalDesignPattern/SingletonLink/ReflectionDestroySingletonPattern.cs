using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    class ReflectionDestroySingletonPattern
    {
        public static void main(String[] args)
        {
            EagerInitialization instanceA = EagerInitialization.GetInstance();
            EagerInitialization instanceB = null;
            try
            {
                Constructor[] constructors = EagerInitializedSingleton.class.getDeclaredConstructors();
                for (Constructor constructor : constructors) {
                //Below code will destroy the singleton pattern
                constructor.setAccessible(true);
                instanceTwo = (EagerInitializedSingleton) constructor.newInstance();
                break;
            }
            } catch (Exception e) 
            {
            e.printStackTrace();
            }
            System.out.println(instanceOne.hashCode());
            System.out.println(instanceTwo.hashCode());
       }


    }
}
