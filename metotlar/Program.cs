using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Selam();

            sayi(10, 20);

            carpma(10, 20, 30);

            int sonuc1 = topla(10, 45);

            Console.WriteLine(sonuc1);

            double sonuc2 = fark(100, 50);

            Console.WriteLine(sonuc2);
            Console.WriteLine(fark(50.35, 13.50));

            Console.Write("Lütfen 1 Sayı Giriniz: ");
            int deger = Convert.ToInt32(Console.ReadLine());

            double kare1 = kare(deger);
            Console.WriteLine();
            if (kare1 < 100)
            {
                Console.WriteLine($"Girdiğiniz Sayının Karesi 100'den Küçüktür");
                Console.WriteLine($"Sayınızın Karesi: {kare1}");
                Console.WriteLine($"Girdiğiniz Sayı : {deger}");

            }
            else
            {
                Console.WriteLine("Girdiğiniz Sayınızın Karesi 100 veya daha büyüktür.");
                Console.WriteLine($"Sayınızın Karesi: {kare1}");
                Console.WriteLine($"Girdiğiniz Sayı : {deger}");

            }

            Console.WriteLine();

            Console.Write("Lütfen 1 Sayı Giriniz: ");
            int deger1 = Convert.ToInt32(Console.ReadLine());

            int deger2  =cift(deger1);
            Console.WriteLine();
            Console.WriteLine();
            hesap(deger, deger1);

            Console.ReadLine();
        }

        static void Selam()
        {
            Console.WriteLine("Selam Dünya");



        }
        static void sayi(int sayi1, int sayi2)
        {
            Console.WriteLine("Gönderilerin Sayıların Toplamı: " + (sayi1 + sayi2));
        }
        static void carpma(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("Gönderilen Sayıların Çarpımı: " + (sayi1 * sayi2 * sayi3));
        }
        static int topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

        static double fark(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;
        }

        static double kare(double deger)
        {
            return deger * deger;
        }

        static int cift(int sayi)
        {
             if (sayi % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz Sayı Çifttir. "); 
            }
            else
            {
                Console.WriteLine("Girdiğiniz Sayı Tektir. ");

            }
            return sayi;


        }

        static void hesap(int sayi, int sayi2)
        {
            if(sayi > sayi2)
            {
                Console.WriteLine("1. Sayı 2. Sayıdan Büyüktür.");
            }
            else if (sayi < sayi2)
            {
                Console.WriteLine("1. Sayı 2. Sayıdan Küçüktür.");
            }
            else
            {
                Console.WriteLine("1. Sayı 2. Sayıya Eşittir.");
            }
        }


    }

}
