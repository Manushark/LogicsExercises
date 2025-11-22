using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_18
{
    /*
     * EJERCICIO:
     * Utilizando tu lenguaje crea un conjunto de datos y realiza las siguientes
     * operaciones (debes utilizar una estructura que las soporte):
     * - Añade un elemento al final.
     * - Añade un elemento al principio.
     * - Añade varios elementos en bloque al final.
     * - Añade varios elementos en bloque en una posición concreta.
     * - Elimina un elemento en una posición concreta.
     * - Actualiza el valor de un elemento en una posición concreta.
     * - Comprueba si un elemento está en un conjunto.
     * - Elimina todo el contenido del conjunto.
     *
     * DIFICULTAD EXTRA (opcional):
     * Muestra ejemplos de las siguientes operaciones con conjuntos:
     * - Unión.
     * - Intersección.
     * - Diferencia.
     * - Diferencia simétrica.
     */
    public class Reto_18
    {
        List<int> Numbers = new List<int>() { 5, 6, 45, 48, 63, 84, 53, 23 };
        List<int> Numbers2 = new List<int>() { 2, 3, 4, 7, 8, 9 };

        public void Run()
        {
            // Añade un elemento al final
            Numbers.Add(5);

            // Añade un elemento al principio
            Numbers.Insert(0, 100);// Se usa Insert para añadir en una posicion concreta

            // Añade varios elementos en bloque al final
            Numbers.AddRange(Numbers2);

            // Añade varios elementos en bloque en una posición concreta
            Numbers.InsertRange(2, new List<int> { 777, 888, 909 }); // Se usa InsertRange para añadir varios elementos en una posicion concreta

            // Elimina un elemento en una posición concreta
            Numbers.RemoveAt(3);

            // Actualiza un elemento en una posición concreta
            Numbers[2] = 999; 

            // Añadir un número al inicio leído por usuario
            Console.Write("Introduzca aqui el numero con que iniciara la lista: ");
            int Nuew = Convert.ToInt32(Console.ReadLine()); 
            Numbers.Insert(0, Nuew); 

            // Buscar elemento
            int search = Numbers.Find(x => x == 48);
            Console.WriteLine($"Se encontro dentro de la lista el numero: {search}");

            // Comprobar si un elemento está en el conjunto
            bool Super = Numbers.Contains(777);
            Console.WriteLine(Super ?
                "Si hay un 777 dentro de la lista" :
                "No está ese número en la lista");// Se usa Contains para comprobar si un elemento está en la lista y también se usa un operador ternario para mostrar un mensaje u otro dependiendo del resultado

            // Recorrer
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }

            // Eliminar todo
            Console.WriteLine("Se eliminara todo");
            Numbers.Clear();

            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }

        // DIFICULTAD EXTRA
        public void Difficulty() { 
            HashSet<int> SetA = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> SetB = new HashSet<int>() { 4, 5, 6, 7, 8 };

            //Union
            var a = SetA.Union(SetB);//Union une dos conjuntos sin repetir elementos

            foreach (int i in a) {
                Console.WriteLine($"UNION: {i}");
            }

            Console.WriteLine("-----"); 

            //Intersection
            var b = SetA.Intersect(SetB); //Intersect devuelve los elementos que están en ambos conjuntos
            foreach (int i in b) {
                Console.WriteLine("INTERSECTION: " + i);
            }

            Console.WriteLine("-----");

            // Except (Diferencia)
            var c = SetA.Except(SetB); //Except devuelve los elementos que están en el primer conjunto pero no en el segundo

            Console.WriteLine("Diferencia de A−B");

            foreach (int i in c)
            {
                Console.WriteLine("DIFFERENCE: " + i);
            }

            Console.WriteLine("-----");


            var c2 = SetB.Except(SetA); //Except devuelve los elementos que están en el segundo conjunto pero no en el primero
            Console.WriteLine("Diferencia de B−A");
            foreach (int i in c2)
            {
                Console.WriteLine("DIFFERENCE: " + i);
            }

            Console.WriteLine("-----");

            //SymmetricExceptWith

            SetA.SymmetricExceptWith(SetB); //SymmetricExceptWith devuelve los elementos que están en ambos conjuntos pero no en ambos a la vez
            foreach (int i in SetA) {
                Console.WriteLine($"SYMMETRIC DIFFERENCE: {i}");
            }

        }

        //Codigo para ejecutar el reto 
        //Reto_18 reto_18 = new Reto_18();
        //reto_18.Difficulty();
    }

}
