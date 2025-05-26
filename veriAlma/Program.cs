using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İsminizi Giriniz: ");
            string name = Console.ReadLine();

            Console.Write("Soyisminizi Giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Kullanıcın Adı ve Soyadı: " + name + " " + surname);
            Console.Read();

        }
    }
}
