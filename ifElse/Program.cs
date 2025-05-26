using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float vize, final, ortalama;
            Console.Write("Vize Notunuzu Giriniz: ");
            vize = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Final Notunuzu Giriniz: ");
            final = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            ortalama = (vize * 0.3f) + (final * 0.7f);

            Console.Clear();

            if (ortalama >= 35)
            {
                Console.WriteLine("Dersi Geçtiniz!");
                Console.WriteLine("Not Ortlamanız: " + ortalama);
            }
            else
            {
                Console.WriteLine("Dersi Kaldınız!");
                Console.WriteLine("Not Ortlamanız: " + ortalama);
            }
            Console.Read();

        }
    }
}
