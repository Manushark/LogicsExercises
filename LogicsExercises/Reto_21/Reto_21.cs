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

        //Extra Difficulty

        public delegate void Callback_Pedido(string callback);

        //La funcion Order_Process recibe el nombre del plato y tres callbacks para confirmar, listo y entregado
        //Esta es la funcion que se encarga de procesar el pedido
        public void Order_Process(string Pedido, Callback_Pedido Confirm_Order, Callback_Pedido Order_ready, Callback_Pedido Order_delivered)
        {
            Random rand = new Random();
            int tiempo_espera = rand.Next(1, 11); // Genera un número aleatorio entre 1 y 10
            Thread.Sleep(tiempo_espera * 1000); // Simula el tiempo de espera
            Confirm_Order(Pedido);
            Thread.Sleep(tiempo_espera * 1000); // Simula el tiempo de espera
            Order_ready(Pedido);
            Thread.Sleep(tiempo_espera * 1000); // Simula el tiempo de espera
            Order_delivered(Pedido);
        }
        public void Confirm_Order(string Pedido) 
        {
            Console.WriteLine($"Tu {Pedido} ha sido confirmado");
        } 
        public void Order_ready(string Pedido)
        {
            Console.WriteLine($"Tu {Pedido} esta listo para entregar");

        }
        public void Order_delivered(string Pedido)
        {
            Console.WriteLine($"Tu {Pedido} ha sido entregado");

        }
    }
    //Codigo para ejecutar el reto en Program.cs
     //public static void Main()
     //   {
     //       Reto_21 reto_21 = new Reto_21();
     //       reto_21.Procesar(5, MostrarNumero);//imprime el numero 5


     //       // Imprimir el nombre en mayúsculas
     //       reto_21.MostrarNombre("Manuel", ImprimirMayus);//Aqui podemos usar el metodo ImprimirMayus como callback para mostrar el nombre en mayusculas

     //       // Imprimir con un saludo
     //       reto_21.MostrarNombre("Andrea", Saludar);

     //       // Extra Difficulty
     //       reto_21.Order_Process("Pizza de Jamon con peperoni y queso parmesano", reto_21.Confirm_Order, reto_21.Order_ready, reto_21.Order_delivered);
     //   }

     //   // ====== Callbacks ======
     //   public static void ImprimirMayus(string n)
     //   {
     //       Console.WriteLine(n.ToUpper());
     //   }

     //   public static void Saludar(string n)
     //   {
     //       Console.WriteLine($"Hola {n}, que tengas un buen día.");
     //   }

     //   public static void MostrarNumero(int n)
     //   {
     //       Console.WriteLine($"El número es: {n}");
     //   }
    }
