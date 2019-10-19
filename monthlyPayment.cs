// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MonthlyPayment.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------



using System;
namespace Bridgelabz.Algorithm
{

    /// <summary>
    /// calculate monthly Payment.Uses Utility.MonthlyPayment()
    /// </summary>
    public class monthlyPayment {

        public static void Main(String[] args)
        {

            String[] argv = { "1.0", "1", "3.2" };
            Double P = Convert.ToDouble(args[0]); 

            Double Y = Convert.ToDouble(args[1]);
            Double R = Convert.ToDouble(args[2]);
            Double payment = Utility.MonthlyPayment(P, Y, R);
            Console.WriteLine(payment);
            
        }

    }
}