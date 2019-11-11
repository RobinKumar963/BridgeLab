﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Encryption.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Common.Helper
{
    /// <summary>
    /// Helps with encryption
    /// </summary>
    public class Encryption
    {
        /// <summary>
        /// MD5 irreversible hash algorithm
        /// </summary>
        /// <param name="text"></param>
        /// <returns>string</returns>
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            ////compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            ////get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                ////change it into 2 hexadecimal digits  
                ////for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
