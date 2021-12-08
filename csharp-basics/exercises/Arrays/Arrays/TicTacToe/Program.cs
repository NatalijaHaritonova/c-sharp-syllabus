using System;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static int count = 0;

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            int maxRound = 4;
            int count2 = 0;

            for (int i = 1; i <= maxRound; i++)
            {
                if (count == 0)
                {
                    XTurn();
                    WinTest();
                    if (count == 0)
                    {
                        OTurn();
                        WinTest();
                        count2++;
                    }
                }
            }

            if (count == 0 && count2 == 4)
            {
                XTurn();
                WinTest();
                if (count == 0)
                {
                    Console.WriteLine("It's draw!");
                }
                Console.ReadKey();
            }
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        private static void XTurn()
        {
            char xChar = 'X';
            Console.WriteLine("'X', Chose your location(row,column):");
            int[] xMove1 = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            board[xMove1[0], xMove1[1]] = xChar;
            DisplayBoard();
        }

        private static void OTurn()
        {
            char oChar = 'O';
            Console.WriteLine("'O', Chose your location(row,column):");
            int[] oMove1 = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            board[oMove1[0], oMove1[1]] = oChar;
            DisplayBoard();
        }
        
        private static void WinTest()
        {
            char xChar = 'X';
            char oChar = 'O';

            if (board[0, 0].Equals(xChar) && board[0, 1].Equals(xChar) && board[0, 2].Equals(xChar) ||
                board[1, 0].Equals(xChar) && board[1, 1].Equals(xChar) && board[1, 2].Equals(xChar) ||
                board[2, 0].Equals(xChar) && board[2, 1].Equals(xChar) && board[2, 2].Equals(xChar) ||
                board[0, 0].Equals(xChar) && board[1, 0].Equals(xChar) && board[2, 0].Equals(xChar) ||
                board[0, 1].Equals(xChar) && board[1, 1].Equals(xChar) && board[2, 1].Equals(xChar) ||
                board[0, 2].Equals(xChar) && board[1, 2].Equals(xChar) && board[2, 2].Equals(xChar) ||
                board[0, 0].Equals(xChar) && board[1, 1].Equals(xChar) && board[2, 2].Equals(xChar) ||
                board[2, 0].Equals(xChar) && board[1, 1].Equals(xChar) && board[0, 2].Equals(xChar))
            {
                count++;
                Console.WriteLine($"{xChar} win!");
                Console.ReadKey();
            }
            else if (board[0, 0].Equals(oChar) && board[0, 1].Equals(oChar) && board[0, 2].Equals(oChar) ||
                board[1, 0].Equals(oChar) && board[1, 1].Equals(oChar) && board[1, 2].Equals(oChar) ||
                board[2, 0].Equals(oChar) && board[2, 1].Equals(oChar) && board[2, 2].Equals(oChar) ||
                board[0, 0].Equals(oChar) && board[1, 0].Equals(oChar) && board[2, 0].Equals(oChar) ||
                board[0, 1].Equals(oChar) && board[1, 1].Equals(oChar) && board[2, 1].Equals(oChar) ||
                board[0, 2].Equals(oChar) && board[1, 2].Equals(oChar) && board[2, 2].Equals(oChar) ||
                board[0, 0].Equals(oChar) && board[1, 1].Equals(oChar) && board[2, 2].Equals(oChar) ||
                board[2, 0].Equals(oChar) && board[1, 1].Equals(oChar) && board[0, 2].Equals(oChar))
            {
                count++;
                Console.WriteLine($"{oChar} win!");
                Console.ReadKey();
            }
        }
    }
}
