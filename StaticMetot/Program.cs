using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel.adsoyadyazdir(); // Static method call to print name
            Personel.sayilarTopla(5, 10); // Static method call to sum two numbers

            Personel personel = new Personel(); // Creating an instance of Personel class

            personel.calisanId = 1; // Setting employee ID
            personel.ad = "Mustafa"; // Setting first name
            personel.soyad = "Çoban"; // Setting last name

            Personel.maas = 10000; // Setting static property 'maas' for the Personel class

            Console.WriteLine("Çalışan ID: " +personel.calisanId +" Çalışan İsim Soyisim: "+ personel.ad +" " +personel.soyad + " Çalışan Maaş: " + Personel.maas);




            Console.ReadLine();
        }
    }
}
