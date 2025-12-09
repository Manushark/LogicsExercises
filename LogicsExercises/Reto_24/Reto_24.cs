using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_24
{
    /*
     * EJERCICIO:
     * Explora el concepto de "decorador" y muestra cómo crearlo
     * con un ejemplo genérico.
     *
     * DIFICULTAD EXTRA (opcional):
     * Crea un decorador que sea capaz de contabilizar cuántas veces
     * se ha llamado a una función y aplícalo a una función de tu elección.
     */

    /*
     * El patrón decorador consiste en
     *  Tener una función base que hace algo.
     *  Crear otras funciones que "envuelven" esa función base.
     *  Esas funciones extras agregan comportamiento ANTES O DESPUÉS,
     *  pero SIN modificar la función original.
     */
    public class Reto_24
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine($"Mensaje: {mensaje}");
        }

        public void EnviarConLog(string mensaje)
        {
            Console.WriteLine("[LOG] Enviando mensaje...");
            EnviarMensaje(mensaje);
        }

        public void EnviarConConfirmacion(string mensaje)
        {
            EnviarMensaje(mensaje);
            Console.WriteLine("[OK] Mensaje enviado exitosamente.");
        }

    }
}
