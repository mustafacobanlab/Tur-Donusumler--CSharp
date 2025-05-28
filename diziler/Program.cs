using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int[] sayilar = new int[3];

            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;

            //for( int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}



            string[] isimler = { "Ahmet", "Mehmet", "Ayşe", "Fatma" };
            double[] ondalik = { 3.14, 7.56, 6.58, 3.65 };
            char[] harf = { 'A', 'B', 'C', 'D' };
            object[] karisik = { "Ahmet", 3.14, 'A', 7 };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
                Console.WriteLine(ondalik[i]);
                Console.WriteLine(harf[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < karisik.Length; i++)
            {
                Console.WriteLine(karisik[i]);
                Console.WriteLine(karisik[i].GetType());
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Lütfen Listenizdeki Eleman Sayını Giriniz: ");
            int a = int.Parse(Console.ReadLine());

            string[] veri = new string[a];

            for (int z = 0; z < veri.Length; z++) {
                Console.Write("Lütfen Listenizdeki Elemanları Giriniz: ");
                string veri1 = Console.ReadLine();
                veri[z] = veri1;
            }
            for (int e = 0; e < veri.Length; e++) {
                Console.WriteLine(veri[e]);
       
            }



            Console.Read();

        }
    }
}
