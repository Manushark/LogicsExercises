using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicsExercises.Reto_01
{
    public class Reto_01
    {
        /*
         * EJERCICIO:
         * - Crea ejemplos utilizando todos los tipos de operadores de tu lenguaje:
         *   Aritméticos, lógicos, de comparación, asignación, identidad, pertenencia, bits...
         *   (Ten en cuenta que cada lenguaje puede poseer unos diferentes)
         * - Utilizando las operaciones con operadores que tú quieras, crea ejemplos
         *   que representen todos los tipos de estructuras de control que existan
         *   en tu lenguaje:
         *   Condicionales, iterativas, excepciones...
         * - Debes hacer print por consola del resultado de todos los ejemplos.
         *
         * DIFICULTAD EXTRA (opcional):
         * Crea un programa que imprima por consola todos los números comprendidos
         * entre 10 y 55 (incluidos), pares, y que no son ni el 16 ni múltiplos de 3.
         *
         * Seguro que al revisar detenidamente las posibilidades has descubierto algo nuevo.
         */
        public static void Run()
        {
            //Ejemplos de operadores
                int a = 10, b = 5;
            Console.WriteLine($"Aritméticos: {a} + {b} = {a + b}, {a} - {b} = {a - b}, {a} * {b} = {a * b}, {a} / {b} = {a / b}, {a} % {b} = {a % b}");

            bool x = true, y = false;
            Console.WriteLine($"Lógicos: {x} AND {y} = {x && y}, {x} OR {y} = {x || y}, NOT {x} = {!x}");

            Console.WriteLine($"Comparación: {a} == {b} = {a == b}, {a} != {b} = {a != b}, {a} > {b} = {a > b}, {a} < {b} = {a < b}, {a} >= {b} = {a >= b}, {a} <= {b} = {a <= b}");

            int c = a;
            c += b; // Asignación
            Console.WriteLine($"Asignación: c starts as a ({c - b}), then c += b results in c = {c}");

            object obj1 = new object();
            object obj2 = obj1;
            Console.WriteLine($"Identidad: obj1 is obj2: {ReferenceEquals(obj1, obj2)}");

            string str = "hello";
            Console.WriteLine($"Pertenencia: 'h' in '{str}' = {str.Contains('h')}");

            int bitA = 5; // 0101
            int bitB = 3; // 0011
            Console.WriteLine($"Bits: {bitA} & {bitB} = {bitA & bitB}, {bitA} | {bitB} = {bitA | bitB}, ~{bitA} = {bitA}, {bitA} ^ {bitB} = {bitA ^ bitB}");

            //Estructuras de control
                if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            else
            {
                Console.WriteLine($"{a} is not greater than {b}");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"For loop iteration: {i}");
                }
            }

            int count = 0;
            while (count < 5)
            {
                Console.WriteLine($"While loop count: {count}");
                count++;
            }

            try
            {
                int zero = 0;
                int result = a / zero;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            //DIFICULTAD EXTRA
                Console.WriteLine("Números entre 10 y 55, pares, que no son ni el 16 ni múltiplos de 3:");

            for (int i = 10; i <= 55; i++)
            {
                if (i == 16 || i % 3 == 0 || i % 2 != 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Numero: {i}");
                }
            }
        }
    }
}





