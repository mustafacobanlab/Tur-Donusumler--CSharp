using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassNedenKullanilir
{
    public abstract class Ay
    {
        public int gunSaati()
        {
            return 24;
        }
        public abstract int KanGundenolusur();
        public abstract int yilinKacinciAyi();


    }
}
