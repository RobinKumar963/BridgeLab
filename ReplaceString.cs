// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ReplaceString.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------




using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.FunctionalProgram
{
    /// <summary>
    /// Replace Template <<Username>>,with username accepted by User
    /// </summary>
    class ReplaceString
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {
            String Template = "Hello <Username>,How are you?";
            while(true)
            {
                Console.WriteLine("Enter username");
                String username = Console.ReadLine();

                if (username.Length < 3)
                {
                    Console.WriteLine("Username should be  of minimum 3 character...........Enter any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine(Template.Replace("<Username>", username));

                    break;

                }
                
            }
           
        }
    }
}
