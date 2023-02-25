using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseno_hdeleon.net
{
    public interface IMediator
    {
        // Chat
        public void Send(string message, IColleague colleague);
    }
}
