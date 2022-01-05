using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            string[] origination = { "Germany", "Germany" , "Japan", "Germany" , "Germany" , "USA"};
            

            List <string> newArray = new List <string> ();
            for (int i = 0; i < array.Length; i++)
            {
                newArray.Add(array[i]);
            }
            for (int i = 0;i < array.Length; i++)
            {
                Console.Write(newArray[i]+ ",");
            }
            Console.WriteLine();

            HashSet<string> arrayHashSet = new HashSet<string> ();

            for (int i = 0;i < array.Length; i++)
            {
                arrayHashSet.Add(array[i]);
            }
            Console.WriteLine(String.Join(",", arrayHashSet));
            Console.WriteLine();
            
            List <string> arrAfterHash = new List<string> (arrayHashSet);
            Dictionary <string, string> dictArr = new Dictionary<string, string> ();

            for (int i = 0; i < arrAfterHash.Count; i++)
            {
                dictArr.Add(arrAfterHash[i], origination[i]);
            }
            
            foreach (KeyValuePair<string, string> kv in dictArr)
            {
                Console.WriteLine(kv.ToString());
            }
            Console.ReadKey();
        }
    }
}
