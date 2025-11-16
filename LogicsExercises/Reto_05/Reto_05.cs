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

        //método que intercambia dos valores por referencia y cambia los valores originales
        public static void IntercambioPorReferencia(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }

    //Codigo para ejecutar el reto
    //Ejemplos de asignación de variables "por referencia"(Reto_05)
    //    Reto_05 PersonaRandom = new Reto_05();
    //    PersonaRandom.nombre = "camilo";

    //    Reto_05 PersonaRandomNo2 = new Reto_05();

    //PersonaRandomNo2 = PersonaRandom; // PersonaRandomNo2 referencia al mismo objeto que PersonaRandom

    //    PersonaRandomNo2.nombre = "Sofia"; // cambia el mismo objeto en memoria

    //    Console.WriteLine(PersonaRandom.nombre);
    //    Console.WriteLine(PersonaRandomNo2.nombre); //O sea, ambos apuntan al mismo lugar en la memoria RAM. por eso si cambias PR2 se actuliza el nombre de PR1 porque los datos estan guardados en el mismo lugar en memoria

    //    /////////////////////////////Parte2 del (Reto_05)

    //    int numero1 = 10;
    //int numero2 = 20;

    //Console.WriteLine("Antes de llamar a las funciones:");
    //    Console.WriteLine($"numero1 = {numero1}");
    //    Console.WriteLine($"numero2 = {numero2}\n");

    //    // Llamada por valor
    //    Reto_05.valor(numero1);
    //    // Llamada por referencia
    //    Reto_05.valorRef(ref numero2);

    //    Console.WriteLine("Después de llamar a las funciones:");
    //    Console.WriteLine($"numero1 = {numero1} (por valor, no cambió)");
    //    Console.WriteLine($"numero2 = {numero2} (por referencia, sí cambió)");

    //    //Por valor: la función recibe una copia del dato → cambiarlo dentro de la funcion *no afecta* al original.
    //    //Por referencia: la función recibe el dato original → cambiarlo dentro de la funcion *sí afecta* al original.


    //    Console.WriteLine("Antes de llamar a las funciones:");
    //    Console.WriteLine($"numero1 = {numero1}");
    //    Console.WriteLine($"numero2 = {numero2}\n");

    //    //(no cambia las originales)
    //    (int nuevo1, int nuevo2) = Reto_05.IntercambioPorValor(numero1, numero2);
    //    Console.WriteLine("Después de llamar a la función por valor:");
    //    Console.WriteLine($"numero1 = {numero1} (por valor, no cambió)");
    //    Console.WriteLine($"numero2 = {numero2} (por valor, no cambió)");
    //    Console.WriteLine($"nuevo1 = {nuevo1} (valor intercambiado)");
    //    Console.WriteLine($"nuevo2 = {nuevo2} (valor intercambiado)\n");

    //    //referencia (si cambia las originales)
    //    Reto_05.IntercambioPorReferencia(ref numero1, ref numero2);

    //    Console.WriteLine("Después de llamar a la función por referencia:");
    //    Console.WriteLine($"numero1 = {numero1} (por referencia, sí cambió)");
    //    Console.WriteLine($"numero2 = {numero2} (por referencia, sí cambió)");
}
