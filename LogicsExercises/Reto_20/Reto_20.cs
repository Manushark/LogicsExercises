using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_20
{
    /*
     * EJERCICIO:
     * Utilizando un mecanismo de peticiones HTTP de tu lenguaje, realiza
     * una petición a la web que tú quieras, verifica que dicha petición
     * fue exitosa y muestra por consola el contenido de la web.
     *
     * DIFICULTAD EXTRA (opcional):
     * Utilizando la PokéAPI (https://pokeapi.co), crea un programa por
     * terminal al que le puedas solicitar información de un Pokémon concreto
     * utilizando su nombre o número.
     * - Muestra el nombre, id, peso, altura y tipo(s) del Pokémon
     * - Muestra el nombre de su cadena de evoluciones
     * - Muestra los juegos en los que aparece
     * - Controla posibles errores
     */
    public class Reto_20
    {
        public async Task Run()
        {
            var url = "https://jsonplaceholder.typicode.com/posts/1";

            // Aqui realizamos la peticion HTTP con Using para asegurar el cierre del cliente
            using (var HttpClient = new HttpClient()) {
                var response = await HttpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine(response.StatusCode);
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"funciono: {content}");
                }
                else { Console.WriteLine("Ha habido un error"); }
            }
        }

        public async Task RunSimple()
        {
            var url = "https://jsonplaceholder.typicode.com/posts/1";
            var client = new HttpClient();

            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            Console.WriteLine(content);
        }

        public async Task RunProfessional()
        {
            var url = "https://jsonplaceholder.typicode.com/posts/1";

            using var httpClient = new HttpClient();

            try
            {
                var response = await httpClient.GetAsync(url);

                response.EnsureSuccessStatusCode();  // Lanza excepción si no es 200

                var content = await response.Content.ReadAsStringAsync();

                Console.WriteLine("✔ Request successful:");
                Console.WriteLine(content);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"❌ HTTP Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Unexpected Error: {ex.Message}");
            }
        }


    }
}
