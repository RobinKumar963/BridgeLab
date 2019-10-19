// --------------------------------------------------------------------------------------------------------------------
// <copyright file=RangedPrimeNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DataStructure
{
    /// <summary>
    /// Prime nNumber of 1 - 1000
    /// </summary>
    class RangedPrimeNumber
    {
        public static void Main(String[] args)
        {
            
            int range = 1000;
            Nullable<int>[,] prime_Number = new Nullable<int>[range / 100, range / 10];


            ////Checking 0-100,100-200.....,900-1000 which are prime
            for (int i = 0; i < range/100; i++)
            {
                for (int j = 100 * i, ind =0; ind < range/10; j++ , ind++)
                {

                    if (Algorithm.Utility.CheckPrime(j))
                    {
                        prime_Number[i, ind] = j;
                    }
                    else
                        prime_Number[i, ind] = null;
                        

                }
                
            }
            Algorithm.Utility.Print2DimensionArray(prime_Number, range / 100, range / 10);



        }


    }
}


