using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterictanceGiris
{
    public class Kedi : Hayvan // Subclass
    {
       public void Miyavla()
        {
            ses = "Miyav Miyav"; // Override the base class's protected
            Console.WriteLine(ses);
            Console.WriteLine("Kedi miyavlıyor...");
        }
        public void Tirmala()
        {
            Console.WriteLine("Kedi tırmalıyor...");
        }
        public void Uyku()
        {
            Console.WriteLine("Kedi uyuyor...");
        }
    }
    
}

