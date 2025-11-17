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
            //Este regex busca todos los numeros en un texto y los extrae
            string text = "1 camion que pasaba por 2 puertos y se comio 3 pecez y las 4 gomas se pincharon66";

            MatchCollection matchCollection = Regex.Matches(text, @"(\d+)");
            foreach (Match match in matchCollection)
            {
                Console.WriteLine(match.Value);
            }

            //Este regex valida un email
            string email = "manu@mail.com";
            bool valid = Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w{2,}$");//estos caracteres significan: ^ inicio de la cadena, [\w\.-]+ uno o más caracteres alfanuméricos, puntos o guiones, @ símbolo arroba, [\w\.-]+ uno o más caracteres alfanuméricos, puntos o guiones, \. un punto literal,
                                                                              //\w{2,} dos o más caracteres alfanuméricos para el dominio de nivel superior, $ fin de la cadena

            Console.WriteLine(valid);

            //Este regex valida un numero de telefono
            string phoneNumber = "+34 123 456 789";
            bool validPhone = Regex.IsMatch(phoneNumber, @"^\+?\d{1,3}[- ]?\d{3}[- ]?\d{3}[- ]?\d{3}$");//estos caracteres significan: ^ inicio de la cadena, \+? símbolo de más opcional, \d{1,3} uno a tres dígitos para el código de país, [- ]? guion o espacio opcional, \d{3} tres dígitos para el código de área, [- ]? guion o espacio opcional,
                                                                                                        //\d{3} tres dígitos para la primera parte del número, [- ]? guion o espacio opcional, \d{3} tres dígitos para la segunda parte del número, $ fin de la cadena
            Console.WriteLine(validPhone);

            //Este regex valida una URL
            string url = "https://www.ejemplo.com";
            bool validUrl = Regex.IsMatch(url, @"^(https?:\/\/)?(www\.)?[\w\-]+(\.[\w\-]+)+([\/\w\-\._~:\/?#[\]@!\$&'\(\)\*\+,;=]*)?$");//estos caracteres significan: ^ inicio de la cadena, (https?:\/\/)? protocolo opcional (http o https) seguido de ://, (www\.)? subdominio www opcional,
                                                                                                                                        //[\w\-]+ uno o más caracteres alfanuméricos o guiones para el nombre del dominio, (\.[\w\-]+)+ uno o más grupos de un punto seguido de uno o más caracteres alfanuméricos o guiones para el dominio de nivel superior,
                                                                                                                                        //([\/\w\-\._~:\/?#[\]@!\$&'\(\)\*\+,;=]*)? parte opcional para la ruta, parámetros y fragmentos de la URL, $ fin de la cadena
            //Este regex valida una contraseña fuerte
            string pass = "Manu1234";
            bool strong = Regex.IsMatch(pass, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$");//Estos caracteres significan: ^ inicio de la cadena, (?=.*[A-Z]) al menos una letra mayúscula, (?=.*[a-z]) al menos una letra minúscula,
                                                                                        //(?=.*\d) al menos un dígito, .{8,} al menos 8 caracteres en total, $ fin de la cadena

            //Extraer direcciones IP de un texto
            var matches = Regex.Matches("Ping a 192.168.1.5 completado", @"\b\d{1,3}(\.\d{1,3}){3}\b");//Estos caracteres significan: \b límite de palabra, \d{1,3} uno a tres dígitos,
                                                                                                       //(\.\d{1,3}){3} tres grupos de un punto seguido de uno a tres dígitos, \b límite de palabra
            foreach (Match m in matches)
                Console.WriteLine(m.Value);

            //Para compilar 
            //Reto_16 reto_16 = new Reto_16();
            //reto_16.Run();
        }
    }
}
