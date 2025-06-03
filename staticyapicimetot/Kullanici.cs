using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticyapicimetot
{
    internal class Kullanici
    {
        private int kullaniciID { get; set; }
        private string isim { get; set; }
        private string soyisim { get; set; }
        private  static int maas { get; set; }

        static Kullanici()
        {
            maas = 1000;
        }

        public Kullanici(int _kullaniciID, string _isim, string _soyisim )
        {
            kullaniciID = _kullaniciID;
            isim = _isim;
            soyisim = _soyisim;



        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Kullanici ID: " + kullaniciID);
            Console.WriteLine("Isim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Maas: " + maas);
        }

        public void MaasArttir(int miktar)
        {
            maas += miktar;
            Console.WriteLine("Maas " + miktar + " arttirildi. Yeni Maas: " + maas);
        }


    }
}
