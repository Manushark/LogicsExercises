using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LogicsExercises.Reto_03
{
    public class Reto_03
    {
        /*
        * EJERCICIO:
        * Muestra ejemplos de todas las operaciones que puedes realizar con cadenas de caracteres
        * en tu lenguaje. Algunas de esas operaciones podrían ser (busca todas las que puedas):
        * - Acceso a caracteres específicos, subcadenas, longitud, concatenación, repetición,
        *   recorrido, conversión a mayúsculas y minúsculas, reemplazo, división, unión,
        *   interpolación, verificación...
        *
        * DIFICULTAD EXTRA (opcional):
        * Crea un programa que analice dos palabras diferentes y realice comprobaciones
        * para descubrir si son:
        * - Palíndromos
        * - Anagramas
        * - Isogramas
        */
        public static void Run()
        {
            //Console.WriteLine("Ejemplos de operaciones con cadenas de caracteres en C#:");
            string str = "Hellou World";
           
            // Acceso a caracteres específicos
            Console.WriteLine($"Primer Caracter: {str[0]}");// Nos permite obtener un carácter concreto de una posición usando índices.
            Console.WriteLine($"Ultimo Caracter: {str[str.Length - 1]}");

            // Longitud
            Console.WriteLine($"Longitud de la cadena: {str.Length}");// Nos permite conocer la cantidad de caracteres que tiene una cadena.

            // Subcadenas
            Console.WriteLine($"Subcadena (0,5): {str.Substring(0 , 5)}");// Nos permite extraer una parte de la cadena. El primer parámetro es la posición inicial y el segundo es la longitud de la subcadena.

            // Concatenación
            string str2 = " - Bienvenido a C#";
            string concatenacion = string.Concat(str, str2);
            Console.WriteLine($"Concatenación: {concatenacion}");// Nos permite unir dos o más cadenas en una sola.

            // Repetición 
            string repeticion = new string('*', 100);
            Console.WriteLine($"Repetición: {repeticion}");// Nos permite crear una nueva cadena repitiendo un carácter un número específico de veces.

            // Recorrido
            Console.Write("Recorrido: ");
            
            foreach (char c in str)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();// Nos permite iterar sobre cada carácter de la cadena.

            // Conversión a mayúsculas y minúsculas
            Console.WriteLine($"Mayúsculas: {str.ToUpper()}");// Nos permite convertir todos los caracteres de la cadena a mayúsculas.
            Console.WriteLine($"Minúsculas: {str.ToLower()}");// Nos permite convertir todos los caracteres de la cadena a minúsculas.

            // Reemplazo
            Console.WriteLine($"Reemplazo: {str.Replace("Hellou", "Hola")}");// Nos permite sustituir todas las apariciones de una subcadena por otra.

            // División
            string[] palabras = str.Split(' ');
            Console.WriteLine("División:");
            foreach (string palabra in palabras)
            {
                Console.WriteLine(palabra);
            }// Nos permite dividir la cadena en un array de subcadenas basándonos en un carácter separador.

            // Unión
            string union = string.Join(" - ", palabras);
            Console.WriteLine($"Unión: {union}");// Nos permite unir los elementos de un array de cadenas en una sola cadena, usando un separador específico.

            // Interpolación
            Console.WriteLine($"Interpolación: {str} - Longitud: {str.Length}");// Nos permite insertar valores de variables dentro de una cadena de forma más legible.
            // Verificación
            Console.WriteLine($"Verificación (contiene 'World'): {str.Contains("World")}");// Nos permite comprobar si una subcadena está presente dentro de la cadena.

            // Verificación (empieza con 'Hellou')
            Console.WriteLine($"Verificación (empieza con 'Hellou'): {str.StartsWith("Hellou")}");
           
            // Verificación (termina con 'C#')
            Console.WriteLine($"Verificación (termina con 'C#'): {str.EndsWith("C#")}");

            // Verificación (es nula o vacía)
            Console.WriteLine($"Verificación (es nula o vacía): {string.IsNullOrEmpty(str)}");
            Console.WriteLine();

            //Verificaciones (StartsWith, EndsWith, Contains, Equals)
            Console.WriteLine($"¿Empieza con 'Hola'? {str.StartsWith("He")}");
            Console.WriteLine($"¿Termina con 'do'? {str.EndsWith("ld")}");
            Console.WriteLine($"¿Contiene 'Mun'? {str.Contains("Wo")}");
            Console.WriteLine($"¿Es igual a 'hola mundo'? {str.Equals("hola mundo", StringComparison.OrdinalIgnoreCase)}");
            // buscar coincidencias, validar nombres, extensiones de archivo, o textos introducidos por el usuario.

            // Eliminar espacios en blanco
            string conEspacios = "   Hola   ";
            Console.WriteLine($"Trim: '{conEspacios.Trim()}'");
            Console.WriteLine($"TrimStart: '{conEspacios.TrimStart()}'");
            Console.WriteLine($"TrimEnd: '{conEspacios.TrimEnd()}'");
            // limpiar entradas del usuario antes de guardarlas o compararlas (muy común en formularios).

            // Insertar texto
            string insertado = str.Insert(5, "bonito ");
            Console.WriteLine($"Insertar texto: {insertado}");
            //  agregar palabras o símbolos dentro de un texto en posiciones específicas.

            // Eliminar parte de una cadena (Remove)
            string eliminado = str.Remove(4, 1); // quita el espacio
            Console.WriteLine($"Eliminar parte: {eliminado}");
            //  quitar caracteres o fragmentos, por ejemplo, limpiar códigos o eliminar guiones.

            // Comparación (CompareTo)
            string a = "Hola";
            string b = "Mundo";
            Console.WriteLine($"Comparación ('Hola' vs 'Mundo'): {a.CompareTo(b)}");
            //  comparar cadenas alfabéticamente (útil para ordenar listas o verificar precedencia).

            //Conversión de número a texto y viceversa
            int numero = 123;
            string numeroTexto = numero.ToString();
            int numeroConvertido = int.Parse(numeroTexto);
            Console.WriteLine($"Número a texto: {numeroTexto}, texto a número: {numeroConvertido}");
            //  mostrar números como texto (por ejemplo, en facturas) o convertir texto introducido a número.

            // Formato compuesto
            string formato = string.Format("El valor de PI es {0:F2}", Math.PI);
            Console.WriteLine(formato);
            //  mostrar valores numéricos o fechas con formato específico en informes o pantallas.

            // Búsqueda de posición (IndexOf, LastIndexOf)
            Console.WriteLine($"Posición de 'a': {str.IndexOf('a')}");
            Console.WriteLine($"Última posición de 'o': {str.LastIndexOf('o')}");
            //  encontrar dónde aparece algo (por ejemplo, localizar un carácter o palabra dentro de un texto).

            // Comprobación de vacío o nulo
            string vacia = "";
            Console.WriteLine($"¿Está vacía? {string.IsNullOrEmpty(vacia)}");
            // evitar errores antes de procesar cadenas vacías o nulas.
        }
    }
}
