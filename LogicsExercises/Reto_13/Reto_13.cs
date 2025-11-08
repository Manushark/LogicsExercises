using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_13
{
    /*
     * EJERCICIO:
     * Crea una función que se encargue de sumar dos números y retornar
     * su resultado.
     * Crea un test, utilizando las herramientas de tu lenguaje, que sea
     * capaz de determinar si esa función se ejecuta correctamente.
     *
     * DIFICULTAD EXTRA (opcional):
     * Crea un diccionario con las siguientes claves y valores:
     * "name": "Tu nombre"
     * "age": "Tu edad"
     * "birth_date": "Tu fecha de nacimiento"
     * "programming_languages": ["Listado de lenguajes de programación"]
     * Crea dos test:
     * - Un primero que determine que existen todos los campos.
     * - Un segundo que determine que los datos introducidos son correctos.
     */
    public static class Reto_13
    {
        public static void Run()
        {
            
        
        }

        public static int Sum(int Number1 = 5 , int Number2= 9)
        {
           int Result = Number1 + Number2;  
           return Result;
        }

    }
}
