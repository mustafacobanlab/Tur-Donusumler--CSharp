using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class MusteriController
    {
        public void SqlEkle(SqlServer sqlServer)
        {
            sqlServer.ekle();
        }
    }
}
