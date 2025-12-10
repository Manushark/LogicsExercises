using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Interfaces
{
    /* 
     * Las interfaces son contratos que obligan 
     * a las clases a implementar sus métodos.
     */

    public interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }


    public class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("The car is shaking");
        }

        public void StopEngine() 
        { 
            Console.WriteLine("The car is moveless"); 
        }
    }

    public class Motocycle : IVehicle
    {
        public void StartEngine() {
            Console.WriteLine("The moto is shaking");
        }

        public void StopEngine() { 
            Console.WriteLine("The moto is static"); 
        }
    }

    
}

