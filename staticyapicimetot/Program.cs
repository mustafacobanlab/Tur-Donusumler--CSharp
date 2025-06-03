using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticyapicimetot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kullanici kullanici1 = new Kullanici(1, "Ahmet", "Yılmaz");

            kullanici1.BilgileriGoster();

            Kullanici kullanici2 = new Kullanici(2, "Mehmet", "Demir");

            kullanici2.BilgileriGoster();

            kullanici2.MaasArttir(500);

            Console.ReadLine();
        }
    }
}
