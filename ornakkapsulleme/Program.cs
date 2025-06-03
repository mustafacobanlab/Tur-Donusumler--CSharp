using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornakkapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            personel.TcNo = "12345678901"; // Valid TC No

            Console.WriteLine(personel.TcNo);

            Console.ReadLine();
        }
    }
}
