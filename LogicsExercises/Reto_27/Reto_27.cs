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


        //Ejemplo de implementación correcta del Principio OCP

        public interface IDiscount
        {
            double Apply(double price);
        }

        // Esta clase representa SOLO el descuento para estudiantes
        public class StudentDiscount : IDiscount 
        { 
            public double Apply(double price)
            {
                return price * 0.9;
            }
        }

        public class VipDiscount : IDiscount
        {
            public double Apply(double price)
            {
                return price * 0.8;
            }
        }
        public class EmployeeDiscount : IDiscount
        {
            public double Apply(double price)
            {
                return price * 0.7;
            }
        }

        //Esta clase nunca se modifica para agregar nuevos tipos de descuentos
        public class PriceCalculator
        {
            public double CalculatePrice(double price, IDiscount discount)
            {
                // No pregunta qué tipo de descuento es
                // Solo confía en que sabe aplicarse
                return discount.Apply(price);
            }
        }

    }
}

