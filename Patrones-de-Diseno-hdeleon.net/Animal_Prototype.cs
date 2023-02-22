using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseno_hdeleon.net
{
    // Clonacion (prototype) superficial -> tipos básicos no objetos
    internal class Animal_Prototype : ICloneable
    {
        public int patas { get; set; }
        public string nombre { get; set; }

        public Detalles detalles { get; set; }

        public object Clone()
        {
            Animal_Prototype animalClonado = this.MemberwiseClone() as Animal_Prototype;
            
            Detalles detalles = new Detalles();

            detalles.color = this.detalles.color;
            detalles.animal = this.detalles.animal;

            animalClonado.detalles = detalles;

            return animalClonado;
           //return this.MemberwiseClone() as Animal_Prototype;
        }
    }

    // Clonacion (protorype) profundidad
    public class Detalles
    {
        public string color { get; set; }
        public string animal { get; set; }
    }
}
