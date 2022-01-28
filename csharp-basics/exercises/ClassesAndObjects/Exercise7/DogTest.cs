namespace Exercise7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            Dog sparky = new Dog("Sparky", "male");
            Dog sam = new Dog("Sam", "male");
            Dog lady = new Dog("Lady", "female");
            Dog molly = new Dog("Molly", "female");
            Dog rocky = new Dog("Rocky", "male", molly, sam);
            Dog buster = new Dog("Buster", "male", lady, sparky);
            Dog max = new Dog("Max", "male", lady, rocky);
            Dog coco = new Dog("Coco", "female", molly, buster);

            Console.WriteLine(rocky.FathersName());
            Console.WriteLine(sam.FathersName());
            Console.WriteLine(buster.HasSameMotherAs(max));
            Console.WriteLine(buster.HasSameMotherAs(coco));
            Console.ReadKey();
        }
    }
}
