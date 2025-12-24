using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicsExercises.Reto_27;

namespace LogicsExercises.Reto_28
{
    /* DIFICULTAD EXTRA(opcional) :
    * Crea una jerarquía de vehículos.Todos ellos deben poder acelerar y frenar, así como
    * cumplir el LSP.
    * Instrucciones:
    * 1. Crea la clase Vehículo.
    * 2. Añade tres subclases de Vehículo.
    * 3. Implementa las operaciones "acelerar" y "frenar" como corresponda.
    * 4. Desarrolla un código que compruebe que se cumple el LSP.
    */
    public abstract class Vehicle
    {
        protected int speed;

        public int Speed => speed;

        protected Vehicle(int speed = 0)
        {
            this.speed = speed;
        }

        public virtual void Accelerate(int increment)
        {
            speed += increment;
        }

        public virtual void Brake(int decrement)
        {
            speed -= decrement;
            if (speed < 0)
                speed = 0;
        }
    }


    public class Car : Vehicle
    {
        public void Accelerate()
        {
            base.Accelerate(30);
            Console.WriteLine($"El coche acelera a {Speed} km/h");
        }

        public void Brake() 
        {
            base.Brake(5);
        }
    }

    public class Motocycle : Vehicle
    {
        public void Accelerate()
        {
            base.Accelerate(20);
            Console.WriteLine($"La motocicleta acelera a {Speed} km/h");
        }

        public void Brake()
        {
           base.Brake(3);
        }
    }

    public class Bicycle : Vehicle
    {
        public void Accelerate()
        {
            base.Accelerate(5);
            Console.WriteLine($"La bicicleta acelera a {Speed} km/h");
        }

        public void Brake()
        {
            base.Brake(2);
        }
    }

}
