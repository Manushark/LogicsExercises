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

        //función recursiva que imprimanúmeros del 100 al 0. 
        public static void oneToOne (int x)// tal vez haya una manera mas facil de hacerla, pero esta fue la forma que se me ocurrio (Sinceramente esto de la recursividad es nuevo para mi)
        {
            if (x == 0) 
            { return; }
            else
            {
               Console.WriteLine(x);
               oneToOne(x - 1);
            }
        }

        
        ///DIFICULTAD EXTRA
        
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

        //Fibonacci con valor por defecto en la posición 12
        public static int fibonacci2(int n = 12)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return (fibonacci2(n - 1) + fibonacci2(n - 2));
            }
        }

        ///Codigo de compilacion del Reto_06
        ////////////////////////////////////Reto_06
        //Números del 100 al 0 de manera recursiva (Reto_06)
        //Reto_06.oneToOne(100);


        //Dificultad Extra

        //Factorial normal de manera recursiva 
        //int hola = Reto_06.factorial(5);
        //Console.WriteLine(hola);

        //Fibonacci de manera recursiva (Reto_06)
        //for (int i = 0; i< 12; i++)
        //{
        //    Console.WriteLine(Reto_06.fibonacci(i));
        //}

        //se imprime el valor del elemento en la posición 12 de la sucesión de Fibonacci
        //Console.WriteLine(Reto_06.fibonacci2());

        //Aprendí mucho haciendo este reto porque la recursividad es un concepto nuevo para mi y al principio me costó entenderlo, pero con la practica logre comprender c0mo funcionan las funciones recursivas y como pueden ser utilizadas para resolver problemas de manera eficiente
    }
}
