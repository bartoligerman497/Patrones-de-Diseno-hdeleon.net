using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseno_hdeleon.net
{
    public class ServidorContext
    {
        private ServerState state;

        public ServerState State { get => state; set => state = value; }


        public void AtenderSolicitud()
        {
            state.Respuesta();
        }

    }

}
