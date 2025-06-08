using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassNedenKullanilir
{
    public class Ocak : Ay
    {
        public override int KanGundenolusur()
        {
             return 31;
        }

        public override int yilinKacinciAyi()
        {
            return 1;
        }

        
    }
}
