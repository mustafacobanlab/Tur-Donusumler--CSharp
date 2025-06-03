using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetot
{
    public class Personel
    {

        public int calisanId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }

        public static int maas { get; set; }




        public static void adsoyadyazdir() {

            Console.WriteLine("Mustafa Çoban");
        }

        public static void sayilarTopla(int sayi1, int sayi2) {
            Console.WriteLine("İki Sayının Toplamı: "+(sayi1 + sayi2));
        }
    }

}
