using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();

            ogrenci.KILO = 70; // Kilo değerini ayarlıyoruz
            Console.WriteLine(ogrenci.KILO); // Kilo değerini yazdırıyoruz
            ogrenci.setIsim("Ahmet");
            Console.WriteLine(ogrenci.getIsim());

            Console.ReadLine();
        }
    }
}
