using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İlk Yöntem Yöntem");
            //for (int a = 1; a <= 10; a++)
            //{
            //    if (a % 2 == 0)
            //        Console.WriteLine(a);
            //}
            //Console.WriteLine("İkinci Yöntem");
            //for (int a = 0; a <= 10; a += 2)
            //{

            //    Console.WriteLine(a);
            //}
            //Console.WriteLine("Alıştırma");

            //for (int i = 1; i <= 10; i++)
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("Alıştırma 2");
            //int w = 1;
            //while (w <= 10)
            //{

            //    Console.WriteLine(w);
            //    w++;
            //}

            //Console.WriteLine("Alıştırma 3");

            //int w1 = 1;

            //do {
            //    Console.WriteLine("Selam Dünya");
            //} while (w1 != 1);

            //string z = "   |    ";
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {

            //        Console.Write(i + "x" + j + "=" + (i * j));
            //        Console.Write(z);
            //    }
            //    Console.WriteLine();
            //}


            int hak = 3;

            while (true)
            {
                Console.Write("Kullanıcı Adınızı Giriniz: ");
                string id = Console.ReadLine();
                Console.Write("Şifrenizi giriniz Adınızı Giriniz: ");
                string sifre = Console.ReadLine();


                if(id == "admin" & sifre == "123")
                {
                    Console.WriteLine("Sisteme Giriş Yaptınız.");
                    break;
                }
                else
                {
                    hak--;
                    Console.WriteLine("Bilgileriniz Yanlış.");
                   
                } if (hak == 0)
                {
                    Console.WriteLine("Yanlış deneme hakkınız doldu.");
                    break;
                }




            }





            Console.Read();
        }
    }
}
