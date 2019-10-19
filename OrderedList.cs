// --------------------------------------------------------------------------------------------------------------------
// <copyright file=OrderedList.cs" company="Bridgelabz">
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
    /// Illustration of order list
    /// </summary>
    public class OrderedList
    {

        public static void Main(String[] args)
        {
            Utility.OrderedList<int> list = new Utility.OrderedList<int>();
            int[] arr = { 1,3,5,7,9,10 };
            ////Intializing stream to perform read and write operation
            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsWriter = new FileStream("Orderedlist.binary", FileMode.Create, FileAccess.Write);
            ////Serialization
            bf.Serialize(fsWriter,arr);
            fsWriter.Close();

            FileStream fsReader = new FileStream("Orderedlist.binary", FileMode.Open, FileAccess.Read);
            ////DeSerialization
            int[] readedNumber = (int[]) bf.Deserialize(fsReader);
            fsReader.Close();
            ////Adding in ordered list
            foreach (int NumberToAdd in readedNumber)
            {
                list.Add(NumberToAdd);
            }





            //finally add the updated list to file
            StreamWriter Fsw = new StreamWriter("FinalOrderedList");

            Fsw.Write(list);
            Fsw.Close();





        }

    }
}
