using System;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static int count = 1;
        private static char xChar = 'X';
        private static char oChar = 'O';
        private static char turn;
        private static bool winCheck = false;

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            int maxRound = 10;

            for (int i = 1; i < maxRound; i++)
            {
                Turn();
                if (count >= 5)
                {
                    WinTest();
                    if (winCheck)
                    {
                        break;
                    }
                }
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
            Console.WriteLine("     0|1|2");
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        private static void Turn()
        {
            if (count % 2 == 0)
            {
                turn = oChar;
            }
            else
            {
                turn = xChar;
            }
            Console.WriteLine($"{turn}, Chose your location(row,column):");
            int[] move = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            board[move[0], move[1]] = turn;
            count++;
            Console.Clear();
            DisplayBoard();
        }
        
        private static void WinTest()
        {
            if (turn == board[0, 0] && board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] ||
                turn == board[1, 0] && board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] ||
                turn == board[2, 0] && board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] ||
                turn == board[0, 0] && board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] ||
                turn == board[0, 1] && board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] ||
                turn == board[0, 2] && board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] ||
                turn == board[0, 0] && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] ||
                turn == board[2, 0] && board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
            {
                Console.WriteLine($"{turn} win!");
                winCheck = true;
            }
            else
            {
                if (count == 10)
                {
                    Console.WriteLine("It's draw!");
                    Console.ReadKey();
                }
            }
        }
    }
}
