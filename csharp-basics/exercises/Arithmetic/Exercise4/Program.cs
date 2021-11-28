namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product1ToN(10);
            
            static void Product1ToN(int num1)
            {
            int product = 1;
                for (int i = num1; i > 0; i--) 
                {
                    product *= i;
                }
                Console.WriteLine(product);  
            }
        } 
    }
}