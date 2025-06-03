using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterictanceGiris
{
    public class Hayvan // Superclass, Base Class, Parent Class
    {
        public string Isim { get; set; }
        public string Cinsiyet { get; set; }

        public string hayvanrengi { get; set; }

        protected string ses;

        private int yas;
        public int Yas { get{ return yas; } set { yas = value; } }



        public void hayvanBilgisi()
        {
            Console.WriteLine("Hayvanın ismi: " + Isim);
            Console.WriteLine("Hayvanın cinsiyeti: " + Cinsiyet);
            Console.WriteLine("Hayvanın rengi: " + hayvanrengi);
        }


    }
}
