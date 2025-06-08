using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOrnekUygulama
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        
        public string Email { get; set; }


        public Musteri(int Id, string Ad, string Soyad, string Cinsiyet, string Email)
        {
            this.Id = Id;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Cinsiyet = Cinsiyet;
            this.Email = Email;

        }

        public static ArrayList musteriler = new ArrayList();

        public MusteriDurum MusteriEkle(Musteri M1)
        {
            musteriler.Add(M1);
            return MusteriDurum.KayitBasarili;
        }
    }
}
