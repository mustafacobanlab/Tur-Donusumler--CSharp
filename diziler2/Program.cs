using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace diziler2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] isimler = { "Ahmet", "Mehmet", "Ayşe", "Fatma" };

            //foreach (string i in isimler)
            //{
            //    Console.WriteLine(i);
            //}


            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 90 };
            int adet = 0;
            Console.Write("Lütfen Dizide aramak istediğiniz sayıyı giriniz: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (input == sayilar[i])
                {
                    adet++;

                }



            }
            if (adet > 0)
                Console.WriteLine("Girdiğiniz Sayı Dizide " + adet + " adet vardır.");
            else
                Console.WriteLine("Girdiğiniz Sayı dizide mevcut değildir.");

            Console.Read();
        }
    }
}
