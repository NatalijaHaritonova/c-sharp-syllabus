namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = Is15(1, 23);
            static bool Is15(int num1, int num2)
            {
                if (num1 == 15 || num2 == 15 || num1 + num2 == 15 || num1 - num2 == 15 || num2 - num1 == 15)
                {
                    return true;
                }
                return false;
            }
            Console.WriteLine(result.ToString());
        }
    }
}