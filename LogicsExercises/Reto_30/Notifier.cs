using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*   DIFICULTAD EXTRA(opcional):
     *Crea un sistema de notificaciones.
     * Requisitos:
     *1.El sistema puede enviar Email, PUSH y SMS (implementaciones específicas).
     * 2. El sistema de notificaciones no puede depender de las implementaciones específicas.
     * Instrucciones:
     *1.Crea la interfaz o clase abstracta.
     * 2. Desarrolla las implementaciones específicas.
     * 3. Crea el sistema de notificaciones usando el DIP.
     * 4. Desarrolla un código que compruebe que se cumple el principio.
     */
namespace LogicsExercises.Reto_30
{
    public interface Notifier
    {
        void Send(string message);
    }

    public class EmailNotifier : Notifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending email: " + message);
        }
    }

    public class SMSNotifier : Notifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }

    public class PushNotifier : Notifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending PUSH notification: " + message);
        }
    }

    public class NotificationService
    {
        private readonly Notifier _notifier;
        public NotificationService(Notifier notifier)
        {
            _notifier = notifier;
        }
        public void Notify(string message)
        {
            _notifier.Send(message);
        }
    }

    //Code to test the implementation
    //// Implementación del patrón Strategy para notificaciones
    //    Notifier notifier = new EmailNotifier();
    //    NotificationService notificationService = new NotificationService(notifier);
    //    notificationService.Notify("Hello, this is a test notification!");

    //    // Cambiamos la estrategia a SMS
    //    notifier = new SMSNotifier();
    //    notificationService = new NotificationService(notifier);
    //    notificationService.Notify("Hello, this is a test notification via SMS!");

    //    // Cambiamos la estrategia a PUSH
    //    notifier = new PushNotifier();
    //    notificationService = new NotificationService(notifier);
    //    notificationService.Notify("Hello, this is a test PUSH notification!");

}
