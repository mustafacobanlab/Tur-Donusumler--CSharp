using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bedenKitleIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kilonuzu Giriniz:");
            int kilo = int.Parse(Console.ReadLine());

            Console.Write("Boyunuzu Giriniz:");
            double boy = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double bki = kilo / (boy * boy);

            if (bki < 18 && bki >= 1)
            {
                Console.WriteLine("Zayıf" + " + Değer: " + bki);
            }
            else if (bki >= 18 && bki < 25)
            {
                Console.WriteLine("Normal" + " + Değer: " + bki);
            }
            else if (bki >= 25 && bki < 30)
            {
                Console.WriteLine("Fazla Kilolu" + "  + Değer: " + bki);
            }
           
            else if (bki >= 36 && bki < 50)
            {
                Console.WriteLine("Obez" + " + Değer: " + bki);
            }
            else
            {
                Console.WriteLine("Geçersiz Değer");
            }








            Console.Read();

        }
    }
}
