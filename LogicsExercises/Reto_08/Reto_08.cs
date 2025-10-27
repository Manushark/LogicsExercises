using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
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


            //Constructor
            public Celular(string modelo, string marca)
            {
                Counter++;
                Id = Counter;
                Modelo = modelo;
                Marca = marca;
            }

            //Metodo para modificar los atributos
            public void NuevoCelular()
            {
                Console.Write("Ingrese la nueva Modelo de su telefono: ");
                this.Modelo = Console.ReadLine();
                Console.Write("Ingrese la nueva marca de su telefono: ");
                this.Marca = Console.ReadLine();
            }

            //Metodo para mostrar los atributos
            public void mostrar()
            {
                Console.WriteLine($"\n--- Serie #{Id} ---");
                Console.WriteLine($"Modelo: {Modelo}");
                Console.WriteLine($"Marca: {Marca}");
                Console.WriteLine("------------------------");
            }
        }

        //DIFICULTAD EXTRA: Implementacion de Pila

        public  class Pila
        {
            private static int Counter = 0;
            public int Id { get; set; }
            public string Dato { get; set; }

            //lista para almacenar los datos de la pila
            List<string> DatoList = new List<string>();


            public Pila()
            {
                Counter++;
                Id = Counter;
            }

            // Agrega un elemento a la pila
            public void Agregar()
            {
                while (true)
                {
                    Console.Write("Ingrese la prenda para la pila: ");
                    Dato = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(Dato))
                    {
                        DatoList.Add(Dato);
                        Console.WriteLine("============================");
                        Console.WriteLine($"Última prenda agregada: {Dato}  | Pila #{Id}");
                        Console.WriteLine("============================");
                    }
                    else
                    {
                        Console.WriteLine("Entrada vacía. No se agregó nada.");
                    }

                    Console.Write("Desea continuar agregando ropa? (S/N): ");
                    string Si = Console.ReadLine();
                    if (Si.ToLower() != "s") 
                    { 
                        break;
                    }
                  
                }
            }

            // Muestra todo el contenido de la pila
            public void MostrarPila()
            {
                Console.WriteLine($"\n=== Contenido de la Pila #{Id} ===");

                if (DatoList.Count == 0)
                {
                    Console.WriteLine("La pila está vacía.");
                    return;
                }

                // Mostrar estilo pila: del tope al fondo (LIFO)
                for (int i = DatoList.Count - 1; i >= 0; i--)
                {
                    int numero = DatoList.Count - i; // 1 para el tope, 2 siguiente, etc.
                    Console.WriteLine($"[{numero}] {DatoList[i]}");
                }

                Console.WriteLine("------------------------");
            }


            // Saca el último elemento (tope) de forma segura
            public void SacarRopa()
            {
                if (DatoList.Count == 0)
                {
                    Console.WriteLine("No se puede sacar: la pila está vacia.");
                    return;
                }

                string sacado = DatoList[DatoList.Count - 1];// obtiene el ultimo elemento
                DatoList.RemoveAt(DatoList.Count - 1);// elimina el ultimo elemento
                Console.WriteLine($"Se saco: {sacado}  | Pila #{Id}");
            }
        }

        //DIFICULTAD EXTRA: Implementacion de Cola

        public class Cola
        {
            //Tomorrow
        }






        ///Ejemplo de uso de la clase Celular para crear varios objetos
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
