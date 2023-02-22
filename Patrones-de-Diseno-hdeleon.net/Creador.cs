using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseno_hdeleon.net
{
    internal class Creador
    {
        public const int coca = 1;
        public const int agua = 2;

        public static Bebida CreadorBebida(int tipo)
        {
            switch (tipo)
            {
                case coca: 
                    return new Coca();
                case agua: 
                    return new Agua();
                default:
                    return null;
            }
        }
    }
}
