using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
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
            OlympicManager olympics = new OlympicManager();
            List<Participant> participant = new List<Participant>();

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
                        olympics.RegisterEvent();
                        break;
                    case 2:
                        Console.WriteLine("Registro de participantes seleccionado.");
                        olympics.RegisterParticipant();
                        break;
                    case 3:
                        Console.WriteLine("Simulación de eventos seleccionado.");
                        olympics.SimulateEvents();
                        break;
                    case 4:
                        Console.WriteLine("Creación de informes seleccionado.");
                        olympics.ShowReport();
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

        public class OlympicManager
        {
            private readonly List<string> events = new();
            private readonly Dictionary<string, List<Participant>> participants = new();
            private readonly Dictionary<string, List<Participant>> eventResults = new();
            private readonly Dictionary<string, Dictionary<string, int>> countryResults = new();


            //Registro de eventos
            public void RegisterEvent()
            {
                Console.Write("Introduce el nombre del evento deportivo: ");
                string eventName = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(eventName))
                {
                    Console.WriteLine("Nombre de evento inválido.");
                    return;
                }

                if (events.Contains(eventName))
                {
                    Console.WriteLine($"El evento {eventName} ya está registrado.");
                    return;
                }

                events.Add(eventName);
                Console.WriteLine($"Evento {eventName} registrado correctamente.");
            }

            //Registro de participantes
            public void RegisterParticipant()
            {
                if (events.Count == 0)
                {
                    Console.WriteLine("No hay eventos registrados. Por favor, registra uno primero.");
                    return;
                }

                Console.Write("Introduce el nombre del participante: ");
                string name = Console.ReadLine()?.Trim();

                Console.Write("Introduce el país del participante: ");
                string country = Console.ReadLine()?.Trim();

                Participant participant = new Participant(name, country);

                Console.WriteLine("Eventos deportivos disponibles:");
                for (int i = 0; i < events.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {events[i]}");
                }

                Console.Write("Selecciona el número del evento para asignar al participante: ");
                if (!int.TryParse(Console.ReadLine(), out int eventChoice) ||
                    eventChoice < 1 || eventChoice > events.Count)
                {
                    Console.WriteLine("Selección de evento deportivo inválida.");
                    return;
                }

                string selectedEvent = events[eventChoice - 1];

                if (!participants.ContainsKey(selectedEvent))
                {
                    participants[selectedEvent] = new List<Participant>();
                }

                if (participants[selectedEvent]
                    .Any(p => p.Name == participant.Name && p.Country == participant.Country))
                {
                    Console.WriteLine(
                        $"El participante {name} de {country} ya está registrado en el evento deportivo {selectedEvent}.");
                    return;
                }

                participants[selectedEvent].Add(participant);
                Console.WriteLine(
                    $"El participante {name} de {country} se ha registrado en el evento deportivo {selectedEvent}.");
            }

            // Simulación de eventos
            public void SimulateEvents()
            {
                Random random = new Random();

                foreach (var ev in events)
                {
                    if (!participants.ContainsKey(ev) || participants[ev].Count < 3)
                    {
                        Console.WriteLine($"No hay suficientes participantes para el evento {ev}.");
                        continue;
                    }

                    var winners = participants[ev]
                        .OrderBy(x => random.Next())
                        .Take(3)
                        .ToList();

                    eventResults[ev] = winners;

                    AssignMedal(winners[0].Country, "gold");
                    AssignMedal(winners[1].Country, "silver");
                    AssignMedal(winners[2].Country, "bronze");

                    Console.WriteLine($"\nResultados del evento {ev}:");
                    Console.WriteLine($"1- {winners[0].Name} ({winners[0].Country})");
                    Console.WriteLine($"2- {winners[1].Name} ({winners[1].Country})");
                    Console.WriteLine($"3- {winners[2].Name} ({winners[2].Country})");
                }

            }
            // Asignar medallas
            private void AssignMedal(string country, string medal)
            {
                if (!countryResults.ContainsKey(country))
                {
                    countryResults[country] = new Dictionary<string, int>
                    {
                    { "gold", 0 },
                    { "silver", 0 },
                    { "bronze", 0 }
                    };
                }

                countryResults[country][medal]++;
            }

            // Creación de informes
            public void ShowReport()
            {
                Console.WriteLine("\n===== INFORME POR EVENTO =====");

                // Si aún no se ha simulado ningún evento
                if (eventResults.Count == 0)
                {
                    Console.WriteLine("No hay resultados registrados. Primero simula los eventos.");
                    return;
                }

                // Mostrar ganadores por evento
                foreach (var ev in eventResults)
                {
                    Console.WriteLine($"\nEvento: {ev.Key}");
                    Console.WriteLine($"1- {ev.Value[0].Name} ({ev.Value[0].Country})");
                    Console.WriteLine($"2- {ev.Value[1].Name} ({ev.Value[1].Country})");
                    Console.WriteLine($"3- {ev.Value[2].Name} ({ev.Value[2].Country})");
                }

                Console.WriteLine("\n===== RANKING DE PAÍSES =====");

                // Ordenamos los países por cantidad de medallas
                foreach (var country in countryResults
                    .OrderByDescending(c => c.Value["gold"])
                    .ThenByDescending(c => c.Value["silver"])
                    .ThenByDescending(c => c.Value["bronze"]))
                {
                    Console.WriteLine(
                        $"{country.Key} → 1{country.Value["gold"]} 2-{country.Value["silver"]} 3{country.Value["bronze"]}");
                }
            }
        }


        public class Participant
        {
            public string Name { get; set; }
            public string Country { get; set; }

            public Participant(string name, string country)
            {
                Name = name;
                Country = country;
            }
        }
        

    }

}
