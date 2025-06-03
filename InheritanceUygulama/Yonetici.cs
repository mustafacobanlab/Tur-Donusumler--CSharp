using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    public class Yonetici : Calisan
    {
        private int sorumluKisiSayisi;
        public Yonetici(int id, string name, string surname, int sorumluKisiSayisi):base(id,name,surname)
        {
            this.sorumluKisiSayisi = sorumluKisiSayisi;
        }

        public void ZamYap(int miktar)
        {
            Console.WriteLine(getName() + " çalışanlarına " + miktar + " TL zam yaptı.");
        }
    }
}
