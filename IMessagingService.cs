using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraction
{
    //Abstraction Layer
    //Define a common interface for all messaging platforms
    public interface IMessagingService
    {
        void SendMessage(string recipient, string message);
    }

    //Concrete Implementations
    //Now, we'll create concrete classes that implement this interface
    public class EmailService : IMessagingService
    {
        public void SendMessage(string recipient, string message)
        {
            System.Console.WriteLine($"Here, you'd have the actual logic to send an email");
            //Here, you'd have the actual logic to send an email.
        }
    }

    public class SMSService : IMessagingService
    {
        public void SendMessage(string recipient, string message)
        {
            System.Console.WriteLine($"Sending SMS to {recipient}: {message}");
            //Here, I'll have the actual logic to send an SMS
        }
    }
    public class PushNotificationService : IMessagingService
    {
        public void SendMessage(string recipient, string message)
        {
            System.Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
            // Here, you'd have the actual logic to send a push notification.
        }
    }

    //Testing Abstract Principle
    public class Program
    {
        public static void Main(string[] args)
        {
            //Using the Abstraction
            //With the Abstraction Principle applied, if you need to send a message,
            //you dont need to know if it's an email, SMS, OR push notification.
            //You just call SendMessage() on any service implementing IMessagingService.

            IMessagingService emailService = new EmailService();
            IMessagingService smsService = new SMSService();
            IMessagingService pushService = new PushNotificationService();

            SendAlert(emailService, "douglaso@sf.com", "Hello via Email");
            SendAlert(smsService, "1234567890", "Hello via SMS!");
            SendAlert(pushService, "098766543321", "Hello via Push Notification");
        }
        static void SendAlert(IMessagingService service, string recipient, string message)
        {
            service.SendMessage(recipient, message);
        }
    }
}