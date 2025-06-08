using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Mysql : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("Mysql Eklendi");
        }
        public void getir()
        {
            Console.WriteLine("Mysql Getirildi");
        }
        public void guncelle()
        {
            Console.WriteLine("Mysql Guncellendi");
        }
        public void sil()
        {
            Console.WriteLine("Mysql Silindi");
        }
    }
    {
    }
}
