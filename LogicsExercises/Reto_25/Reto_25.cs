using System;
using System.Collections.Generic;
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
    public class Reto_25
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
    }
}
