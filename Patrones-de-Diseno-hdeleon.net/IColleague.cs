using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseno_hdeleon.net
{
    public abstract class IColleague
    {
        private IMediator mediator;

        public IMediator Mediator { get { return mediator; } }

        public IColleague(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Communicate(string message)
        {
            this.mediator.Send(message, this);
        }

        public abstract void Receive(string message);
    }
}
