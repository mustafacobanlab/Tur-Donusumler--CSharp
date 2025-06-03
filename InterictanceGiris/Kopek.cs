using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterictanceGiris
{
    public class Kopek : Kedi
    {
        public void Havla()
        {
            ses = "Hav Hav"; // Override the base class's protected field
            Console.WriteLine(ses);
            Console.WriteLine("Köpek havlıyor...");
        }
        public void Kovalama()
        {
            Console.WriteLine("Köpek kovalıyor...");
        }
        public void Oyna()
        {
            Console.WriteLine("Köpek oynuyor...");
        }
    }

}
