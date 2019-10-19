// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Hashing.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bridgelabz.DataStructure
{
    /// <summary>
    /// Illustration of hashing data structure to write numbers
    /// </summary>
    public class Hashing
    {

        public static void main(String[] args)
        {
            ////Intializing Utility.Hash class
            Utility.Hash<int> hash = new Utility.Hash<int>();
            ////Intializing array whose numbers are to be stored
            int[] arr = { 1, 3, 5, 7, 9, 10 };
            ////Intializing Binary formatter to serialize arr object into .binary form
            BinaryFormatter bf = new BinaryFormatter();
            ////Intializing File stream to write serialized object in this stream
            FileStream fsWriter = new FileStream("ForHashing.binary", FileMode.Create, FileAccess.Write);
            bf.Serialize(fsWriter, arr);
            fsWriter.Close();
            ////Intializing File stream to read serialized object i.e deserialization in this stream
            FileStream fsReader = new FileStream("ForHashing.binary", FileMode.Open, FileAccess.Read);

            int[] readedNumber = (int[])bf.Deserialize(fsReader);
            fsReader.Close();
            foreach(int number in readedNumber)
            {
                hash.Add(number);
            }

            Console.WriteLine("Enter key");
            int key = Convert.ToInt32(Console.ReadLine());

            if (hash.Search(key))
                hash.Remove(key);
            else
                hash.Add(key);
            ////Intializing File stream to write serialized object in this stream
            FileStream finalsWriter = new FileStream("ForFinalHashing.binary", FileMode.Create, FileAccess.Write);

            bf.Serialize(finalsWriter, arr);
            finalsWriter.Close();


        }
    }
}