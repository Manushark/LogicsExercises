using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicsExercises.Interfaces;

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


        //Dificultad Extra 
        public class SimpleMessage : IMessage
        {
            public string Get()
            {
                return "Hola Manuel";
            }
        }

        public class CountMessageCalls : IMessage
        {
            //Esto es un campo privado que almacena la instancia de IMessage que se está decorando
            private readonly IMessage _message;
            
            /*Esto es un decorador que cuenta las veces que se llama al método Get() de IMessage*/
            public int Counter { get; private set; } = 0;

            public CountMessageCalls(IMessage message)
            {
                _message = message;//asigna cuando se crea la instancia a la variable privada _message la instancia de IMessage que se está decorando
            }

            public string Get()
            {
                Counter++; // Cada vez que se llama, se suma 1
                return _message.Get();
            }
        }

        public void Run()
        {
            IMessage mensaje = new SimpleMessage();

            // Decorador que cuenta llamadas
            var contador = new CountMessageCalls(mensaje);//Se crea una instancia de CountMessageCalls que envuelve a la instancia de SimpleMessage

            Console.WriteLine(contador.Get());
            Console.WriteLine(contador.Get());
            Console.WriteLine(contador.Get());

            Console.WriteLine($"Llamadas realizadas: {contador.Counter}");
        }

    }
}
