using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseno_hdeleon.net
{
    public class ServerStateDisponible : ServerState
    {
        public override void Respuesta()
        {
            Console.WriteLine("Estado Servidor: Disponible. Respuesta 200");
        }
    }
}
