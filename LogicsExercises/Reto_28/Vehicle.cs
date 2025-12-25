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
            Console.WriteLine($"Velocidad actual: {speed} km/h");

        }

        public virtual void Brake(int decrement)
        {
            speed -= decrement;
            if (speed < 0)
                speed = 0;
            Console.WriteLine($"Velocidad actual: {speed} km/h");
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
    // Para compilar el código de ejemplo
       //Reto 28 - Principio de Sustitución de Liskov (LSP)
        //static void TestVehicle(Vehicle vehicle)
        //{
        //    vehicle.Accelerate(10);
        //    vehicle.Brake(5);
        //    Console.WriteLine($"Velocidad final: {vehicle.Speed}");
        //}
        
        //Console.WriteLine("Pruebas de Vehículos:");
        //Console.WriteLine("Carros");
        //Console.WriteLine("----------------------");
        //Vehicle car = new Car();
        //car.Accelerate(50);
        //car.Brake(15);

        //TestVehicle(car);


        //Console.WriteLine("----------------------");
        //Console.WriteLine("Motocicletas");
        //Vehicle moto = new Motocycle();
        //moto.Accelerate(30);
        //moto.Brake(20); 

        //TestVehicle(moto);//Esto comprueba el LSP porque estamos usando la clase base Vehicle para probar las subclases Car y Motocycle sin importar su implementación interna

        //Console.WriteLine("----------------------");
        //Console.WriteLine("Bicicletas");
        //Vehicle bike = new Bicycle();
        //bike.Accelerate(15);
        //bike.Accelerate(10);
        //bike.Brake(26);

        //TestVehicle(bike);
}
