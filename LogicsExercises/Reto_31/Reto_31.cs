using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_31
{
    public class Reto_31
    {
        /*
         * EJERCICIO:
         * ¡Los JJOO de París 2024 han comenzado!
         * Crea un programa que simule la celebración de los juegos.
         * El programa debe permitir al usuario registrar eventos y participantes,
         * realizar la simulación de los eventos asignando posiciones de manera aleatoria
         * y generar un informe final. Todo ello por terminal.
         * Requisitos:
         * 1. Registrar eventos deportivos.
         * 2. Registrar participantes por nombre y país.
         * 3. Simular eventos de manera aleatoria en base a los participantes (mínimo 3).
         * 4. Asignar medallas (oro, plata y bronce) basándose en el resultado del evento.
         * 5. Mostrar los ganadores por cada evento.
         * 6. Mostrar el ranking de países según el número de medallas.
         * Acciones:
         * 1. Registro de eventos.
         * 2. Registro de participantes.
         * 3. Simulación de eventos.
         * 4. Creación de informes.
         * 5. Salir del programa.
         */

        public void Olympics()
        {
            Console.WriteLine("¡Bienvenido a la simulación de los JJOO de París 2024!");

            Console.WriteLine("1. Registro de eventos."); 
            Console.WriteLine("2. Registro de participantes."); 
            Console.WriteLine("3. Simulación de eventos.");
            Console.WriteLine("4. Creación de informes.");
            Console.WriteLine("5. Salir del programa.");

            int Option = Convert.ToInt32(Console.ReadLine()); 
            switch (Option)
            {
                case 1:
                    Console.WriteLine("Registro de eventos seleccionado.");
                    break;
                case 2:
                    Console.WriteLine("Registro de participantes seleccionado.");
                    break;
                case 3:
                    Console.WriteLine("Simulación de eventos seleccionado.");
                    break;
                case 4:
                    Console.WriteLine("Creación de informes seleccionado.");
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, selecciona una opción del 1 al 5.");
                    break;
            }
        }
    }
}
