using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterictanceGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kopek kopek = new Kopek();
            Console.WriteLine("Köpek Bilgilerimiz.");

            kopek.Isim = "Karabas";
            kopek.Cinsiyet = "Erkek";
            kopek.hayvanrengi = "Siyah";
            kopek.Yas = 5;

            Console.WriteLine();

            kopek.hayvanBilgisi();
            Console.WriteLine();

            kopek.Havla();
            kopek.Kovalama();
            kopek.Oyna();
            Console.WriteLine();
            Console.WriteLine("Kedi Bilgilerimiz.");

            kopek.Isim = "Pamuk";
            kopek.Cinsiyet = "Dişi";
            kopek.hayvanrengi = "Beyaz";
            kopek.Yas = 3;
            Console.WriteLine();
            kopek.hayvanBilgisi();
            Console.WriteLine();
            kopek.Miyavla(); // Kedi sınıfından gelen metot
            kopek.Tirmala(); // Kedi sınıfından gelen metot
            kopek.Uyku();    // Kedi sınıfından gelen metot

            Console.WriteLine();
            Console.WriteLine("Personel Bilgileri.");
            Personel personel = new Personel();
            personel.personel_id = "1";
            personel.personel_ad = "Ahmet";
            personel.personel_soyisim ="Yılmaz";
            personel.personel_maas = 5000;

            personel.personelBilgisi();


            Console.ReadLine();


        }
    }
}
