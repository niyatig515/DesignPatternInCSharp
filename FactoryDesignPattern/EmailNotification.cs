using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class EmailNotification : INotification
    {  
       public void sendNotification(string recipient, string message)
        {
            Console.WriteLine($"Email Sent to {recipient} with message {message}");
        }
    }
}
