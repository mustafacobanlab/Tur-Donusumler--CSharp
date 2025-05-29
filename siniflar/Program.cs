using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace siniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kapiSayisi = "4";
            string renk = "Kırmızı";
            string marka = "Toyota";

            Araba araba = new Araba(kapiSayisi, renk, marka);

            Console.WriteLine(araba.Renk);
            Console.WriteLine(araba.KapiSayisi);
            Console.WriteLine(araba.Marka);
            

            araba.arabaCalistir();

            

            Console.ReadLine();

        }
    }
}
