using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_21
{
    /*
     * EJERCICIO:
     * Explora el concepto de callback en tu lenguaje creando un ejemplo
     * simple (a tu elección) que muestre su funcionamiento.
     *
     * DIFICULTAD EXTRA (opcional):
     * Crea un simulador de pedidos de un restaurante utilizando callbacks.
     * Estará formado por una función que procesa pedidos.
     * Debe aceptar el nombre del plato, una callback de confirmación, una
     * de listo y otra de entrega.
     * - Debe imprimir un confirmación cuando empiece el procesamiento.
     * - Debe simular un tiempo aleatorio entre 1 a 10 segundos entre
     *   procesos.
     * - Debe invocar a cada callback siguiendo un orden de procesado.
     * - Debe notificar que el plato está listo o ha sido entregado.
     */
    public class Reto_21
    {
        //El callback es una funcion que se pasa como parametro a otra funcion para que esta la llame en un momento determinado, basicamente cuando se cree el objeto
        //y se pase el dato por parametros uno de esos parametros puede ser una funcion que se ejecutara dentro de la funcion principal.
        public delegate void MiCallback(int numero);

        public void Procesar(int numero, MiCallback callback)
        {
            callback(numero);
        }

        public void MostrarNumero(int n)
        {
            Console.WriteLine($"El número es: {n}");
        }

        public delegate void NombreCallback(string nombre);

        public void MostrarNombre(string nombre, NombreCallback callback)
        {
            callback(nombre);
        }


    }
}
