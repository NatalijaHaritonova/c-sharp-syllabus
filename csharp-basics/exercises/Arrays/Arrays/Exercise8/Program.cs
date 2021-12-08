using System;
using System.Linq;

namespace Exercise8
{
    class Program
    {
        private static string[,] table = new string[3, 1];
        private static List<string> words = new List<string>(new string[] { "formulize", "wrestling", "oversight", "urbanized", "flavoured" });
        private static string hiddenWord = "";
        private static int index = new Random().Next(words.Count);
        private static char[] wordToGuess = words[index].ToCharArray();
        private static string guessed = "";
        private static string missed = "";
        private static void Main(string[] args)
        {
            InitTable();
            InitWord();
            Display();
            PlayGame();
        }

        private static void InitTable()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 1; c++)
                    table[r, c] = "";
            }
        }

        private static void InitWord()
        {
            int letterNum = words[index].Length;

            for (int i = 0; i < letterNum; i++)
            {
                hiddenWord += "_ ";
            }

            table[0, 0] = hiddenWord;
        }

        private static void Display()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine();
            Console.WriteLine("Word:   " + table[0, 0]);
            Console.WriteLine();
            Console.WriteLine("Misses:   " + table[1, 0]);
            Console.WriteLine();
            Console.WriteLine("Guess:   " + table[2, 0]);
            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }
        private static void PlayGame()
        {
            int letterNum = words[index].Length;
            int count = 0;

            for (int t = 0; t < letterNum + 4; t++)
            {
                char input = Convert.ToChar(Console.ReadLine());
                int iptIndex = Array.IndexOf(wordToGuess, input);

                if (iptIndex > -1)
                {
                    guessed += input;
                    table[2, 0] = guessed;
                    
                    char[] cHiddenWord = hiddenWord.ToCharArray();
                    cHiddenWord[iptIndex * 2] = input;
                    hiddenWord = new string(cHiddenWord);

                    table[0, 0] = hiddenWord;
                    Display();
                    WinTest();
                }
                else if (iptIndex < 0 && count < 4)
                {
                        count++;
                        missed += input;
                        table[1, 0] = missed;
                        Display();
                }
                else
                {
                    Console.WriteLine("No more tries! You lose.");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("You win!");
            Console.ReadKey();
        }
        private static void WinTest()
        {

            char[] cHiddenWord = hiddenWord.ToCharArray();
            char underL = '_';
            int index = Array.IndexOf(cHiddenWord, underL);
            if (index < 0)
            {
                Console.WriteLine("You win!");
                Console.ReadKey();
            }
        }
    }
}
