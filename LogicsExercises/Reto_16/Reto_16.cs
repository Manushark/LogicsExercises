using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_16
{
    /*
     * EJERCICIO:
     * Utilizando tu lenguaje, explora el concepto de expresiones regulares,
     * creando una que sea capaz de encontrar y extraer todos los números
     * de un texto.
     *
     * DIFICULTAD EXTRA (opcional):
     * Crea 3 expresiones regulares (a tu criterio) capaces de:
     * - Validar un email.
     * - Validar un número de teléfono.
     * - Validar una url.
     */
    public class Reto_16
    {
        public void Run()
        {
            string text = "1 camion que pasaba por 2 puertos y se comio 3 pecez y las 4 gomas se pincharon66";

            MatchCollection matchCollection = Regex.Matches(text, @"(\d+)");
            foreach (Match match in matchCollection)
            {
                Console.WriteLine(match.Value);
            }


        }
    }
}
