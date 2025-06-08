using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Musteri musteri = new Musteri();
            

            MusteriController musteriController = new MusteriController();
            musteriController.SqlEkle(new SqlServer());
           




            Console.ReadLine();
        }
    }
}
