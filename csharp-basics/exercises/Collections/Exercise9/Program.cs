namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new HashSet<string>();
            list.Add("red");
            list.Add("green");
            list.Add("pink");
            list.Add("blue");
            list.Add("white");
            Console.WriteLine(string.Join(",", list));
            list.Clear();
            list.Add("red");
            list.Add("red");
            Console.WriteLine(string.Join(",", list));
        }
    }
}
