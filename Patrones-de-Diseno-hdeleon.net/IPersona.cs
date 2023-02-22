using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseno_hdeleon.net
{
    internal interface IPersona
    {
        void Trabajar();
    }

    class EstrategiaTrabajarMucho : IPersona
    {
        public void Trabajar()
        {
            Console.WriteLine("Trabajo Mucho!");
        }
    }

    class EstrategiaTrabajarDuro : IPersona
    {
        public void Trabajar()
        {
            Console.WriteLine("Trabajo Duro!");
        }
    }

    /*******************************************************************************/


    class EstrategiasTrabajarContexto
    {
        private IPersona oPersona;

        public enum Comportamiento
        {
            TrabajarMucho, TrabajarDuro
        }

        public EstrategiasTrabajarContexto()
        {
            // Por defecto
            this.oPersona = new EstrategiaTrabajarMucho();
        }

        /*
        public void EstablecerTrabajarMucho()
        {
            this.oPersona = new EstrategiaTrabajarMucho();
        }

        public void EstablecerTrabajarDuro()
        {
            this.oPersona = new EstrategiaTrabajarDuro();
        }
        */

        public void Trabajar(Comportamiento opcion)
        {
            switch (opcion)
            {
                case Comportamiento.TrabajarMucho:
                    this.oPersona = new EstrategiaTrabajarMucho();
                    break;
                case Comportamiento.TrabajarDuro:
                    this.oPersona = new EstrategiaTrabajarDuro();
                    break;
                default:
                    break;
            }

            this.oPersona.Trabajar();
        }
    }
}
