using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LogicsExercises.Reto_08
{
    public class Reto_08
    {
        /*
         * EJERCICIO:
         * Explora el concepto de clase y crea un ejemplo que implemente un inicializador,
         * atributos y una función que los imprima (teniendo en cuenta las posibilidades
         * de tu lenguaje).
         * Una vez implementada, créala, establece sus parámetros, modifícalos e imprímelos
         * utilizando su función.
         *
         * DIFICULTAD EXTRA (opcional):
         * Implementa dos clases que representen las estructuras de Pila y Cola (estudiadas
         * en el ejercicio número 7 de la ruta de estudio)
         * - Deben poder inicializarse y disponer de operaciones para añadir, eliminar,
         *   retornar el número de elementos e imprimir todo su contenido.
         */
        public class Celular 
        {
            private static int Counter = 0;
            public int Id { get; set; }
            public string Modelo { get; set; }
            public string Marca { get; set; }



            public Celular(string modelo, string marca)
            {
                Counter++;
                Id = Counter;
                Modelo = modelo;
                Marca = marca;
            }

            public void NuevoCelular()
            {
                Console.Write("Ingrese la nueva Modelo de su telefono: ");
                this.Modelo = Console.ReadLine();
                Console.Write("Ingrese la nueva marca de su telefono: ");
                this.Marca = Console.ReadLine();
            }

            public void mostrar()
            {
                Console.WriteLine($"\n--- Serie #{Id} ---");
                Console.WriteLine($"Modelo: {Modelo}");
                Console.WriteLine($"Marca: {Marca}");
                Console.WriteLine("------------------------");
            }
        }


        //List<Celular> telefonos = new List<Celular>();

        //while (true)
        //{

        //    Celular Cell = new Celular("Nada", "Nada");
        //    Cell.NuevoCelular();
        //    telefonos.Add(Cell);

        //    Console.Write("¿Desea agregar otra tarea? (s/n): ");
        //    string respuesta = Console.ReadLine();

        //    if (respuesta.ToLower() != "s")
        //        break; // Rompe el ciclo

        //}

        //foreach (Celular scer in telefonos)
        //{
        //    scer.mostrar();
        //}
    }
}
