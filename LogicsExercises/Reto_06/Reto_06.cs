using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_06
{
    /*
     * EJERCICIO:
     * Entiende el concepto de recursividad creando una función recursiva que imprima
     * números del 100 al 0.
     *
     * DIFICULTAD EXTRA (opcional):
     * Utiliza el concepto de recursividad para:
     * - Calcular el factorial de un número concreto (la función recibe ese número).
     * - Calcular el valor de un elemento concreto (según su posición) en la 
     *   sucesión de Fibonacci (la función recibe la posición).
     */
    public class Reto_06
    {
        //Factorial normal para tomarlo como referencia para resolver el ejercicio
        public static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }

        //Fibonacci normal para tomarlo como referencia para resolver el ejercicio
        public static int fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return (fibonacci(n - 1) + fibonacci(n - 2));
            }
        }

    }
}
