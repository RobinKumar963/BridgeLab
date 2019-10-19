// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TwoDimensionalArray.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
namespace Bridgelabz.FunctionalProgram
{

    public class TwoDimensionalArray
    {



        public static void Input2DArray<T>(T[,] arr, int row, int col) where T : IConvertible
        {
            String value;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    value = Console.ReadLine();
                    arr[i, j] = (T)Convert.ChangeType(value, typeof(T));
                    


                }
            }

        }


        public static void Main(String[] args)
        {
            int rowLimit = 2;
            int colLimit = 2;
            string[,] arr = new string[rowLimit, colLimit];
            Input2DArray(arr, rowLimit, colLimit);
            Algorithm.Utility.Print2DArray(arr, 2, 2);



        }

    }

}