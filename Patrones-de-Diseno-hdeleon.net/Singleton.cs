using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseno_hdeleon.net
{
    internal class Singleton
    {
        private static Singleton instance = null;
        
        // Cuando no esta creado, es vacío
        public string mensaje = "";

        protected Singleton() 
        {
            mensaje = "Singleton Creado";
        }

        public static Singleton Instance
        { 
            get
            {
                if (instance==null)
                {
                    instance = new Singleton();
                }
                return instance; 
            } 
        }
    }
}
