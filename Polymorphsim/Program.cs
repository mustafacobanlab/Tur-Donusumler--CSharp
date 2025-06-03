using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan = new Hayvan("Hayvan");
            hayvan.sesCikar();

            hayvan = new Kedi("Kedi");
            hayvan.sesCikar();

            hayvan = new Kopek("Köpek");
            hayvan.sesCikar();

            Console.ReadLine();

        }

    }
}


