using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harfnotuhesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Not Aralığı--");
            Console.WriteLine("3-) Çok İyi");
            Console.WriteLine("2-) İyi");
            Console.WriteLine("1-) Kötü");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.Write("Lütfen Notunuzu Giriniz:");
            int not = int.Parse(Console.ReadLine());

            switch (not)
            {
                case 3:
                    Console.WriteLine("Harf Notunuz: A");
                    Console.Read();
                    break;
                case 2:
                    Console.WriteLine("Harf Notunuz: C");
                    Console.Read();
                    break;

                case 1:
                    Console.WriteLine("Harf Notunuz: F");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Geçersiz Değer.");
                    Console.Read();
                    break;




            }

        }
    }
}
