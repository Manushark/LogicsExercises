using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_17
{
    /*
     * EJERCICIO:
     * Utilizando tu lenguaje, emplea 3 mecanismos diferentes para imprimir
     * números del 1 al 10 mediante iteración.
     *
     * DIFICULTAD EXTRA (opcional):
     * Escribe el mayor número de mecanismos que posea tu lenguaje
     * para iterar valores. ¿Eres capaz de utilizar 5? ¿Y 10?
     */
    public class Reto_17
    {
        public void Run()
        {
            //Iteracion utilizando For
            Console.WriteLine("Iterando for");
            for (int x = 0; x <= 10; x++)
            {
                Console.WriteLine(x);
            }

            //iteracion utilizando While
            Console.WriteLine("Iterando while");
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //Iteracion utilizando do while
            Console.WriteLine("Iterando do while");
            int d = 0;
            do { Console.WriteLine(d); d++; } while (d <= 10);

        }
    }
}
