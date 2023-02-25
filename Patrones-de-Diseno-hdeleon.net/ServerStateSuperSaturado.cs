using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseno_hdeleon.net
{
    internal class ServerStateSuperSaturado : ServerState
    {
        public override void Respuesta()
        {
            Task.Delay(1000);
            Console.WriteLine("Estado Servidor: Super Saturado. Respuesta 200 con un delay de 1000");
        }
    }
}
