using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_26
{
    public class Librery2
    {





    }
    /*Requisitos:
 * 1. Registrar libros: El sistema debe permitir agregar nuevos libros con
 * información básica como título, autor y número de copias disponibles.
 * 2. Registrar usuarios: El sistema debe permitir agregar nuevos usuarios con
 * información básica como nombre, número de identificación y correo electrónico.
 * 3. Procesar préstamos de libros: El sistema debe permitir a los usuarios
 * tomar prestados y devolver libros.
 * Instrucciones:
 * 1. Diseña una clase que no cumple el SRP: Crea una clase Library que maneje
 * los tres aspectos mencionados anteriormente (registro de libros, registro de
 * usuarios y procesamiento de préstamos).
 * 2. Refactoriza el código: Separa las responsabilidades en diferentes clases
 * siguiendo el Principio de Responsabilidad Única.
 */

    // Clase que cumple el Principio de Responsabilidad Única para la gestión de usuarios
    public class User
    {
        private int Count = 0;
        private int Id;
        public string Name { get; set; }
        public string mail { get; set; }

        public User (string name, string mail, int id)
        {
            Count++;
            this.Name = name;
            this.mail = mail;
            Id = Count;
        }
    }

    public class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int AvailableCopies { get; set; }
    }

    public class Loads
    {
        private Dictionary<string, string> loans = new Dictionary<string, string>();

    }

    public class UserServices
    {
        private List<User> users = new List<User>();
        public void RegisterUser(string name, string mail)
        {
            User newUser = new User(name, mail, users.Count + 1);
            users.Add(newUser);
        }
    }

    public class BookServices
    {
        private List<Books> books = new List<Books>();

        public void RegisterBook(string title, string author, int copies)
        {
            Books newbook = new Books()
            {
                Title = title,
                Author = author,
                AvailableCopies = copies
            };
        }
    }

    public class LoadServices
    {
        private Dictionary<string , string> loans = new Dictionary<string, string>();
        public void Loadbook(string bookTitle, string userName) 
        { 
            loans.Add(bookTitle, userName);
        }
    }
}
