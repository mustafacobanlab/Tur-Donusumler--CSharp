using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimOrnek
{
   public class Dikdortgen :Sekil
    {
        public int kisakenar { get; set; }
        public int uzunkenar { get; set; }

        public Dikdortgen(string isim , int kisakenar, int uzunkenar) : base(isim)
        {
            this.kisakenar = kisakenar;
            this.uzunkenar = uzunkenar;
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() +" nin alanı : "+ (kisakenar*uzunkenar));
        }

        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("Şeklin ismi :" + getIsim());
            Console.WriteLine(getIsim() +" nin kısa kenarı : "+ this.kisakenar);
            Console.WriteLine(getIsim() + " nin uzun kenarı : " + this.uzunkenar);

        }
    }
}
