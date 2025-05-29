using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar
{
    public class Araba
    {
        public string KapiSayisi;
        public string Renk;
        public string Marka;
        private string gizliBolme;


        public void arabaCalistir()
            {
            Console.WriteLine(gizliBolme);
            Console.WriteLine("Araba çalıştırıldı.");
        }

        public Araba(string _KapiSayisi, string _Renk, string _Marka)
        {

            KapiSayisi = _KapiSayisi;
            Renk = _Renk;
            Marka = _Marka;
        }



    }
}
