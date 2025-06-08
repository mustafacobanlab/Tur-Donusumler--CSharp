using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOrnekUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri(1, "Ahmet" , "Demirel" , "Erkek" , "admin@admin.com");

            MusteriDurum donendurum =  musteri.MusteriEkle(musteri);

            if (donendurum == MusteriDurum.KayitBasarili)
            {
                Console.WriteLine("Müşteri Eklendi");
            }
            else
            {
                Console.WriteLine("Müşteri Eklenemedi");
            }



            Console.ReadLine();




        }
    }
}
