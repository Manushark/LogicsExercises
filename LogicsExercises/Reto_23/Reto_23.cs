using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        //Dificultad Extra
        public class UserSeccion
        {
            /*
             * Creamos un atributo privado solo de 
             * lectura que será del mismo tipo de la 
             * clase en el cual estara el objeto que
             * se creara una vez se compile la 
             * solución
             */
            private static UserSeccion _instance;

            private static readonly object _lock = new object();//Objeto para el bloqueo en entornos multihilo
            private int Id;
            private string Username;
            private string Name;
            private string Correo;

            private UserSeccion() //El Constructor priv es muy importante que el constructor sea privado para evitar que se creen instancias adicionales desde fuera de la clase.
            {
            }

            /*
            * Para poder accedera a la instancia 
            * creamos una propiedad que regresa el
            * atributo privado
            */
            public static UserSeccion Instance
            {
                get
                {
                    lock (_lock)//El lock asegura que solo un hilo pueda acceder a esta sección del código a la vez o sea, que no se creen múltiples instancias en entornos multihilo.
                    {
                        if (_instance == null)
                            _instance = new UserSeccion();
                    }
                    return _instance;
                }
            }
            public string getUser()
            {
                return $"Id: {Id}, Usuario: {Username}, Nombre: {Name},  Correo: {Correo}";
            }

            public void setUser(int id, string username, string name, string correo)
            {
                this.Id = id;
                this.Username = username;
                this.Name = name;
                this.Correo = correo;
            }

            public void ClearUser()
            {
                this.Id=0;
                this.Username = "";
                this.Name = "";
                this.Correo = "";
            }
        }
    }

    
}
