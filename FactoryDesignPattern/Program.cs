
using FactoryDesignPattern;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Notification Type(SMS/Email/Push) :");
        string type=Console.ReadLine();

        Console.Write("Enter recipient: ");
        string recipient = Console.ReadLine();

        Console.Write("Enter message: ");
        string message = Console.ReadLine();
        try
        { 
         NotificationFactory notify = new NotificationFactory();
         INotification notification=notify.createNotification(type);
         notification.sendNotification(recipient, message);
         }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

}
