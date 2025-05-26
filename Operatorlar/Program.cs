using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            int sayi3 = 5;
            int sayi4 = 3;
            string soz = "İki Sayının Toplamının 5 İle çarpımı: ";
            object soz2 = "Birinci Sayının 3' bölümünden kalan: ";
            int toplam = sayi1 + sayi2; // Toplama işlemi
            int fark = sayi1 - sayi2; // Çıkarma işlemi
            int carpim = sayi1 * sayi2; // Çarpma işlemi
            int bolum = sayi1 / sayi2; // Bölme işlemi
            int kalan = sayi1 % sayi2; // Mod alma işlemi

            Console.WriteLine("Birinci Sayı: 10");
            Console.WriteLine("İkinci Sayı: 20");
            Console.WriteLine("İşlemler:");
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Fark: " + fark);
            Console.WriteLine("Çarpım: " + carpim);
            Console.WriteLine("Bölüm: " + bolum);
            Console.WriteLine("Kalan: " + kalan);
            Console.WriteLine(soz + (sayi1 + sayi2) * sayi3);
            Console.Write(soz2);
            Console.WriteLine(sayi1 % sayi4);
            Console.WriteLine();
            
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;

            bool check1 = num1 < num2 && num2 < num3; // Mantıksal AND operatörü

            Console.WriteLine(check1);

            bool check2 = num1 < num2 && num2 > num3;

            Console.WriteLine(check2);

            bool check3 = num1 != num2 || num2 > num3;

            Console.WriteLine(check3);

            bool degil = !true;

            Console.WriteLine(degil);

            int z = 9;

            z *= 2;

            Console.WriteLine(z);

            Console.ReadLine();
        }
    }
}
