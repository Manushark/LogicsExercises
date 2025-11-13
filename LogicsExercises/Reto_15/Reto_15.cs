using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_15
{
    /*
     * EJERCICIO:
     * Utilizando tu lenguaje, crea un programa capaz de ejecutar de manera
     * asíncrona una función que tardará en finalizar un número concreto de
     * segundos parametrizables. También debes poder asignarle un nombre.
     * La función imprime su nombre, cuándo empieza, el tiempo que durará
     * su ejecución y cuando finaliza.
     *
     * DIFICULTAD EXTRA (opcional):
     * Utilizando el concepto de asincronía y la función anterior, crea
     * el siguiente programa que ejecuta en este orden:
     * - Una función C que dura 3 segundos.
     * - Una función B que dura 2 segundos.
     * - Una función A que dura 1 segundo.
     * - Una función D que dura 1 segundo.
     * - Las funciones C, B y A se ejecutan en paralelo.
     * - La función D comienza su ejecución cuando las 3 anteriores han finalizado.
     */
    public class Reto_15
    {
        //First version
        //public async Task Run(int second)
        //{
        //    Task task = Task.Run(async () =>
        //    {
        //        Console.Write("Ingrese el nombre de la función: ");
        //        string name = Console.ReadLine();

        //        Console.WriteLine($"La funcion se llama: {name}");

        //        Console.WriteLine($"[{name}] Inicio | Duración: {second} segundos | Hora: {DateTime.Now:T}");

        //        await Task.Delay(second * 1000);

        //        Console.WriteLine($"Final de la ejecucion: {DateTime.Now}");

        //    });

        //    await task;
        //}

        //Second version with name parameter
        public async Task Run(string name, int seconds)
        {
            Console.WriteLine($"[{name}] Inicio | Duración: {seconds} segundos | Hora: {DateTime.Now:T}");

            await Task.Delay(seconds * 1000);

            Console.WriteLine($"[{name}] Fin | Hora: {DateTime.Now:T}");
        }

    }



}

    
