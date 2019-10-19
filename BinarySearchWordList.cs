// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BinarySearchWordList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------






using System;
using System.IO;

namespace Bridgelabz.Algorithm
{
    /// <summary>
    /// Take words from a list and check if any matches with word entered by user
    /// </summary>
    public class BinarySearchWordList
    {

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
	    {

            
            ////Uses StreamWriter To Create file and write to it
            StreamWriter sw = new StreamWriter("binarysearchword.txt");
            String wordsToWrite = "Wholeness achieved by Nothingness";
            sw.WriteLine(wordsToWrite);
            sw.Close();



            ////Uses StringReader To Read words from file
            StreamReader sr = new StreamReader("binarySearchWord.txt");
            String[] words = null;
		    String s;
		    ////Taking word to be matched as input from user through console
		    Console.WriteLine("Enter keyword to be searched:");
		    String key = Console.ReadLine();
		    
		    int found = 0;int comparisonResult;
            ////Reading each line in String s
		    while((s=sr.ReadLine())!=null)
		    {
                ////splitting Read line into array of words
			    words = s.Split(" ");
                ////displaying read words from file
                Console.WriteLine("Words in file:\n");Utility.PrintArray(words);
                ////Applying insertion sort to implement binary search on words[]
			    Utility.GenericinsertionSort(words);
			    int low = 0,high = words.Length -1,m;
                
			    ////Applying Binary Search on Words

			    while(low<=high)
			    {
				    m = (low + high)/2;
				    comparisonResult = key.CompareTo(words[m]);
				    if(comparisonResult == 0)
				    {
					    found = 1;
					    break;
				    }
				    else if(comparisonResult > 0)
					    low = m + 1;
				    else
					    high = m - 1;

			    }

		    }
		if(found != 0)
		
			Console.WriteLine("\nThe given word is present  in the file");
		
		else
		
			Console.WriteLine("\nThe given word is not present in the file");
		

		sr.Close();

    
	}
    

}
   
    }


