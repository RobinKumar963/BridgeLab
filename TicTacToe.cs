
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TicTacToe.cs" company="Bridgelabz">
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
    /// Tic Tac Toe Game
    /// </summary>
    class TicTacToe
    {
        /// <summary>
        /// Checks the row.
        /// </summary>
        /// <param name="tictactoe">The tictactoe.</param>
        /// <returns></returns>
        public static int checkRow(char[,] tictactoe)
        {
            Boolean matchWinConditionFound = false; char winner = '\0';
            
            for (int i = 0; i < 3; i++)
            {
                matchWinConditionFound = true;

                for (int j = 0; j < 2; j++)
                {
                    if (tictactoe[i, j] == '\0')
                    {
                        matchWinConditionFound = false;
                        break;


                    }


                    if (tictactoe[i, j] != tictactoe[i, j + 1])
                    {
                        matchWinConditionFound = false;
                        break;
                    }
                    else
                    {
                        winner = tictactoe[i, j];

                    }

                }
            }



            if (matchWinConditionFound)
            {
                if (winner.Equals('X'))
                    return 1;
                else
                    return -1;
            }
            else
                return 0;

        }
        /// <summary>
        /// Checks the col.
        /// </summary>
        /// <param name="tictactoe">The tictactoe.</param>
        /// <returns></returns>
        public static int checkCol(char[,] tictactoe)
        {
            Boolean matchWinConditionFound = false; char winner = '\0';
            
            for (int i = 0; i < 3; i++)
            {
                matchWinConditionFound = true;

                for (int j = 0; j < 2; j++)
                {
                    if (tictactoe[i, j] == '\0')
                    {
                        matchWinConditionFound = false;
                        break;

                    }
                    if (tictactoe[j, i] != tictactoe[j + 1, i])
                    {
                        matchWinConditionFound = false;
                        break;

                    }

                    else
                    {
                        winner = tictactoe[i, j];

                    }

                }
            }
            if (matchWinConditionFound)
            {
                if (winner.Equals('X'))
                    return 1;
                else
                    return -1;
            }
            else
                return 0;

        }
        /// <summary>
        /// Checks the diagonal case1.
        /// </summary>
        /// <param name="tictactoe">The tictactoe.</param>
        /// <returns></returns>
        public static int checkDiagonalCase1(char[,] tictactoe)
        {
            Boolean matchWinConditionFound = true;char winner = '\0';
            for (int i = 0; i < 2; i++)
            {
                
                if (tictactoe[i, i] == '\0')
                {
                    matchWinConditionFound = false;
                    break;
                    

                }
                if (tictactoe[i, i] != tictactoe[i + 1, i + 1])
                {
                    matchWinConditionFound = false;
                    break;
                }
                else
                {
                    winner = tictactoe[i, i];

                }

            }
            if (matchWinConditionFound)
            {
                if (winner.Equals('X'))
                    return 1;
                else
                    return -1;
            }
            else
                return 0;

        }
        /// <summary>
        /// Checks the diagonal case2.
        /// </summary>
        /// <param name="tictactoe">The tictactoe.</param>
        /// <returns></returns>
        public static int checkDiagonalCase2(char[,] tictactoe)
        {
            Boolean matchWinConditionFound = true;char winner = '\0';
            for (int i = 0, j = 2; i < 2; i++, j--)
            {


                if (tictactoe[i, j] == '\0')
                {
                    matchWinConditionFound = false;
                    break;

                }
                if (tictactoe[i, j] != tictactoe[i + 1, j - 1])
                {
                    matchWinConditionFound = false;
                    break;
                }

                else
                {
                    winner = tictactoe[i, j];

                }



            }
            if (matchWinConditionFound)
            {
                if (winner.Equals('X'))
                    return 1;
                else
                    return -1;
            }
            else
                return 0;

        }
        /// <summary>
        /// Checks for exhaustion.
        /// </summary>
        /// <param name="tictactoe">The tictactoe.</param>
        /// <returns></returns>
        public static Boolean checkForExhaustion(char[,] tictactoe)
        {
            Boolean occupied = true;

            ////check if all cells are occupied....if so draw
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tictactoe[i, j] == '\0')
                    {
                        occupied = false;

                        break;
                    }

                }
                if (occupied == false)
                    break;
            }
            return occupied;
        }

        /// <summary>
        /// Plays the game.
        /// </summary>
        /// <param name="tictactoe">The tictactoe.</param>
        /// <returns></returns>
        public static int PlayGame(Char[,] tictactoe)
        {
            int gameResult = checkRow(tictactoe);
            if (gameResult == 1)
                return gameResult;
            if (gameResult == -1)
                return gameResult;

            gameResult = checkCol(tictactoe);
            if (gameResult == 1)
                return gameResult;
            if (gameResult == -1)
                return gameResult;

            gameResult = checkDiagonalCase1(tictactoe);
            if (gameResult == 1)
                return gameResult;
            if (gameResult == -1)
                return gameResult;

            gameResult = checkDiagonalCase2(tictactoe);
            if (gameResult == 1)
                return gameResult;
            if (gameResult == -1)
                return gameResult;
            
            gameResult = checkForExhaustion(tictactoe) ? 0 : 2;
            return gameResult;


        }
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {
            char[,] tictactoe = new char[3, 3];int game, row, col; Random rand = new Random();


            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    tictactoe[i,j] = '\0';
                }
            }
            
            while (true)
            {
                Console.Clear();
                Algorithm.Utility.Print2DArray(tictactoe, 3, 3);
                Console.WriteLine("Enter row to mark:");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter col to mark:");
                col = Convert.ToInt32(Console.ReadLine());
                if (tictactoe[row , col] != '\0')
                {
                    Console.WriteLine("Cell already occupied:Press any key to mark Different Cell");
                    Console.ReadLine();
                    continue;
                }
                else
                    tictactoe[row, col] = 'X';
                game = PlayGame(tictactoe);

                if (game == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Won");
                    break;
                }
                if (game == -1)
                {
                    Console.Clear();
                    Console.WriteLine("Lost");
                    break;

                }
                if (game == 0)
                {
                    Console.WriteLine("Draw");
                    break;

                }


                while (true)
                {
                    row = rand.Next(0, 3);
                    col = rand.Next(0, 3);
                    if (tictactoe[row, col] != '\0')
                    {
                        
                        continue;
                    }
                    else
                    {
                        tictactoe[row, col] = 'O';
                        break;

                    }
                        

                }
                

                game = PlayGame(tictactoe);

                if (game == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Won");
                    break;
                }
                 if (game == -1)
                {
                    Console.Clear();
                    Console.WriteLine("Lost");
                    break;

                }
                if (game == 0)
                {
                    Console.WriteLine("Draw");
                    break;

                }
               


               

            }   



            
            










        }
    }
}
