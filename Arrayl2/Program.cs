using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayl2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1); 
            arrayList.Add("Hello"); 

            arrayList.Add(3.14);
            arrayList.Add(true);
            arrayList.Add(DateTime.Now);
            

            arrayList.Remove(3.14); // Remove the double value
            // arrayList.Clear(); // Clear the ArrayList

            bool check = arrayList.Contains("Hello"); // Check if "Hello" is in the ArrayList
            dynamic index = arrayList.IndexOf("Hello"); // Get the index of "Hello"
            arrayList.Insert(2, "Inserted Item"); // Insert an item at index 2

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Dizinin Eleman Sayısı: {arrayList.Count}");
            Console.WriteLine($"Hello verisi kaçıncı index'de: {index}");

            Console.WriteLine($"Kontrol: {check}");

            ArrayList number = new ArrayList(); // Copying the ArrayList
            number.Add(1);
            number.Add(9);
            number.Add(8);
            number.Add(3);
            number.Add(5);
            number.Add(7);
            number.Add(20);
            number.Sort(); // Sort the ArrayList

            foreach (var item2 in number)
            {
                Console.WriteLine(item2);
            }

            number.Reverse(); // Reverse the ArrayList
            foreach (var item2 in number)
            {
                Console.WriteLine(item2);
            }

            

            Console.ReadLine();

        }
    }
}
