using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_27
{
    /*
     * EJERCICIO:
     * Explora el "Principio SOLID Abierto-Cerrado (Open-Close Principle, OCP)"
     * y crea un ejemplo simple donde se muestre su funcionamiento
     * de forma correcta e incorrecta.
     *
     * DIFICULTAD EXTRA (opcional):
     * Desarrolla una calculadora que necesita realizar diversas operaciones matemáticas.
     * Requisitos:
     * - Debes diseñar un sistema que permita agregar nuevas operaciones utilizando el OCP.
     * Instrucciones:
     * 1. Implementa las operaciones de suma, resta, multiplicación y división.
     * 2. Comprueba que el sistema funciona.
     * 3. Agrega una quinta operación para calcular potencias.
     * 4. Comprueba que se cumple el OCP.
     */
    public class Reto_27
    {
        //Ejemplo de implementación incorrecta del Principio OCP
        public class Store
        {
            public double Calculate(string customerType, double price)
            {
                if (customerType == "Student")
                    return price * 0.9;

                if (customerType == "VIP")
                    return price * 0.8;

                if (customerType == "Employee")
                    return price * 0.7;

                return price;
            }

        }
    }
}
