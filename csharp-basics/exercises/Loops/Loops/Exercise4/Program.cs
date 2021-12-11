using System;
namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            for (int i = 0; i < vowels.Length; i++)
                {
                    Console.WriteLine(vowels[i]);
                }

            foreach (char o in vowels)
            {
                Console.WriteLine(o);
            }

            Console.ReadKey();
        }
    }
}
