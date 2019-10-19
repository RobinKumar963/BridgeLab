// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CouponNumber.cs" company="Bridgelabz">
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
    /// Generate N unique Coupon 
    /// </summary>
    class CouponNumber
    {
        /// <summary>
        /// Generates N unique coupon and calculate number of generation required for N unique number
        /// </summary>
        /// <param name="num">The number.</param>
        /// <param name="pos">The position.</param>
        /// <param name="count">The count.</param>
        /// <param name="arr">The arr.</param>
        public static void GenerateCoupon(int num, int pos, double count, int[] arr)
        {

            int uniqueCouponFound = 1;
            ////base condition
            if (pos == num)
            {
                Console.WriteLine("total generation required:" + count);
                for (int i = 0; i < num; i++)
                    Console.Write(" " + arr[i] + " ");

                return;

            }

            Random rand = new Random();
            int newCoupon = rand.Next(num + 1);

            

            for (int i = 0; i <= pos; i++)
            {
                if (arr[i] == newCoupon || newCoupon == 0)
                {
                    uniqueCouponFound = 0;
                    break;
                }

            }

            if (uniqueCouponFound == 1)
            {
                arr[pos] = newCoupon;
                GenerateCoupon(num, pos + 1, count + 1, arr);
            }
            else
                GenerateCoupon(num, pos, count + 1, arr);



        }

        public static void Main(String[] args)
        {


            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                arr[i] = 0;
            }
            GenerateCoupon(num, 0, 0, arr);

        }
    }
}
