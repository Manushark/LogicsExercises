using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        //Codigo para compilar 
        //Reto_09.Perro perro = new Reto_09.Perro();
        //perro.HacerSonido();

        //Reto_09.Gato gato = new Reto_09.Gato();
        //gato.HacerSonido();


        //DIFICULTAD EXTRA

        //* Implementa la jerarquía de una empresa de desarrollo formada por Empleados que
        //* pueden ser Gerentes, Gerentes de Proyectos o Programadores.
        //* Cada empleado tiene un identificador y un nombre.
        //* Dependiendo de su labor, tienen propiedades y funciones exclusivas de su
        //* actividad, y almacenan los empleados a su cargo.

        public class Empleado 
        {
            private static int Counter = 0;
            public int Id { get; set; }
            public string NombreCompleto { get; set; }    
            public string Telefono { get; set; }
            public List<string> Empleados { get; set; }

            public Empleado()
            {
                Counter++;
                Id = Counter;
                Empleados = new List<string>();
            }

            public string AgregarEmpleados(string add) 
            {
                Empleados.Add(add);
                Console.WriteLine($"{add} ha sido agregado a su lista de empleados");
                return add;
            }

            public virtual void MostrarInfo()//
            {
                Console.WriteLine($"Empleado: {NombreCompleto} (ID: {Id})");
            }
        }


        public class Gerente : Empleado
        { 

            
            public void Contratar()
            {
                Console.WriteLine($"{this.NombreCompleto} esta contratando nuevos empleados");
            }
            public void SupervisarEmpleados()
            {
                Console.WriteLine($"{this.NombreCompleto} esta supervisando a los empleados");
            }
        }

        public class GerenteProyectos : Empleado
        {
            public List<string> Proyectos { get; set; }

            public GerenteProyectos()
            {
                Proyectos = new List<string>();
            }

            public override void MostrarInfo()
            {
                Console.WriteLine($"Project Manager: {NombreCompleto} (ID: {Id}) - Proyectos: {Proyectos.Count}");
            }

            public void Seguimiento()
            {
                Console.WriteLine($"{this.NombreCompleto} le esta dando un seguimiento al proyecto principal");

            }
        }

        public class Programadores : Empleado
        {
            public string languaje { get; set; }

            public void CrearSoftware()
            {
                Console.WriteLine($"{this.NombreCompleto} esta programando en el lenguaje de {this.languaje}");

            }


        }

    }
   
}
