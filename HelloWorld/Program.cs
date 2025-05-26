using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Mustafa Coban");
            // Yorum Satırı
            /*Yorum
             Satırı*/
            Console.Write("Mustafa");
            Console.Write(" Coban");

            byte sayi1 = 1;
            byte deger = byte.MaxValue; // 255
            byte deger2 = byte.MinValue; // 0

            Console.WriteLine(sayi1);
            Console.WriteLine(deger);
            Console.WriteLine(deger2);

            short sayi2 = 500;
            short deger3 = short.MaxValue; // 32767
            short deger4 = short.MinValue; // -32768

            Console.WriteLine(sayi2);
            Console.WriteLine(deger3);
            Console.WriteLine(deger4);

            int sayi3 = 1000;
            int deger5 = int.MaxValue; // 2147483647
            int deger6 = int.MinValue; // -2147483648
            Console.WriteLine(sayi3);
            Console.WriteLine(deger5);
            Console.WriteLine(deger6);

            long sayi4 = 1000000;
            long deger7 = long.MaxValue; // 9223372036854775807
            long deger8 = long.MinValue; // -9223372036854775808
            Console.WriteLine(sayi4);
            Console.WriteLine(deger7);
            Console.WriteLine(deger8);

            float sayi5 = 10.5f;
            float deger9 = float.MaxValue; // 3.402823E+38
            float deger10 = float.MinValue; // -3.402823E+38
            Console.WriteLine(sayi5);
            Console.WriteLine(deger9);
            Console.WriteLine(deger10);

            double sayi6 = 300.6;
            double deger11 = double.MaxValue; // 1.79769313486232E+308
            double deger12 = double.MinValue; // -1.79769313486232E+308
            Console.WriteLine(sayi6);
            Console.WriteLine(deger11);
            Console.WriteLine(deger12);

            char kar = 'M';

            bool islem = 10 > 5; // true
            bool islem2 = 10 < 5; // false

            object deger13 = 100; // object tipinde bir değişken
            object deger14 = "Merhaba"; // object tipinde bir değişken

            Console.WriteLine(kar);
            Console.WriteLine(islem);
            Console.WriteLine(islem2);
            Console.WriteLine(deger13);
            Console.WriteLine(deger14);





            Console.ReadLine();


        }
    }
}
