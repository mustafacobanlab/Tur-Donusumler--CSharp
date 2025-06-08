using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Musteri> musteriRepository = new Repository<Musteri>();

            musteriRepository.getir();
            musteriRepository.ekle(new Musteri());
            Repository<Urun> urunRepository = new Repository<Urun>();

            urunRepository.getir();

        }
    }
}
