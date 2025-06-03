using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Kopek : Hayvan
    {
        public Kopek(string isim) : base(isim)
        {
        }
        override public void sesCikar()
        {
            Console.WriteLine("Hav hav");
        }
    }
    
  }

