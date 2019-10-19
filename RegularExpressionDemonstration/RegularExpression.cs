// --------------------------------------------------------------------------------------------------------------------
// <copyright file=RegularExpression.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------




using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Bridgelabz.ObjectOriented.RegularExpressionDemonstration
{
    class RegularExpression
    {
        public static void Main(String[] args)
        {
            String message = "Hello <Username>,We have your full name as <<FullUsername>> in our system.\n" +
            "Your contact number is 91-9916022165.Please, let us know in case of any clarification.\n" +
            "Thank you BridgeLabz 01/01/2016.\n";

            String namePattern = @"<[a-zA-Z]+>";
            String fullNamePattern = @"[<<][a-zA-Z]+[>>]";
            String phonePattern = @"91-[0-9]{10,10}";
            String datePattern = @"0?[1-31]/0?[1-31]/[1-9][0-9][0-9][0-9]";


            String MyName = "Robin";    
            String MyFullName = "Robin kumar";
            String MyNumber = "91-9916022167";
            String CurDate = DateTime.Today.ToString();
            Console.WriteLine("Readed Message:");
            //Console.WriteLine(message);
            
            Regex name = new Regex(namePattern);
            message = name.Replace(message,MyName);
            //Console.WriteLine("\n" + message);

            Regex fullName = new Regex(fullNamePattern);
            message = fullName.Replace(message, MyFullName);
            //Console.WriteLine("\n" + message);

            Regex phone = new Regex(phonePattern);
            message = phone.Replace(message, MyNumber);
            //Console.WriteLine("\n" + message);

            Regex date = new Regex(datePattern);
            message = date.Replace(message, CurDate);
            Console.WriteLine("\n" + message);



            




        }

        


    }
}
