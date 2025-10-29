using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_09
{
    public class Reto_09
    {
        /*
         * EJERCICIO:
         * Explora el concepto de herencia según tu lenguaje. Crea un ejemplo que
         * implemente una superclase Animal y un par de subclases Perro y Gato,
         * junto con una función que sirva para imprimir el sonido que emite cada Animal.
         *
         * DIFICULTAD EXTRA (opcional):
         * Implementa la jerarquía de una empresa de desarrollo formada por Empleados que
         * pueden ser Gerentes, Gerentes de Proyectos o Programadores.
         * Cada empleado tiene un identificador y un nombre.
         * Dependiendo de su labor, tienen propiedades y funciones exclusivas de su
         * actividad, y almacenan los empleados a su cargo.
         */

        public class Animal
        {
            public string Nombre { get; set; }
            public string Habitat { get; set; }
            public char Sexo { get; set; }

            public void Comer()
            {
                Console.WriteLine("El animal esta comiendo");
            }

            public void dormir()
            {
                Console.WriteLine("El animal esta durmiendo");
            }

            public virtual void HacerSonido()
            {
                Console.WriteLine("El animal hace un sonido.");
            }

        }
         public class Perro : Animal 
         { 
            public string Raza { get; set; }
            public double Tamaño { get; set; }

            public override void HacerSonido()
            {
                Console.WriteLine("Guau guau");
            }

        }

        public class Gato : Animal
        {
            public string Raza { get; set; }
            public bool EsCazador { get; set; }

            public override void HacerSonido()
            {
                Console.WriteLine("Miau miau");
            }
        }
       



    }
}
