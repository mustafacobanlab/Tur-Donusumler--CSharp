using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterictanceGiris
{
    public sealed class Personel
    {
        public string personel_id { get; set; }
        public string personel_ad { get; set; }
        public string personel_soyisim { get; set; }
        public int personel_maas { get; set; }

        public void personelBilgisi()
        {
            Console.WriteLine("Personel ID: " + personel_id);
            Console.WriteLine("Personel Adı: " + personel_ad);
            Console.WriteLine("Personel Soyadı: " + personel_soyisim);
            Console.WriteLine("Personel Maaşı: " + personel_maas);
        }
    }
}
