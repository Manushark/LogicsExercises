using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LogicsExercises.Reto_26.Reto_26;

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
        private int Id { get; }
        public string Name { get; set; }
        public string mail { get; set; }

        public User (string name, string mail, int id)
        {
            this.Name = name;
            this.mail = mail;
            Id = id;
        }
    }

    public class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int AvailableCopies { get; set; }
    }

    public class Loans
    {
        public User User { get; }
        public Books Book { get; }
        public DateTime LoanDate { get; }
        public DateTime? ReturnDate { get; private set; }

        public Loans(User user, Books book)
        {
            User = user;
            Book = book;
            LoanDate = DateTime.Now;
        }

        public void ReturnBook()
        {
            ReturnDate = DateTime.Now;
        }
    }

    public class UserServices
    {
        private List<User> users = new List<User>();
        private int nextId = 1;

        public User RegisterUser(string name, string mail)
        {
            var newUser = new User(name, mail, nextId++);
            users.Add(newUser);
            return newUser;

        }
    }

    public class BookServices
    {
        private List<Books> books = new List<Books>();

        public Books RegisterBook(string title, string author, int copies)
        {
            Books newbook = new Books()
            {
                Title = title,
                Author = author,
                AvailableCopies = copies
            };

            books.Add(newbook);
            return newbook;
        }
    }

  
        public class LoanService
        {
            private List<Loans> loans = new List<Loans>();

            public Loans BorrowBook(User user, Books book)
            {
                if (book.AvailableCopies <= 0)
                    throw new Exception("No copies available");

                book.AvailableCopies--;
                var loan = new Loans(user, book);
                loans.Add(loan);
                return loan;
            }

            public void ReturnBook(Loans loan)
            {
                loan.ReturnBook();
                loan.Book.AvailableCopies++;
            }
        }

    
}
