﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AltSinif altSinif = new AltSinif();
            altSinif.metot(); // TemelSinif metodu
            altSinif.metot2(); // AltSinif metodu

            Console.ReadLine();
        }
    }
}
