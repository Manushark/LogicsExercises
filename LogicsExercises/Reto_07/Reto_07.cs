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
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine($"Ultimo agregado: {stack.Peek()}");// muestra el ultimo en la lista sin quitarlo

            //elimina el ultimo agregado
            stack.Pop();

            while (stack.Count > 0)
            {
                // Pop() elimina y devuelve el elemento de la cima
                Console.WriteLine($"Desapilando: {stack.Pop()}");
            }

            stack.Clear();

            //Queue - FIFO
            Queue<string> Queque = new Queue<string>(); 
            Queque.Enqueue("Primero");// agrega al final de la cola
            Queque.Enqueue("Segundo");
            Queque.Enqueue("Tercero");

            foreach (var item in Queque)// muestra todos los elementos en la cola
            {
                Console.WriteLine(item);
            }

            Queque.Peek();// muestra el primer elemento sin eliminarlo

            while (Queque.Count > 0)
            {
                // Dequeue() elimina y devuelve el elemento al frente o sea que te da el orden y lo borra
                Console.WriteLine($"Desencolando: {Queque.Dequeue()}");
            }

            // Limpia la cola
            Queque.EnsureCapacity(1);

            //elimina todos los elementos de la cola
            Queque.Clear(); 
        }
    }
}
