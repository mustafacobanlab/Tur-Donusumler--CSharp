using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    public class Ogrenci
    {

        private string isim;
        private int kilo;
        public int KILO {
            get
            {
               return kilo;
            }

            set
            {
                kilo = value;

            }
        
        
        }

        public void setIsim(string _isim)
        { 
            isim = _isim;
        }
        public string getIsim()
        {
            return isim;
        }
    }
}
