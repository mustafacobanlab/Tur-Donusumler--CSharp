using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Kedi : Hayvan
    {

        public Kedi(string isim) : base(isim)
        {
           

        }

        override public void sesCikar()
        {
            Console.WriteLine("Miyav miyav");
        }





    }
}
