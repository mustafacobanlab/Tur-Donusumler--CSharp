using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci(123, "Ahmet", "Yılmaz", "Örnek Okulu", 80, 85, 90);







            while (true)
            {
                islem();
                Console.WriteLine();
                Console.Write("Yapmak İstediğiniz İşlemi Seçiniz: ");
                
                string secim = Console.ReadLine();
                Console.WriteLine();
                
                

                switch (secim)
                {
                    case "1":
                        ogrenci1.OgrenciBilgileriniGoster();
                        break;
                    case "2":
                        Console.WriteLine($"Öğrenci Not Ortalaması: {ogrenci1.ortalamaBul()}");
                        break;
                    case "3":
                        ogrenci1.okulgetir();
                        break;
                    case "4":
                        Console.WriteLine("Çıkış Yapılıyor...");
                        return; // Programdan çıkış yapar

                    default:
                        Console.WriteLine("Geçersiz işlem!");
                        break;
                }

                Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                Console.ReadKey(); // Enter değil herhangi bir tuşa basmayı bekler
                Console.Clear();   // Ekranı temizler
            }


        }

        static void islem()
        {
            Console.WriteLine("1- Öğrenci Bilgilerini Göster");
            Console.WriteLine("2- Öğrenci Ortalamasını Göster");
            Console.WriteLine("3- Öğrenci Okulunu Göster");
            Console.WriteLine("4- Çıkış Yap");

        }
    }
}
