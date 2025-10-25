using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_07
{
    /*
     * EJERCICIO:
     * Implementa los mecanismos de introducción y recuperación de elementos propios de las
     * pilas (stacks - LIFO) y las colas (queue - FIFO) utilizando una estructura de array
     * o lista (dependiendo de las posibilidades de tu lenguaje).
     *
     * DIFICULTAD EXTRA (opcional):
     * - Utilizando la implementación de pila y cadenas de texto, simula el mecanismo adelante/atrás
     *   de un navegador web. Crea un programa en el que puedas navegar a una página o indicarle
     *   que te quieres desplazar adelante o atrás, mostrando en cada caso el nombre de la web.
     *   Las palabras "adelante", "atrás" desencadenan esta acción, el resto se interpreta como
     *   el nombre de una nueva web.
     * - Utilizando la implementación de cola y cadenas de texto, simula el mecanismo de una
     *   impresora compartida que recibe documentos y los imprime cuando así se le indica.
     *   La palabra "imprimir" imprime un elemento de la cola, el resto de palabras se
     *   interpretan como nombres de documentos.
     */
    public class Reto_07
    {
        public static void Run()
        {
            //Stacks - LIFO
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine($"Ultimo agregado: {stack.Peek()}");// muestra el ultimo en la lista sin quitarlo

            //var pila = stack; //convierte la pila en un array

            //foreach (var x in pila) Console.WriteLine(x); // itera desde la cima hacia abajo


            ////elimina el ultimo agregado
            //Console.WriteLine($"Desencolo o elimino este ultimo de la pila: {stack.Pop()}");

            //foreach (var x in pila) Console.WriteLine(x); // itera desde la cima hacia abajo


            //while (stack.Count > 0)
            //{
            //    // Pop() elimina y devuelve el elemento de la cima
            //    Console.WriteLine($"Desapilando: {stack.Pop()}");
            //}

            //stack.Clear();


            ////Queue - FIFO
            Queue<string> Queque = new Queue<string>();
            Queque.Enqueue("Primero");// agrega al final de la cola
            Queque.Enqueue("Segundo");
            Queque.Enqueue("Tercero");

            foreach (var item in Queque)// muestra todos los elementos en la cola
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Primer que debe salir: {Queque.Peek()}");// muestra el primer elemento sin eliminarlo

            //Gracias a C# y su libreria System.Collections.Generic podemos usar Queue directamente sin tener que implementarla desde 0 👏🏼

            Console.WriteLine($"Desencolo o elimino este primero de la cola: {Queque.Dequeue()}");// elimina el primer elemento agregado

            foreach (var item in Queque)// muestra todos los elementos en la cola
            {
                Console.WriteLine(item);
            }

            while (Queque.Count > 0)
            {
                // Dequeue() elimina y devuelve el elemento al frente o sea que te da el orden y lo borra
                Console.WriteLine($"Desencolando: {Queque.Dequeue()}");
            }

            // Asegura que la capacidad de la cola sea al menos el valor especificado
            Queque.EnsureCapacity(25);

            //elimina todos los elementos de la cola
            Queque.Clear();

        }

        //DIFICULTAD EXTRA (opcional):

        public static void web()
        {

            Stack<string> stack = new Stack<string>();

            while (true)
            {
                Console.Write("Ingrese una URL o Interctue con el programa atras/salir: ");
                string In = Console.ReadLine();

                if (In == "salir")
                {
                    Console.WriteLine("Saliendo del navegador");
                    break;
                }
                else if (In == "atras")
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else
                {
                    stack.Push(In);
                }

                if (stack.Count > 0)
                {
                    Console.WriteLine($"Has navegado a la página {stack.Peek()}");
                }
                else
                {
                    Console.WriteLine("Estas en la pagina de inicio");
                }
            }
        }

        //Conpilar con --> Reto_07.web();

        public static void printer()
        { 

            Queue<string> pila = new Queue<string>();

            while (true)
            {
                Console.Write("Ingrese el documento que desea imprimir o utiliza los siguiente comandos apagar/imprimir ");
                string imp = Console.ReadLine();

                if (imp == "apagar")
                {
                    Console.WriteLine("apagando la impresora");
                    break;
                }
                else if (imp == "imprimir")
                {
                    if (pila.Count > 0)
                        pila.Dequeue();
                }
                else
                {
                    pila.Enqueue(imp);
                }

                Console.WriteLine("==========Cola de impresion========= ");
                foreach (string listar in pila) { Console.WriteLine(listar); }
                
            }
            // Compilar con --> Reto_07.printer();

        }

        /// INFORMACION PARA RECORDAR (SINTAXIS)
        ///En caso de querer usar una clase para manejar las estructuras de datos
        //public class Estructuras
        //{
        //    // Campos de la clase
        //    private Stack<int> pila;   // Pila de enteros
        //    private Queue<int> cola;   // Cola de enteros

        //    // Constructor
        //    public Estructuras()
        //    {
        //        pila = new Stack<int>();
        //        cola = new Queue<int>();
        //    }

        //    // Métodos para la pila
        //    public void AgregarAPila(int valor)
        //    {
        //        pila.Push(valor);
        //    }

        //    public void MostrarPila()
        //    {
        //        Console.WriteLine("Elementos en la pila:");
        //        foreach (var item in pila)
        //            Console.WriteLine(item);
        //    }

        //    // Métodos para la cola
        //    public void AgregarACola(int valor)
        //    {
        //        cola.Enqueue(valor);
        //    }

        //    public void MostrarCola()
        //    {
        //        Console.WriteLine("Elementos en la cola:");
        //        foreach (var item in cola)
        //            Console.WriteLine(item);
        //    }
        //}

    }
}
