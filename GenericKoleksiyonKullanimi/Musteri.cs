using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonKullanimi
{
    public class Musteri
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string email { get; set; }

        public Musteri(int id, string ad, string soyad, string email)
        {
            this.id = id;
            this.ad = ad;
            this.soyad = soyad;
            this.email = email;
        }

        public override string ToString() { 
          return $"ID: {id}, Ad: {ad}, Soyad: {soyad}, Email: {email}";
        }
    }
}
