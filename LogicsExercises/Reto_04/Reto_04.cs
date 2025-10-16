using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_04
{
    /*
     * EJERCICIO:
     * - Crea ejemplos de funciones básicas que representen las diferentes
     *   posibilidades del lenguaje:
     *   Sin parámetros ni retorno, con uno o varios parámetros, con retorno...
     * - Comprueba si puedes crear funciones dentro de funciones.
     * - Utiliza algún ejemplo de funciones ya creadas en el lenguaje.
     * - Pon a prueba el concepto de variable LOCAL y GLOBAL.
     * - Debes hacer print por consola del resultado de todos los ejemplos.
     *   (y tener en cuenta que cada lenguaje puede poseer más o menos posibilidades)
     *
     * DIFICULTAD EXTRA (opcional):
     * Crea una función que reciba dos parámetros de tipo cadena de texto y retorne un número.
     * - La función imprime todos los números del 1 al 100. Teniendo en cuenta que:
     *   - Si el número es múltiplo de 3, muestra la cadena de texto del primer parámetro.
     *   - Si el número es múltiplo de 5, muestra la cadena de texto del segundo parámetro.
     *   - Si el número es múltiplo de 3 y de 5, muestra las dos cadenas de texto concatenadas.
     *   - La función retorna el número de veces que se ha impreso el número en lugar de los textos.
     *
     * Presta especial atención a la sintaxis que debes utilizar en cada uno de los casos.
     * Cada lenguaje sigue una convenciones que debes de respetar para que el código se entienda.
     */
    public class Reto_04 // en C# no son funciones sino que se llaman metodos. 
    {
        /// <summary>
        ///   Crea ejemplos de funciones básicas que representen las diferentes
        ///   posibilidades del lenguaje:
        ///   Sin parámetros ni retorno, con uno o varios parámetros, con retorno...
        /// </summary>
        // No recibe nada y no devuelve nada
        public static void Saludar()
        {
            Console.WriteLine("¡Hola!");
        }

        // recibe un string y devuelve un saludo
        public static void Jimi(string omaga)
        {
            Console.WriteLine($"Hola: {omaga}");
        }
        
        //sin parametros, pero con valor de retorno
        public static int ramdomNumer()
        { 
            Random random = new Random();
            return random.Next(1, 99);
        }

        //Por parametros y valode de retorno
        public static int suma(int num1, int num2) 
        {
           Console.WriteLine(num1 + num2);
           return num1 + num2;
        }

        //Con varios parametros de diferentes tipos
        public static string registro(int id, string nombre)
        {
            return $"id: {id}, nombre: {nombre}";
        }

        ///Las funciones ya creadas son Console.WriteLine o Random.Next() que ya estamos usando.

        /// <summary>
        /// Comprueba si puedes crear funciones dentro de funciones.
        /// </summary>

        public static void nombre()
        {
            Console.WriteLine("manuel");

            void otraFuncion() { Console.WriteLine("Las Funciones anidadas funcionan"); }
            otraFuncion();
        }

        /// <summary>
        /// Pon a prueba el concepto de variable LOCAL y GLOBAL.
        /// </summary>
        
        //variable local
        public static int sumas() 
        {
            int local = 9;
            return local + 5;
        }

        //variable global 
        static string varibleGlobal = "hola";

        public static string global()
        {
            return varibleGlobal;
        }
    }
}
