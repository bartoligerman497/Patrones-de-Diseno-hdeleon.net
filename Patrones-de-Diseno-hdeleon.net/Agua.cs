using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseno_hdeleon.net
{
    internal class Agua : Bebida
    {
        public override int EvaporacionPorHora()
        {
            return 20;
        }
    }
}
