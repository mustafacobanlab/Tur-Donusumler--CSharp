using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassNedenKullanilir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Ocak ocak = new Ocak();
            Console.WriteLine(ocak.gunSaati());
            Console.WriteLine(ocak.KanGundenolusur());
            Console.WriteLine(ocak.yilinKacinciAyi());
            
            
            Subat subat = new Subat();
            Console.WriteLine(subat.gunSaati());
            
            Console.WriteLine(subat.KanGundenolusur());
            Console.WriteLine(subat.yilinKacinciAyi());
            
            Mart mart = new Mart();
            Console.WriteLine(mart.gunSaati());
            Console.WriteLine(mart.KanGundenolusur());
            Console.WriteLine(mart.yilinKacinciAyi());


            Console.ReadLine();


        }
    }
}
