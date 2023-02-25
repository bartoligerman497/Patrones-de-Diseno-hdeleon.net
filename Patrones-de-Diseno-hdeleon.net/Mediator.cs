using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseno_hdeleon.net
{
    internal class Mediator : IMediator
    {
        private List<IColleague> _colleagueList;

        public Mediator()
        {
            _colleagueList = new List<IColleague>();
        }

        public void Add(IColleague colleague)
        {
            this._colleagueList.Add(colleague);
        }

        public void Send(string message, IColleague colleague)
        {
            foreach (var c in _colleagueList)
            {
                if (colleague != c)
                {
                    c.Receive(message);
                }
            }
        }
    }
}
