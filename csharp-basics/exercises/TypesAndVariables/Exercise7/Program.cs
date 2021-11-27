//Write a program that prompts the user to enter a string and displays the number of the uppercase letters in the string.
namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData;
            inputData = Console.ReadLine();
            char[] charList = inputData.ToCharArray();
            int i;
            int count = 0;
            for (i = 0; i < charList.Length; i++) 
            {
                if (char.IsUpper(charList[i]))
                {
                    count++;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
