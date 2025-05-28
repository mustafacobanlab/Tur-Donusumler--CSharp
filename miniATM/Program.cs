using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace miniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UTF8Encoding utf8 = new UTF8Encoding(false, true);
            Console.OutputEncoding = utf8;

            int bakiye = 500;


            Console.WriteLine("-------İşlemler------");
            Console.WriteLine("1 - Bakiye görüntüleme");
            Console.WriteLine("2 - Para Çekme");
            Console.WriteLine("3 - Para Yatırma");
            Console.WriteLine("4 - Çıkış Yap");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.Write("Yapmak İstediğiniz İşlemi Seçiniz: ");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("Hesap Bakiyeniz: " + bakiye + "₺");
                Console.WriteLine("1 - Çıkış");
                int secim1 = int.Parse(Console.ReadLine());
                if (secim1 == 1)
                {
                    Console.WriteLine("Çıkış Yapılıyor...");
                    return;
                }
            }
            else if (secim == 2)
            {
                Console.Write("Çekmek İstediğiniz Tutarı Giriniz:");
                int cekilecekTutar = int.Parse(Console.ReadLine());
                if (cekilecekTutar > bakiye)
                {
                    Console.WriteLine("Yetersiz Bakiye!");
                }
                else
                {
                    bakiye -= cekilecekTutar;
                    Console.WriteLine("Yeni Bakiyeniz: " + bakiye + "₺");
                }
                Console.WriteLine("1 - Çıkış");
                int secim2 = int.Parse(Console.ReadLine());
                if (secim2 == 1)
                {
                    Console.WriteLine("Çıkış Yapılıyor...");
                    return;
                }

            }
            else if (secim == 3)
            {
                Console.Write("Yatırmak İstediğiniz Tutarı Giriniz: ");
                int yatirilacakTutar = int.Parse(Console.ReadLine());
                bakiye += yatirilacakTutar;
                Console.WriteLine("Yeni Bakiyeniz: " + bakiye + "₺");
                Console.WriteLine("1 - Çıkış");
                int secim3 = int.Parse(Console.ReadLine());
                if (secim3 == 1)
                {
                    Console.WriteLine("Çıkış Yapılıyor...");
                    return;
                }
              
                
            }
            else if (secim == 4)
            {
                Console.WriteLine("Çıkış Yapılıyor...");
                return;
            }
            else
            {
                Console.WriteLine("Geçersiz işlem!");
            }

                Console.Read();

            }
        }
    }

