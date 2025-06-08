using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Musteri : IMusteri, IPersonel // Bir Klass birden fazla interface'i implement edebilir.
    {                                          // Fakat bir class sadece bir class'tan inherit edebilir.
        

        public void ekle()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void getir()
        {
            Console.WriteLine("Müşteri Bilgileri Getirildi");
        }

        public void guncelle()
        {
            Console.WriteLine("Müşteri Bilgileri Güncellendi");
        }

        public void sil()
        {
            Console.WriteLine("Müşteri Silindi");
        }
    }
}
