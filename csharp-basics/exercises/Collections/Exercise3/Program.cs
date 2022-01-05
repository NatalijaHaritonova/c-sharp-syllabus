namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            string elem = "new";
            
            while (elem.Length > 0)
            {
                Console.WriteLine("Enter name: ");
                elem = Console.ReadLine();
                names.Add(elem);
            }
            Console.Write("Unique name list contains: ");
            Console.Write(string.Join(" ", names));
        }
    }
}
