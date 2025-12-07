using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_23
{
    /*
     * EJERCICIO:
     * Explora el patrón de diseño "singleton" y muestra cómo crearlo
     * con un ejemplo genérico.
     *
     * DIFICULTAD EXTRA (opcional):
     * Utiliza el patrón de diseño "singleton" para representar una clase que
     * haga referencia a la sesión de usuario de una aplicación ficticia.
     * La sesión debe permitir asignar un usuario (id, username, nombre y email),
     * recuperar los datos del usuario y borrar los datos de la sesión.
     */
    public class Reto_23
    {
        public class CEOAccess
        {
            // La única instancia del CEO
            private static CEOAccess _instance;

            // Constructor privado (evita que se cree con "new")
            private CEOAccess()
            {
                Console.WriteLine("CEO autorizado en el sistema.");
            }

            // Propiedad pública para obtener el único CEO
            public static CEOAccess Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new CEOAccess();  // se crea solo una vez

                    return _instance;
                }
            }

            // Acción que solo el CEO puede hacer, solo se puede acceder cuando se tiene la instancia
            public void AccessRestrictedArea()
            {
                Console.WriteLine("Accediendo al área secreta de la base de datos...");
            }
        }

    }
}
