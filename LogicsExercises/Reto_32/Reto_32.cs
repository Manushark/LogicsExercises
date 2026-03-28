using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_32
{
    public class Reto_32
    {
        /*
         * EJERCICIO:
         * ¡Deadpool y Wolverine se enfrentan en una batalla épica!
         * Crea un programa que simule la pelea y determine un ganador.
         * El programa simula un combate por turnos, donde cada protagonista posee unos
         * puntos de vida iniciales, un daño de ataque variable y diferentes cualidades
         * de regeneración y evasión de ataques.
         * Requisitos:
         * 1. El usuario debe determinar la vida inicial de cada protagonista.
         * 2. Cada personaje puede impartir un daño aleatorio:
         *    - Deadpool: Entre 10 y 100.
         *    - Wolverine: Entre 10 y 120.
         * 3. Si el daño es el máximo, el personaje que lo recibe no ataca en el
         * siguiente turno, ya que tiene que regenerarse (pero no aumenta vida).
         * 4. Cada personaje puede evitar el ataque contrario:
         *    - Deadpool: 25% de posibilidades.
         *    - Wolverine: 20% de posibilidades.
         * 5. Un personaje pierde si sus puntos de vida llegan a cero o menos.
         * Acciones:
         * 1. Simula una batalla.
         * 2. Muestra el número del turno (pausa de 1 segundo entre turnos).
         * 3. Muestra qué pasa en cada turno.
         * 4. Muestra la vida en cada turno.
         * 5. Muestra el resultado final.
         */
        public void Run()
        {
            int VidaDeadpool, VidaWolverine;
            Random rnd = new Random();
            Console.WriteLine("¡Bienvenido a la batalla épica entre Deadpool y Wolverine!");

            while (true)
            {
                bool DeadpoolPierdeTurno = false, WolverinePierdeTurno = false; 

                Console.WriteLine("Ingrese la vida inicial de Deadpool:");
                VidaDeadpool = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la vida inicial de Wolverine:");
                VidaWolverine = int.Parse(Console.ReadLine());

                int turno = 1;
                while (VidaDeadpool > 0 && VidaWolverine > 0)
                {
                    int danoDeadpool = rnd.Next(10, 101);
                    int danoWolverine = rnd.Next(10, 121);
                    Thread.Sleep(3000);
                    Console.WriteLine( );
                    Console.WriteLine($"Turno {turno}:");

                    // Deadpool ataca a Wolverine
                    if (DeadpoolPierdeTurno)
                    {
                        Console.WriteLine("Deadpool pierde este turno para regenerarse.");
                        DeadpoolPierdeTurno = false;
                    }
                    else
                    {
                        if (rnd.Next(100) < 25)
                        {
                            Console.WriteLine("Wolverine evade el ataque de Deadpool.");
                        }
                        else
                        {
                            VidaWolverine -= danoDeadpool;
                            Console.WriteLine($"Deadpool ataca a Wolverine y causa {danoDeadpool} de daño.");
                            Console.WriteLine("=======================================");
                            Console.WriteLine($"Vida de Wolverine: {VidaWolverine}");

                            if (danoDeadpool == 100) 
                            {
                                WolverinePierdeTurno = true;
                            }
                        }
                    }

                    if (VidaWolverine <= 0)
                    {
                        break;
                    }

                    Console.WriteLine();
                    Thread.Sleep(3000);

                    // Wolverine ataca a Deadpool
                    if (WolverinePierdeTurno)
                    {
                        Console.WriteLine("Wolverine pierde este turno para regenerarse."); 
                        WolverinePierdeTurno = false;
                    }
                    else
                    {
                        if (rnd.Next(100) < 20)
                        {
                            Console.WriteLine("Wolverine evade el ataque de Deadpool.");
                        }
                        else
                        {
                            VidaDeadpool -= danoWolverine;
                            Console.WriteLine($"Wolverine ataca a Deadpool y causa {danoWolverine} de daño.");
                            Console.WriteLine("=======================================");
                            Console.WriteLine($"Vida de Deadpool: {VidaDeadpool}");
                        }

                        if (danoWolverine == 120) 
                        {
                            DeadpoolPierdeTurno = true;
                        }
                    }

                    turno++;
                }

                if (VidaDeadpool <= 0)
                    Console.WriteLine("¡Wolverine gana la batalla!");
                else
                    Console.WriteLine("¡Deadpool gana la batalla!");
            }
        }
    }

    //Tomorrow, I will come back to finish this proyect.
}
