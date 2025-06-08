using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //ArrayList koleksiyon = new ArrayList();
            //koleksiyon.Add("Elma");
            //koleksiyon.Add("Armut");
            //koleksiyon.Add(2);
            //koleksiyon.Add(2.5);

            degerekle(5);
            degerekle(1);


        }
        static void degerekle(int deger)
        {
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add(deger);

        }
    }
}
