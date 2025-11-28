using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;
using System.Reflection;
using System.Text.RegularExpressions;


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
            using (var HttpClient = new HttpClient())
            {
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

        // Metodo simple sin manejo de errores
        public async Task RunSimple()
        {
            var url = "https://jsonplaceholder.typicode.com/posts/1";
            var client = new HttpClient();// Porque no usamos using? Porque en este caso no es estrictamente necesario, pero en aplicaciones reales si lo es para evitar fugas de memoria

            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            Console.WriteLine(content);
        }

        // Metodo mas profesional con manejo de errores
        public async Task RunProfessional()
        {
            var url = "https://jsonplaceholder.typicode.com/posts/1";

            using var httpClient = new HttpClient();

            try
            {
                var response = await httpClient.GetAsync(url);

                response.EnsureSuccessStatusCode();  // Lanza excepción si no es 200

                var content = await response.Content.ReadAsStringAsync();

                Console.WriteLine("Request successful:");
                Console.WriteLine(content);
            }
            catch (HttpRequestException ex)//Especifico para errores HTTP
            {
                Console.WriteLine($"HTTP Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }

        //DIFICULTAD EXTRA(opcional):

        public async Task RunExtra()
        {
            Console.Write("Introduzca el nombre del pokemon que desea buscar: ");
            var Pokemon = Console.ReadLine().ToLower();
            var url = $"https://pokeapi.co/api/v2/pokemon/{Pokemon}/";
            var Pokedex = new HttpClient(); //Una instancia de HttpClient para hacer las peticiones


            var content = await Pokedex.GetAsync(url);// Hacemos la peticion HTTP y esperamos la respuesta
            content.EnsureSuccessStatusCode();// Verifica que la respuesta fue exitosa
            var xx = await content.Content.ReadAsStringAsync();// Leemos el contenido de la respuesta como una cadena

            // Parseamos el JSON obtenido en un JsonNode para facilitar el acceso a los datos
            var data = JsonNode.Parse(xx);
            Console.WriteLine($"ID: {data["id"]}");
            Console.WriteLine($"Nombre: {data["name"]}");
            Console.WriteLine($"Peso: {data["weight"]}");
            Console.WriteLine($"Altura: {data["height"]}");

            //aqui mostramos los tipos del pokemon
            foreach (var t in data["types"].AsArray())
            {
                Console.WriteLine($"Tipo: {t["type"]["name"]}");
            }
            
            
            Console.Write("Introduzca el nombre del pokemon para ver sus evoluciones: ");
            var Evo = Console.ReadLine().ToLower();

            var url_species = $"https://pokeapi.co/api/v2/pokemon-species/{Evo}/";

            using var http = new HttpClient();

            // Obtenemos especie
            var speciesResponse = await http.GetAsync(url_species);
            speciesResponse.EnsureSuccessStatusCode();

            var speciesJson = await speciesResponse.Content.ReadAsStringAsync();
            var speciesData = JsonNode.Parse(speciesJson);

            // Obtenemos URL de la cadena
            var evoChainUrl = speciesData["evolution_chain"]["url"].ToString();

            // 3. Llamar la cadena de evolución
            var evoResponse = await http.GetAsync(evoChainUrl);//Lo que hacemos es llamar a la URL obtenida anteriormente
            evoResponse.EnsureSuccessStatusCode();

            var evoJson = await evoResponse.Content.ReadAsStringAsync();
            var evoData = JsonNode.Parse(evoJson);

            // 4. Imprimir la cadena
            Console.WriteLine("\nCadena de Evoluciones:");

            var current = evoData["chain"];

            //Este es un bucle para recorrer la cadena de evoluciones y mostrar cada una
            while (current != null)
            {
                Console.WriteLine($"- {current["species"]["name"]}");

                var nextForms = current["evolves_to"].AsArray();//aqui obtenemos las siguientes evoluciones

                if (nextForms.Count == 0)
                    break; // No hay más evoluciones

                current = nextForms[0]; // Tomamos la primera evolución
            }

            // Mostrar juegos en los que aparece
            Console.WriteLine("Aparece en los siguientes juegos:");
            foreach (var game in data["game_indices"].AsArray())
            {
                Console.WriteLine($"- {game["version"]["name"]}");
            }
        }
    }
}
