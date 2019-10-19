// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UnOrderedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.IO;

namespace Bridgelabz.DataStructure
{
    /// <summary>
    /// Illustration of OrderList
    /// </summary>
    public class UnOrderedList
    {

        public static void Main(String[] args)
        {
            Utility.UnOrderedList<String> list = new Utility.UnOrderedList<String>(); 
            ////Using StreamWriter to wtite into file
            StreamWriter sw = new StreamWriter("UnOrderedList");
            String wordsToWrite = "Wholeness achieved by Nothingness";
            sw.Write(wordsToWrite);
            sw.Close();

            ////Read the Text from above created file,split it into words and arrange it as Linked List
            StreamReader sr = new StreamReader("UnOrderedList");
            String[] words = null;
            String readedText;
            
            ////Reading each line in String readedText
            while ((readedText = sr.ReadLine()) != null)
            {
                
                words = readedText.Split(" ");
                foreach(String wordToAdd in words)
                {
                    list.Add(wordToAdd);
                }


            }
            sr.Close();
            ////Taking word to be matched as input from user through console
            
            Console.WriteLine("Enter keyword to be searched:");
            String key = Console.ReadLine();
            if(list.Search(key))
            {
                list.Remove(key);
            }
            else
            {
                list.Add(key);
            }





            ////finally add the updated list to file
            StreamWriter Fsw = new StreamWriter("FinalUnOrderedList");
            
            Fsw.Write(list);
            Fsw.Close();



        }
    }
}







