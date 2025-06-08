using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Gunler gun= Gunler.pazartesi;
            if(gun == Gunler.pazartesi)
            {
                Console.WriteLine("Bugün Pazartesi");
            }
            else if (gun == Gunler.salı)
            {
                Console.WriteLine("Bugün Salı");
            }
            else if (gun == Gunler.çarşamba)
            {
                Console.WriteLine("Bugün Çarşamba");
            }
            else if (gun == Gunler.perşembe)
            {
                Console.WriteLine("Bugün Perşembe");
            }
            else if (gun == Gunler.cuma)
            {
                Console.WriteLine("Bugün Cuma");
            }
            else if (gun == Gunler.cumartesi)
            {
                Console.WriteLine("Bugün Cumartesi");
            }
            else if (gun == Gunler.pazar)
            {
                Console.WriteLine("Bugün Pazar");
            }


            Console.ReadLine();
        }
    }
}
