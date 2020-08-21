using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entAFP
    {
        public int idAfp { set; get; }
        public string Afp { set; get; }

        public override string ToString()
        {
            return Afp;
        }
    }
}
