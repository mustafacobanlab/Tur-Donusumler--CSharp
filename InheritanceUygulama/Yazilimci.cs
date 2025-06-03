using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    public class Yazilimci : Calisan
    {
        private string diller;
        public Yazilimci(int Id, string name, string surname, string diller) : base(Id, name, surname)
        {
            this.diller = diller;
        }
        public void formatAt(string format)
        {
            Console.WriteLine(getName() +" Şuanda "+ format + " İşletim Sistemine format işlemi yaptı." );
        }
    }
}
