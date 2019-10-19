// --------------------------------------------------------------------------------------------------------------------
// <copyright file=GenericMethodTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------




using System;
namespace Bridgelabz.Algorithm
{
   
    public class GenericMethodTest {


        // generic method printArray
        public static  void printArray<E>(E[] inputArray) {
            // Display array elements
            foreach(E element in inputArray) {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public static void Main(String[] args) {


            // Create arrays of Integer, Double and Character
            int[] intArray = { 1, 2, 3, 4, 5 };
            Double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            String[] stringArray = { "hey", "rok", "it" };
            Console.WriteLine("Array integerArray contains:");
            printArray(intArray);   // pass an Integer array

            Console.WriteLine("\n Array doubleArray contains:");
            printArray(doubleArray);   // pass a Double array

            Console.WriteLine("\n Array characterArray contains:");
            printArray(charArray);   // pass a Character array

            Console.WriteLine("\n Array stringArray contains:");
            printArray(stringArray);   // pass a Character array







        }


    }
}
