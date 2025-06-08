using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class SqlServer : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("sql server ekledi");
        }

        public void getir()
        {
            Console.WriteLine("sql server getirildi");
        }

        public void guncelle()
        {
            Console.WriteLine("sql server güncellendi");
        }

        public void sil()
        {
            Console.WriteLine("sql server silindi");
        }
    }
}
