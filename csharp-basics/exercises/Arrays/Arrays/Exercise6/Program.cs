namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueChanger a = new ValueChanger();
            a.AddValues();
            Console.WriteLine(a.ShowAllArr());
            a.ChangeValues(-7, 9);
            Console.WriteLine(a.ShowAllArr());
        }
    }
}
