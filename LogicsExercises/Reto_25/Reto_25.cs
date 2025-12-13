using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace LogicsExercises.Reto_25
{
    /*
     * EJERCICIO:
     * Explora el concepto de "logging" en tu lenguaje. Configúralo y muestra
     * un ejemplo con cada nivel de "severidad" disponible.
     *
     * DIFICULTAD EXTRA (opcional):
     * Crea un programa ficticio de gestión de tareas que permita añadir, eliminar
     * y listar dichas tareas.
     * - Añadir: recibe nombre y descripción.
     * - Eliminar: por nombre de la tarea.
     * Implementa diferentes mensajes de log que muestren información según la
     * tarea ejecutada (a tu elección).
     * Utiliza el log para visualizar el tiempo de ejecución de cada tarea.
     */
    public partial class Reto_25
    {
        public void Run()
        {
            // Logging se usa para registrar eventos que ocurren en la aplicación
            // Ayuda a depurar errores y entender el comportamiento del sistema

            //Esto es una configuración básica de logging usando Microsoft.Extensions.Logging
            using ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddConsole()
                    .SetMinimumLevel(LogLevel.Trace);
            });

            // Crear un logger para la clase Program y sirve para registrar mensajes
            ILogger logger = loggerFactory.CreateLogger<Program>();

            // Ejemplos de cada nivel
            logger.LogTrace("Mensaje TRACE: flujo interno detallado");
            logger.LogDebug("Mensaje DEBUG: información para depuración");
            logger.LogInformation("Mensaje INFO: aplicación funcionando correctamente");
            logger.LogWarning("Mensaje WARNING: algo no esperado ocurrió");
            logger.LogError("Mensaje ERROR: ocurrió un fallo");
            logger.LogCritical("Mensaje CRITICAL: fallo grave del sistema");
        }

        //Extra Difficulty
        public void TaskList() {
            using ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddConsole()
                    .SetMinimumLevel(LogLevel.Trace);
            });
            ILogger logger = loggerFactory.CreateLogger<Program>();
                        
            Console.Clear();
            var tasks = new Dictionary<string, string>();
            bool salir = false;
            do
            {
                Menu();
                int option = 0;
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        AddTask(ref tasks, logger);
                        break;
                    case 2:
                        RemoveTask(ref tasks, logger);
                        break;
                    case 3:
                        Console.Clear();
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No hay tareas registradas...");
                        }
                        else
                        {
                            Console.WriteLine("---Tareas Registradas---");
                            foreach (var task in tasks)
                            {
                                Console.WriteLine($"Tarea: {task.Key} - Descripción: {task.Value}");
                            }
                        }
                        break;

                    case 4:
                        salir = true;
                        Console.Clear();
                        Console.WriteLine("Hasta la proxima...");
                        Thread.Sleep(1000);
                        break;
                    default:
                        Console.WriteLine("Opción no válida...");
                        break;
                }
            } while (!salir);


        }
        static void Menu()
        {
            Console.WriteLine("---Gestión de tareas---");
            Console.WriteLine("1.- Agregar tarea");
            Console.WriteLine("2.- Eliminar tarea");
            Console.WriteLine("3.- Listar tarea");
            Console.WriteLine("4.- Salir");
            Console.WriteLine("Elija la opción deseada...");
        }
        static void AddTask(ref Dictionary<string, string> tasks, ILogger logger)
        {
            Console.Clear();
            Stopwatch sp = new Stopwatch();
            sp.Start();
            Console.WriteLine("Ingresa nombre de tarea");
            string name = Console.ReadLine();
            Console.WriteLine("Ingresa descripción de la tarea");
            string description = Console.ReadLine();
            tasks.Add(name, description);
            sp.Stop();
            LogAddedTask(logger, (int)sp.ElapsedMilliseconds / 1000);

        }

        [LoggerMessage(level: LogLevel.Information, Message = "Se agrega tarea en {time} segundos")]
        static partial void LogAddedTask(ILogger logger, int time);
        static void RemoveTask(ref Dictionary<string, string> tasks, ILogger logger)
        {
            Console.Clear();
            if (tasks.Count == 0)
            {
                Console.WriteLine("No hay tareas registradas...");
                return;
            }
            Stopwatch sp = new Stopwatch();
            sp.Start();
            Console.WriteLine("Ingresa nombre de tarea");
            string name = Console.ReadLine();
            tasks.Remove(name);
            sp.Stop();
            LogTaskDeleted(logger, (int)sp.ElapsedMilliseconds / 1000);

        }
        [LoggerMessage(level: LogLevel.Information, Message = "Se elimina tarea en {time} segundos")]
        static partial void LogTaskDeleted(ILogger logger, int time);
    }

}