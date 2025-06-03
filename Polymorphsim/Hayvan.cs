using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Hayvan
    {
        public string isim { get; set; }

        public Hayvan(string isim)
        {
            this.isim = isim;
        }

        public string getIsim() { return this.isim; }

        public void setIsim(string isim)
        {
            this.isim = isim;
            
        }

        public virtual void sesCikar()
        {
            Console.WriteLine("Hayvan ses çıkarıyor.");
        }
    }
}
