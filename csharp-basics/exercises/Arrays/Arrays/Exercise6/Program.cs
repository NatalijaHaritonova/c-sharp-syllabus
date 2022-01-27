/*
Write a program that creates an array of ten integers. It should put ten random numbers from 1 to 100 in the array.
It should copy all the elements of that array into another array of the same size.

Then display the contents of both arrays. To get the output to look like this, you'll need a several for loops.

Create an array of ten integers
Fill the array with ten random numbers (1-100)
Copy the array into another array of the same capacity
Change the last value in the first array to a -7
Display the contents of both arrays

Array 1: 45 87 39 32 93 86 12 44 75 -7
Array 2: 45 87 39 32 93 86 12 44 75 50
 */
namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] arr2 = new int[10];
            Random rd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 100);
            }
            
            arr.CopyTo(arr2, 0);
            arr.SetValue(-7, 9);

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            
            Console.WriteLine();

            foreach (int i in arr2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
