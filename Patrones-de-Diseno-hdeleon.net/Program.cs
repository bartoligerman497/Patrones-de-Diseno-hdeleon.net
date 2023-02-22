using Patrones_de_Diseno_hdeleon.net;
using System.ComponentModel;

/*
// Clase 1/10
// Patrón de Diseño: Singleton.

Console.WriteLine(Singleton.Instance.mensaje);

Singleton.Instance.mensaje = "Sobrescribiendo el mensaje";

Console.WriteLine(Singleton.Instance.mensaje);
*/

/*
// Clase 2/10
// Patrón de Diseño: Prototype Shallow. 
// Clonar un objeto
// Sirve para hacer una reserva de mi objeto. Ej. Sesiónes, ctrl + z, etc. 

Animal_Prototype oAnimal = new Animal_Prototype() { nombre = "Oveja Dolly", patas = 4};

// Se pisan las variables
// Forma Incorrecta

//Animal_Prototype oAnimalClonado = oAnimal;
//oAnimalClonado.patas = 5;

//Console.WriteLine(oAnimal.patas);

//Console.WriteLine(oAnimalClonado.patas);

// Forma Correcta
Animal_Prototype oAnimalClonado = oAnimal.Clone() as Animal_Prototype;
oAnimalClonado.patas = 5;

Console.WriteLine(oAnimal.patas);

Console.WriteLine(oAnimalClonado.patas);
*/

/*
// Clase 3/10
// Patrón de Diseño: Prototype Deep 
// Clonar un objeto que tiene objetos dentro

// Animal Original
Animal_Prototype oAnimal = new Animal_Prototype() { nombre = "Oveja Dolly", patas = 4 };
oAnimal.detalles = new Detalles();
oAnimal.detalles.color = "Azul";
oAnimal.detalles.animal = "Oveja";

// Animal Clonado
Animal_Prototype oAnimalClonado = oAnimal.Clone() as Animal_Prototype;
oAnimalClonado.detalles.color = "Verde";

// Patron de diseño profundo se pisan las variables mal
// Se pisan las variables

Console.WriteLine("Animal Original");
Console.WriteLine("Nombre: " + oAnimal.nombre);
Console.WriteLine("Color: " + oAnimal.detalles.color);
Console.WriteLine();
Console.WriteLine("Animal Clonado");
Console.WriteLine("Nombre: " + oAnimalClonado.nombre);
Console.WriteLine("Color: " + oAnimalClonado.detalles.color);

// La manera correcta es hacerlo en la clase, método Clone()
*/

/*
// Clase 4/10
// Patrón de Diseño: Factory Method
// Varios objetos que heredan de la misma clase, 

Bebida oBebidaAgua = Creador.CreadorBebida(Creador.agua);
Console.WriteLine(oBebidaAgua.EvaporacionPorHora());

Bebida oBebidaCoca = Creador.CreadorBebida(Creador.coca);
Console.WriteLine(oBebidaCoca.EvaporacionPorHora());
*/


// Clase 5/10
// Patrón de Diseño: Strategy. organiza el comportamiento que va a tener un objeto, el comportamiento cambia dinamicamente en tiempo de ejecución

// 3 componentes
// Contexto
// estrategia
// estrategia concreta

// Ej. de uso: Hacer 2 métodos iguales, que llamen a 2 sevicios diferentes, si uno esta caído, uso el otro

EstrategiasTrabajarContexto oPersona = new EstrategiasTrabajarContexto();

//oPersona.Trabajar();
//oPersona.EstablecerTrabajarMucho();
//oPersona.Trabajar();

oPersona.Trabajar(EstrategiasTrabajarContexto.Comportamiento.TrabajarMucho);
oPersona.Trabajar(EstrategiasTrabajarContexto.Comportamiento.TrabajarDuro);