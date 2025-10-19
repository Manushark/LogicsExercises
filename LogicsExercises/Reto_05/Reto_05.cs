using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_05
{
    /*
     * EJERCICIO:
     * - Muestra ejemplos de asignación de variables "por valor" y "por referencia", según
     *   su tipo de dato.
     * - Muestra ejemplos de funciones con variables que se les pasan "por valor" y 
     *   "por referencia", y cómo se comportan en cada caso en el momento de ser modificadas.
     * (Entender estos conceptos es algo esencial en la gran mayoría de lenguajes)
     *
     * DIFICULTAD EXTRA (opcional):
     * Crea dos programas que reciban dos parámetros (cada uno) definidos como
     * variables anteriormente.
     * - Cada programa recibe, en un caso, dos parámetros por valor, y en otro caso, por referencia.
     *   Estos parámetros los intercambia entre ellos en su interior, los retorna, y su retorno
     *   se asigna a dos variables diferentes a las originales. A continuación, imprime
     *   el valor de las variables originales y las nuevas, comprobando que se ha invertido
     *   su valor en las segundas.
     *   Comprueba también que se ha conservado el valor original en las primeras.
     */
    public class Reto_05
    {
        public string nombre { get; set; }

        //Ejemplos de asignación de variables "por valor"
        static int a = 10;
        static int b = a;
        static int c = b;//aunque cambia 'b' no cambia 'a'.

        //El ejemplos de asignación de variables "por referencia" esta en el main --->


        //Ejemplos de funciones con variables que se les pasan "por valor"
        public static void valor(int x)
        {
            x = 99;
        }

        //Ejemplos de funciones con variables que se les pasan "por referencia"
        public static void valorRef(ref int x)
        {
            x = 99;
        }
        // La diferencia radica en que en "valor(int x)" se pasa una copia de la variable, 
        // por lo tanto el cambio solo afecta dentro de la función. 
        // En cambio, en "valorRef(ref int x)" se pasa una referencia al mismo espacio en memoria, 
        // por lo que el cambio modifica el valor original fuera de la función.



        //Dificultad Extra


        // método que intercambia dos valores y los retorna
        public static (int, int) IntercambioPorValor(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return (a, b);
        }

        
    }

}
