using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

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
            bool s = true;
            Event newEvent = new Event();

            while (s)
            {
                Console.WriteLine();
                Console.WriteLine("¡Bienvenido a la simulación de los JJOO de París 2024!");

                Console.WriteLine("======Por favor, selecciona una acción:======");
                Console.WriteLine("1. Registro de eventos.");
                Console.WriteLine("2. Registro de participantes.");
                Console.WriteLine("3. Simulación de eventos.");
                Console.WriteLine("4. Creación de informes.");
                Console.WriteLine("5. Salir del programa.");

                int Option = Convert.ToInt32(Console.ReadLine());
               
                if (Option < 1 || Option > 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción no válida, intente de nuevo");
                    Console.ResetColor();
                }


                switch (Option)
                {
                    case 1:
                        Console.WriteLine("Registro de eventos seleccionado.");
                        newEvent.AddEvent();

                        break;
                    case 2:
                        Console.WriteLine("Registro de participantes seleccionado.");
                        newEvent.ListEvents();

                        break;
                    case 3:
                        Console.WriteLine("Simulación de eventos seleccionado.");
                        break;
                    case 4:
                        Console.WriteLine("Creación de informes seleccionado.");
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        s = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, selecciona una opción del 1 al 5.");
                        break;
                }
            }
        }

        public class Event
        {
            public readonly List<string> events = new List<string>();

            public void AddEvent()
            {
                Console.WriteLine("Ingrese el nombre del evento deportivo:");
                string Name = Console.ReadLine();
                events.Add(Name);
                Console.WriteLine("Evento registrado: " + Name);
            }

            public void ListEvents()
            {
                if (events.Count == 0)
                {
                    Console.WriteLine("No hay eventos registrados.");
                    return;
                }

                Console.WriteLine($"Eventos registrados ({events.Count}):");
                foreach (var ev in events)
                {
                    Console.WriteLine($"- {ev}");
                }

            }
        }
    }
}
