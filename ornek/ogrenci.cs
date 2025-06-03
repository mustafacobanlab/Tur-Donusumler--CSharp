using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek
{
    public class ogrenci
    {
        private int ogrno;
        private string ad;
        private string soyad;

        private int vize1;
        private int vize2;
        private int final;

        private string okulAdi;

        public void OgrenciBilgileriniGoster()
        {
            Console.WriteLine("Öğrenci No: " + ogrno);
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Okul Adı: " + okulAdi);
            Console.WriteLine($"Öğrenci Vize 1: {vize1}");
            Console.WriteLine($"Öğrenci Vize 2: {vize2}");
            Console.WriteLine($"Öğrenci Final: {final}");
        }

        public double ortalamaBul()
        {
            double ortalama = (vize1 * 0.2) + (vize2 * 0.2) +(final * 0.6);
            return ortalama;
        }
        
        public void okulgetir()
        {
            Console.WriteLine("Okul Adı: " + okulAdi);
        }

        public ogrenci(int _ogrno,string _ad, string _soyad, string _okulAdi, int _vize1, int _vize2, int _final )
        {
            ogrno = _ogrno;
            ad = _ad;
            soyad = _soyad;
            okulAdi = _okulAdi;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
        }

    }
}
