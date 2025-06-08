using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(1);
            sayiListesi.Add(2);
            sayiListesi.Add(3);
            sayiListesi.Add(4);

            foreach (int item in sayiListesi)
            {
                Console.WriteLine(item);
            }

            List<Musteri> musteriListesi = new List<Musteri>();
            musteriListesi.Add(new Musteri(1, "Ali", "Yılmaz", "admin@mail"));
            musteriListesi.Add(new Musteri(2, "Ayşe", "Demir", "user@mail"));

            foreach (Musteri musteri in musteriListesi)
            {
                Console.WriteLine(musteri);
            }

            Console.ReadLine();
        }
    }
}
